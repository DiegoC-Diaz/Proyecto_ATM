using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using System;

namespace Proyecto_ATM.api
{
    public class Usuario
    {
        private Conector conector;
        public int id;
        public string numero_cuenta;
        public string pin;
        public string rol;

        public Usuario(int id, string numero_cuenta, string pin, string rol)
        {
            this.id = id;
            this.pin = pin;
            this.numero_cuenta = numero_cuenta;
            this.rol = rol;
        }

        public Usuario()
        {
            id = 0;
            pin = "";
            numero_cuenta = "";
            rol = "";
        }

        public string get_numero_cuenta() { return numero_cuenta; }
        public string get_pin() { return pin; }
        public string get_rol() { return rol; }

        public void set_numero_cuenta(string numero_cuenta) { this.numero_cuenta = numero_cuenta; }
        public void set_pin(string pin) { this.pin = pin; }
        public void set_rol(string rol) { this.rol = rol; }
        public int get_id() { return id; }

        public bool validar_usuario(Conector conector, string pinInput)
        {
            bool valido = false;

            try
            {
                conector.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_cuenta, pin_cuenta, rol_cuenta FROM cuentas WHERE no_cuenta = @numero_cuenta", conector.conector))
                {
                    cmd.Parameters.AddWithValue("numero_cuenta", numero_cuenta);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = (int)reader["id_cuenta"];
                        pin = (string)reader["pin_cuenta"];
                        rol = (string)reader["rol_cuenta"];

                        if (pinInput == pin)
                        {
                            valido = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar usuario: " + ex.Message);
            }
            finally
            {
                conector.Close();
            }

            return valido;
        }

        public bool ObtenerCuentaDesdeCodigo(string codigo, Conector conector)
        {
            bool valido = false;

            try
            {
                conector.Open();
                using (var cmd = new NpgsqlCommand("SELECT c.id_cuenta, c.no_cuenta, c.pin_cuenta, c.rol_cuenta, r.monto_a_retirar FROM cuentas c INNER JOIN codigo_cuentas_retiro r ON c.id_cuenta = r.id_cuenta WHERE r.codigo = @codigo", conector.conector))
                {
                    cmd.Parameters.AddWithValue("codigo", codigo);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = (int)reader["id_cuenta"];
                        numero_cuenta = (string)reader["no_cuenta"];
                        pin = (string)reader["pin_cuenta"];
                        rol = (string)reader["rol_cuenta"];
                        valido = true;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener cuenta desde código: " + ex.Message);
            }
            finally
            {
                conector.Close();
            }

            return valido;
        }
    }
}
