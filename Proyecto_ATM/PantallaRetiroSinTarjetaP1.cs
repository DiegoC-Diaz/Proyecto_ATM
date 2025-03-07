using Proyecto_ATM.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ATM
{
    public partial class PantallaRetiroSinTarjetaP1 : UserControl
    {
        public event EventHandler EventoRegresar1;
        public static string codigo = "";
        private Conector conector;
        public PantallaRetiroSinTarjetaP1()
        {
            InitializeComponent();
            conector = new Conector();
        }

        public event EventHandler cambioPt2;
        public event EventHandler cambioMenuRetiro;


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            if (this.EventoRegresar1 != null)
            {
                this.EventoRegresar1(this, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            codigo = textBox1.Text;

            Usuario usuario = new Usuario();
            if (usuario.ObtenerCuentaDesdeCodigo(codigo, conector))
            {
                GlobalState.Usuario = usuario;
            }
            else
            {
                //MessageBox.Show("Código no válido.");
            }

            if (this.cambioPt2 != null)
            {

                this.cambioPt2(this, e);
            }
            else
            {
                Console.WriteLine("Error");
            }

            textBox1.Text = "";
            textBox1.Refresh();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (this.cambioMenuRetiro != null)
            {
                textBox1.Clear();
                this.cambioMenuRetiro(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }

            textBox1.Text = "";
            textBox1.Refresh();
        }

        private void PantallaRetiroSinTarjetaP1_VisibleChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Refresh();
        }
    }
}
