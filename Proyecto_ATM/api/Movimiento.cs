using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace Proyecto_ATM.api
{
    public class Movimiento
    {
        private string numeroCuenta;
        private Conector conector;
        private string pin;
        private PopUps popUp;

        public Movimiento(string numeroCuenta, string pin, Conector conector)
        {
            if (conector == null)
            {
                throw new ArgumentNullException(nameof(conector), "Connector is null");
            }
            this.numeroCuenta = numeroCuenta;
            this.conector = conector;
            this.pin = pin;
        }

        private void mostrar_error(string mensaje, Form Parent)
        {
            popUp = new PopUps();
            Console.WriteLine(mensaje);
            popUp.mostrar_error(mensaje, Parent);
        }
        private void mostrar_modal(Form Parent, Dictionary<int, int> billsToDispense) {
            int bills_100=0;
            int bills_200=0;
            int bills_500=0;
            if (billsToDispense.ContainsKey(100))
                bills_100 = billsToDispense[100];
            if (billsToDispense.ContainsKey(200))
                bills_200 = billsToDispense[200];
            if (billsToDispense.ContainsKey(500))
                bills_500 = billsToDispense[500];
            popUp = new PopUps();

            popUp.mostrar_billetes_dispensados(bills_100,bills_200,bills_500, Parent);

           



        }
        public bool retiro(double monto, Form Parent, String TipoRetiro)
        {
            double saldo = ConsultarSaldo(numeroCuenta);

            if (saldo < monto)
            {
                // Not enough balance
                return false;
            }

            Dictionary<int, int> billQuantities = GetBillQuantitiesFromDatabase();
            Dictionary<int, int> billsToDispense = new Dictionary<int, int>();
            int remainingAmount = (int)monto;

            if (remainingAmount % 100 != 0)
            {
                // Amount must be a multiple of 100
                return false;
            }

            foreach (var denomination in billQuantities.Keys.OrderByDescending(d => d))
            {
                if (remainingAmount == 0) break;

                int billsNeeded = remainingAmount / denomination;
                int billsAvailable = billQuantities[denomination];
                int billsToGive = Math.Min(billsNeeded, billsAvailable);

                if (billsToGive > 0)
                {
                    billsToDispense[denomination] = billsToGive;
                    remainingAmount -= billsToGive * denomination;
                }
            }

            if (remainingAmount > 0)
            {
                // Not enough bills to complete the transaction
                return false;
            }

            NpgsqlTransaction transaction = null;

            try
            {
                // Start a new transaction
                conector.Open();
                transaction = conector.ConectorConnection.BeginTransaction();

                // Update the saldo (balance) in the database
                using (var cmdSaldo = new NpgsqlCommand("UPDATE cuentas SET saldo_cuenta = saldo_cuenta - @monto WHERE no_cuenta = @numero_cuenta", conector.ConectorConnection))
                {
                    cmdSaldo.Parameters.AddWithValue("monto", monto);
                    cmdSaldo.Parameters.AddWithValue("numero_cuenta", numeroCuenta);
                    cmdSaldo.Transaction = transaction;
                    cmdSaldo.ExecuteNonQuery();
                }

                // Update the withdrawn bills in the database
                UpdateWithdrawnBillsInDatabase(billsToDispense, transaction);

                // Update the bills in the saldo_atm table
                UpdateBillQuantitiesInDatabase(billsToDispense, transaction);

                //Registro en historial
                LogWithdrawal(monto, GlobalState.Usuario.get_id(), TipoRetiro, transaction);

                // Commit the transaction if everything is successful
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during withdrawal: " + ex.Message);

                // Rollback the transaction if something goes wrong
                if (transaction != null)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception rollbackEx)
                    {
                        Console.WriteLine("Error during transaction rollback: " + rollbackEx.Message);
                    }
                }

                return false;
            }
            finally
            {
                conector.Close();
            }

            //mostrar_error("Retiro exitoso. Se han dispensado\n los siguientes billetes:",Parent);
            mostrar_modal(Parent,billsToDispense);
            return true;
        }

        public bool ProcesarRetiroConCodigo(string codigoIngresado, double montoIngresado,Form Parent)
        {
            Usuario usuario = new Usuario(); 

           
            if (ValidarCodigoRetiro(codigoIngresado, montoIngresado))
            {
                Console.WriteLine("Código válido. Procediendo con el retiro.");

                
                usuario.set_numero_cuenta(numeroCuenta);
                usuario.set_pin(pin);

                bool exito = retiro(montoIngresado, Parent, "Retiro Sin Tarjeta");


                if (exito)
                {
                    
                    MarcarCodigoComoUsado(codigoIngresado);
                    return true;
                }
                else
                {
                    mostrar_error("Hubo un error al realizar el retiro.", Parent);
                    //MessageBox.Show("Hubo un error al realizar el retiro.");
                    return false;
                }
            }
            else
            {

                //mostrar_error("Código no válido o el monto excede lo permitido.", Parent);
                return false;
            }
        }

        public bool ValidarCodigoRetiro(string codigo, double monto)
        {
            try
            {
                conector.Open();

                
                using (var cmd = new NpgsqlCommand("SELECT id_cuenta, monto_a_retirar FROM codigo_cuentas_retiro WHERE codigo = @codigo", conector.ConectorConnection))
                {
                    cmd.Parameters.AddWithValue("codigo", codigo);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idCuenta = (int)reader["id_cuenta"];
                            double montoEnCodigo = (double)reader["monto_a_retirar"];

                            
                            if (montoEnCodigo != monto)
                            {
                                //MessageBox.Show("El monto a retirar no coincide con el monto asociado al código.");
                                return false;
                            }

                            
                            Usuario usuario = GlobalState.Usuario;
                            if (usuario.get_id() == idCuenta)
                            {
                                return true;
                            }
                            else
                            {
                                //MessageBox.Show("El código de retiro no está asociado a la cuenta del usuario.");
                                return false;
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Código de retiro no válido.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el código de retiro: \n" + ex.Message);
                return false;
            }
            finally
            {
                conector.Close();
            }
        }

        public void MarcarCodigoComoUsado(string codigo)
        {
            try
            {
                conector.Open();
                using (var cmd = new NpgsqlCommand("DELETE FROM codigo_cuentas_retiro WHERE codigo = @codigo", conector.conector))
                {
                    cmd.Parameters.AddWithValue("codigo", codigo);
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Código marcado como usado o eliminado.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al marcar el código como usado: " + ex.Message);
            }
            finally
            {
                conector.Close();
            }
        }

        private void LogWithdrawal(double monto, int idCliente, String TipoRetiro, NpgsqlTransaction transaction)
        {
            try
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO registro_movimientos_atm (fecha_registro, tipo_retiro, monto_retiro, id_cliente) VALUES (@fecha_registro, @tipo_retiro, @monto_retiro, @id_cliente)", conector.ConectorConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("fecha_registro", DateTime.Now);
                    cmd.Parameters.AddWithValue("tipo_retiro", TipoRetiro); // Adjust as needed
                    cmd.Parameters.AddWithValue("monto_retiro", monto);
                    cmd.Parameters.AddWithValue("id_cliente", idCliente);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el movimiento: " + ex.Message);
                throw; // Rethrow the exception to ensure transaction rollback
            }
        }


        private Dictionary<int, int> GetBillQuantitiesFromDatabase()
        {
            var billQuantities = new Dictionary<int, int>();

            try
            {
                conector.Open();

                using (var cmd = new NpgsqlCommand("SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, saldo_total_atm FROM saldo_atm WHERE id_saldo = @id_saldo", conector.ConectorConnection))
                {
                    cmd.Parameters.AddWithValue("id_saldo", 1); // Adjust id_saldo as needed

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            billQuantities[100] = reader.GetInt32(0);
                            billQuantities[200] = reader.GetInt32(1);
                            billQuantities[500] = reader.GetInt32(2);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las cantidades de billetes: " + ex.Message);
            }
            finally
            {
                conector.Close();
            }

            return billQuantities;
        }

        private void UpdateBillQuantitiesInDatabase(Dictionary<int, int> billsToDispense, NpgsqlTransaction transaction)
        {
            var currentQuantities = new Dictionary<int, int>();
            double currentTotal = 0;

            try
            {
                // Retrieve current bill quantities and total
                using (var cmd = new NpgsqlCommand("SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, saldo_total_atm FROM saldo_atm WHERE id_saldo = @id_saldo", transaction.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("id_saldo", 1); // Adjust id_saldo as needed

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentQuantities[100] = reader.GetInt32(0);
                            currentQuantities[200] = reader.GetInt32(1);
                            currentQuantities[500] = reader.GetInt32(2);
                            currentTotal = reader.GetDouble(3);
                        }
                        else
                        {
                            // Handle case where no data is returned (optional)
                            throw new InvalidOperationException("No data found for the specified id_saldo.");
                        }
                    }
                }

                // Update quantities based on bills dispensed
                if (billsToDispense.ContainsKey(100))
                {
                    currentQuantities[100] -= billsToDispense[100];
                }
                if (billsToDispense.ContainsKey(200))
                {
                    currentQuantities[200] -= billsToDispense[200];
                }
                if (billsToDispense.ContainsKey(500))
                {
                    currentQuantities[500] -= billsToDispense[500];
                }

                // Calculate the new total in the ATM
                double newTotal = (currentQuantities[100] * 100) + (currentQuantities[200] * 200) + (currentQuantities[500] * 500);

                // Update the database with the new quantities and total
                using (var cmd = new NpgsqlCommand("UPDATE saldo_atm SET cantidad_billetes_100 = @cantidad_100, cantidad_billetes_200 = @cantidad_200, cant500_atm = @cantidad_500, saldo_total_atm = @nuevo_total WHERE id_saldo = @id_saldo", transaction.Connection, transaction))
                {
                    cmd.Parameters.AddWithValue("cantidad_100", currentQuantities.ContainsKey(100) ? currentQuantities[100] : 0);
                    cmd.Parameters.AddWithValue("cantidad_200", currentQuantities.ContainsKey(200) ? currentQuantities[200] : 0);
                    cmd.Parameters.AddWithValue("cantidad_500", currentQuantities.ContainsKey(500) ? currentQuantities[500] : 0);
                    cmd.Parameters.AddWithValue("nuevo_total", newTotal);
                    cmd.Parameters.AddWithValue("id_saldo", 1); // Adjust id_saldo as needed

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar las cantidades de billetes: " + ex.Message);
                // Optionally, you might want to roll back the transaction here if needed
                throw; // Rethrow the exception to allow for transaction rollback
            }
        }


        private void UpdateWithdrawnBillsInDatabase(Dictionary<int, int> billsToDispense, NpgsqlTransaction transaction)
        {
            var withdrawnQuantities = new Dictionary<int, int> { { 100, 0 }, { 200, 0 }, { 500, 0 } };

            try
            {
                // Retrieve existing quantities from historial_retiros_atm
                using (var cmdSelect = new NpgsqlCommand("SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, monto_total_retirado FROM historial_retiros_atm WHERE id_retiro = @id_retiro", conector.ConectorConnection))
                {
                    cmdSelect.Parameters.AddWithValue("id_retiro", 1); // Adjust id_retiro as needed
                    cmdSelect.Transaction = transaction;

                    using (var reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            withdrawnQuantities[100] = reader.GetInt32(0);
                            withdrawnQuantities[200] = reader.GetInt32(1);
                            withdrawnQuantities[500] = reader.GetInt32(2);

                            // Add new withdrawn amounts to existing ones
                            withdrawnQuantities[100] += billsToDispense.GetValueOrDefault(100, 0);
                            withdrawnQuantities[200] += billsToDispense.GetValueOrDefault(200, 0);
                            withdrawnQuantities[500] += billsToDispense.GetValueOrDefault(500, 0);

                            // Calculate the new total amount withdrawn
                            double newMontoTotalRetirado = (withdrawnQuantities[100] * 100) + (withdrawnQuantities[200] * 200) + (withdrawnQuantities[500] * 500);

                            // Make sure the reader is closed before proceeding to update
                            reader.Close();

                            // Update the withdrawn bill quantities in historial_retiros_atm
                            using (var cmdUpdate = new NpgsqlCommand("UPDATE historial_retiros_atm SET cantidad_billetes_100 = @cantidad_100_retirados, cantidad_billetes_200 = @cantidad_200_retirados, cant500_atm = @cantidad_500_retirados, monto_total_retirado = @monto_total_retirado WHERE id_retiro = @id_retiro", conector.ConectorConnection))
                            {
                                cmdUpdate.Parameters.AddWithValue("cantidad_100_retirados", withdrawnQuantities[100]);
                                cmdUpdate.Parameters.AddWithValue("cantidad_200_retirados", withdrawnQuantities[200]);
                                cmdUpdate.Parameters.AddWithValue("cantidad_500_retirados", withdrawnQuantities[500]);
                                cmdUpdate.Parameters.AddWithValue("monto_total_retirado", newMontoTotalRetirado);
                                cmdUpdate.Parameters.AddWithValue("id_retiro", 1); // Adjust id_retiro as needed
                                cmdUpdate.Transaction = transaction;

                                // Execute the update query
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los billetes dispensados: " + ex.Message);
                throw;  // Propagate the exception to trigger a rollback
            }
        }

        private string FormatDispensedBills(Dictionary<int, int> bills)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var bill in bills)
            {
                string billete = bill.Value == 1 ? "billete" : "billetes";
                sb.AppendLine($"{bill.Value} {billete} de {bill.Key} lempiras");
            }
            return sb.ToString();
        }

        public double ConsultarSaldo(string numeroCuenta)
        {
            double saldo = 0.0;

            try
            {

                conector.Open();
                using (var cmd = new NpgsqlCommand("SELECT saldo_cuenta FROM cuentas WHERE no_cuenta = @numero_cuenta", conector.ConectorConnection))
                {
                    cmd.Parameters.AddWithValue("numero_cuenta", numeroCuenta);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            saldo = reader.IsDBNull(reader.GetOrdinal("saldo_cuenta")) ? 0.0 : reader.GetDouble(reader.GetOrdinal("saldo_cuenta"));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al consultar el saldo: " + e.Message);
            }
            finally
            {
                conector.Close();
            }

            return saldo;
        }

        public string GetNumeroCuenta() { return numeroCuenta; }
        public Conector GetConector() { return conector; }
    }
}

