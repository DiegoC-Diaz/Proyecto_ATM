﻿using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool retiro(double monto, Form Parent, String TipoRetiro)
        {
            double saldo = ConsultarSaldo(numeroCuenta);

            if (saldo < monto)
            {
                // MessageBox.Show("No hay suficiente saldo en la cuenta.");
                return false;
            }

            // Initialize bill quantities
            Dictionary<int, int> billQuantities = GetBillQuantitiesFromDatabase();

            // Dictionary to hold the bills to be dispensed
            Dictionary<int, int> billsToDispense = new Dictionary<int, int>();
            int remainingAmount = (int)monto;

            // Bill dispensing logic
            if (remainingAmount % 100 != 0)
            {
                // mostrar_error("El monto debe ser múltiplo de 100.", Parent);
                return false;
            }

            foreach (var denomination in billQuantities.Keys.OrderByDescending(d => d))
            {
                int billsNeeded = remainingAmount / denomination;
                int billsAvailable = billQuantities[denomination];

                if (billsNeeded > 0)
                {
                    if (billsNeeded <= billsAvailable)
                    {
                        // Use as many as available
                        billsToDispense[denomination] = billsNeeded;
                        remainingAmount -= billsNeeded * denomination;
                        billQuantities[denomination] -= billsNeeded;
                    }
                    else
                    {
                        // Use all available bills
                        billsToDispense[denomination] = billsAvailable;
                        remainingAmount -= billsAvailable * denomination;
                        billQuantities[denomination] = 0;
                    }
                }

                if (remainingAmount == 0)
                {
                    break;
                }
            }

            if (remainingAmount > 0)
            {
                mostrar_error("No se puede dispensar la cantidad solicitada.", Parent);
                // MessageBox.Show();
                return false;
            }

            // Update the account balance and bill quantities in the database
            try
            {
                conector.Open();

                // Update the account balance
                using (var cmd = new NpgsqlCommand("UPDATE cuentas SET saldo_cuenta = @saldo_restante WHERE no_cuenta = @numero_cuenta", conector.ConectorConnection))
                {
                    double saldoRestante = saldo - monto;

                    cmd.Parameters.AddWithValue("saldo_restante", saldoRestante);
                    cmd.Parameters.AddWithValue("numero_cuenta", numeroCuenta);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                // Update the bills in the saldo_atm table
                UpdateBillQuantitiesInDatabase(billsToDispense);

                // Update the withdrawn bills in historial_retiros_atm
                UpdateWithdrawnBillsInDatabase(billsToDispense);

                // Log the withdrawal in registro_movimientos_atm
                LogWithdrawal(monto, GlobalState.Usuario.get_id(), TipoRetiro); // Adjust as needed

                // Inform the user of the successful withdrawal and display the dispensed bills
                // mostrar_error("Retiro exitoso. Se han dispensado los siguientes billetes:", Parent);
                // mostrar_error(FormatDispensedBills(billsToDispense), Parent);
                // MessageBox.Show("Retiro exitoso. Se han dispensado los siguientes billetes:\n" + FormatDispensedBills(billsToDispense));
            }
            catch (Exception e)
            {
                mostrar_error("Error al realizar el retiro", Parent);
                // MessageBox.Show("Error al realizar el retiro: " + e.Message);
                return false;
            }
            finally
            {
                conector.Close();
            }

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

        private void LogWithdrawal(double monto, int idCliente, String TipoRetiro)
        {
            try
            {
                conector.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO registro_movimientos_atm (fecha_registro, tipo_retiro, monto_retiro, id_cliente) VALUES (@fecha_registro, @tipo_retiro, @monto_retiro, @id_cliente)", conector.ConectorConnection))
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
            }
            finally
            {
                conector.Close();
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

        private void UpdateBillQuantitiesInDatabase(Dictionary<int, int> billsToDispense)
        {
            var currentQuantities = new Dictionary<int, int>();
            double currentTotal = 0;

            try
            {
                conector.Open();

                // Retrieve current bill quantities and total
                using (var cmd = new NpgsqlCommand("SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, saldo_total_atm FROM saldo_atm WHERE id_saldo = @id_saldo", conector.ConectorConnection))
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
                using (var cmd = new NpgsqlCommand("UPDATE saldo_atm SET cantidad_billetes_100 = @cantidad_100, cantidad_billetes_200 = @cantidad_200, cant500_atm = @cantidad_500, saldo_total_atm = @nuevo_total WHERE id_saldo = @id_saldo", conector.ConectorConnection))
                {
                    cmd.Parameters.AddWithValue("cantidad_100", currentQuantities[100]);
                    cmd.Parameters.AddWithValue("cantidad_200", currentQuantities[200]);
                    cmd.Parameters.AddWithValue("cantidad_500", currentQuantities[500]);
                    cmd.Parameters.AddWithValue("nuevo_total", newTotal);
                    cmd.Parameters.AddWithValue("id_saldo", 1); // Adjust id_saldo as needed

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar las cantidades de billetes: " + ex.Message);
            }
            finally
            {
                conector.Close();
            }
        }

        private void UpdateWithdrawnBillsInDatabase(Dictionary<int, int> billsToDispense)
        {
            var withdrawnQuantities = new Dictionary<int, int> { { 100, 0 }, { 200, 0 }, { 500, 0 } };

            try
            {
                conector.Open();

                // Retrieve existing quantities from historial_retiros_atm
                using (var cmdSelect = new NpgsqlCommand("SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, monto_total_retirado FROM historial_retiros_atm WHERE id_retiro = @id_retiro", conector.ConectorConnection))
                {
                    cmdSelect.Parameters.AddWithValue("id_retiro", 1); // Adjust id_retiro as needed

                    using (var reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            withdrawnQuantities[100] = reader.GetInt32(0);
                            withdrawnQuantities[200] = reader.GetInt32(1);
                            withdrawnQuantities[500] = reader.GetInt32(2);
                            double previousMontoTotalRetirado = reader.GetDouble(3);

                            // Add new withdrawn amounts to existing ones
                            withdrawnQuantities[100] += billsToDispense.GetValueOrDefault(100, 0);
                            withdrawnQuantities[200] += billsToDispense.GetValueOrDefault(200, 0);
                            withdrawnQuantities[500] += billsToDispense.GetValueOrDefault(500, 0);

                            // Calculate the new total amount withdrawn
                            double newMontoTotalRetirado = (withdrawnQuantities[100] * 100) + (withdrawnQuantities[200] * 200) + (withdrawnQuantities[500] * 500);

                            // Update the withdrawn bill quantities in historial_retiros_atm
                            using (var cmdUpdate = new NpgsqlCommand("UPDATE historial_retiros_atm SET cantidad_billetes_100 = @cantidad_100_retirados, cantidad_billetes_200 = @cantidad_200_retirados, cant500_atm = @cantidad_500_retirados, monto_total_retirado = @monto_total_retirado WHERE id_retiro = @id_retiro", conector.ConectorConnection))
                            {
                                cmdUpdate.Parameters.AddWithValue("cantidad_100_retirados", withdrawnQuantities[100]);
                                cmdUpdate.Parameters.AddWithValue("cantidad_200_retirados", withdrawnQuantities[200]);
                                cmdUpdate.Parameters.AddWithValue("cantidad_500_retirados", withdrawnQuantities[500]);
                                cmdUpdate.Parameters.AddWithValue("monto_total_retirado", newMontoTotalRetirado);
                                cmdUpdate.Parameters.AddWithValue("id_retiro", 1); // Adjust id_retiro as needed

                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los billetes dispensados: " + ex.Message);
            }
            finally
            {
                conector.Close();
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

