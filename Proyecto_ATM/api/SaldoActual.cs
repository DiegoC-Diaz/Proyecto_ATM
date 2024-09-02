﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    public class SaldoActual
    {
        private readonly Conector conector;
        public int cant100 { get; private set; }
        public int cant200 { get; private set; }
        public int cant500 { get; private set; }
        public double saldoTotal { get; private set; }

        public SaldoActual()
        {
            conector = new Conector();
            LoadData();
        }


        public void LoadData()
        {
            try
            {
                conector.Open();
                string query = "SELECT cantidad_billetes_100, cantidad_billetes_200, cant500_atm, saldo_total_atm FROM saldo_atm WHERE id_saldo = 1"; // Adjust query as needed

                using (var cmd = new NpgsqlCommand(query, conector.ConectorConnection))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cant100 = (int)reader["cantidad_billetes_100"];
                        cant200 = (int)reader["cantidad_billetes_200"];
                        cant500 = (int)reader["cant500_atm"];
                        saldoTotal = (double)reader["saldo_total_atm"];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                conector.Close();
            }
        }
    }
}


