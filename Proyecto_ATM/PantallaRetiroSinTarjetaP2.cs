﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_ATM.api;

namespace Proyecto_ATM
{
    public partial class PantallaRetiroSinTarjetaP2 : UserControl
    {

        Movimiento movi;
        string codigo = "";
        public event EventHandler retiroSinTarjetaExitoso;
        public event EventHandler AcctorPinIncorrect;
        public event EventHandler retiroSinTarjetaRegresar;

        private Conector conector;
        private PopUps popUp;


        public PantallaRetiroSinTarjetaP2()
        {
            InitializeComponent();
            conector = new Conector();

        }

        private void ingresar_btn_Click(object sender, EventArgs e)
        {
            codigo = PantallaRetiroSinTarjetaP1.codigo;
            double monto = int.Parse(textBox1.Text);
            

            if (GlobalState.Usuario == null)
            {
                mostrar_error("Codigo o Monto erróneos.");
                
                return;
            }

            Usuario usuario = GlobalState.Usuario;

            Movimiento movimiento = new Movimiento(usuario.get_numero_cuenta(), usuario.get_pin(), conector);

            bool exito = movimiento.ProcesarRetiroConCodigo(codigo, monto, this.FindForm());

            if (exito)
            {
                if (retiroSinTarjetaExitoso != null)
                {
                    retiroSinTarjetaExitoso(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("NO FUNCA.");
                }
            }
            else
            {
                AcctorPinIncorrect?.Invoke(this, EventArgs.Empty);
                mostrar_error("Codigo o Monto erróneos.");
                
            }
        }
        private void mostrar_error(string mensaje)
        {
            popUp = new PopUps();
            Console.WriteLine(mensaje);
            popUp.mostrar_error(mensaje, this.FindForm());
            textBox1.Clear();
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            if (this.retiroSinTarjetaRegresar != null)
            {
                textBox1.Clear();
                this.retiroSinTarjetaRegresar(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel pantalla de retiro sin tarjeta p2 ->retiro sin tarjeta p2\n");
            }
        }
    }
}
