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
                MessageBox.Show("Error: Usuario no ha sido inicializado.");
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
                mostrar_error("Monto incorrecto.");
            }
        }
        private void mostrar_error(string mensaje)
        {
            popUp = new PopUps();
            Console.WriteLine(mensaje);
            popUp.mostrar_error(mensaje, this.FindForm());
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
