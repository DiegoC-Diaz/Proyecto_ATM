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
using Proyecto_ATM.api;

// Pantalla de Seleccion de Dinero
namespace Proyecto_ATM
{
    public partial class PantallaRetiroNormalP1 : UserControl
    {

        private Conector conector;
        public event EventHandler retiroExitoso;
        private PopUps popUp;
        public PantallaRetiroNormalP1()
        {
            InitializeComponent();

            conector = new Conector();
        }

        public event EventHandler EventoRegresar;
        public event EventHandler EventoMonto;
        public event EventHandler EventoMontoPersonalizado;



        private void roundButton5_Click(object sender, EventArgs e) // BotonRegresar 
        {

            if (this.EventoRegresar != null)
            {
                this.EventoRegresar(this, e);
            }

        }

        private void L100_Click(object sender, EventArgs e)
        {
            double monto = 100;

            retirarCantidad(monto);
        }

        private void L200_Click(object sender, EventArgs e)
        {
            double monto = 200;

            retirarCantidad(monto);
        }

        private void L500_Click(object sender, EventArgs e)
        {
            double monto = 500;

            retirarCantidad(monto);
        }

        private void L1000_Click(object sender, EventArgs e)
        {
            double monto = 1000;

            retirarCantidad(monto);
        }

        private void L2000_Click(object sender, EventArgs e)
        {
            double monto = 2000;

            retirarCantidad(monto);
        }

        private void L3000_Click(object sender, EventArgs e)
        {
            double monto = 3000;

            retirarCantidad(monto);
        }

        private void L4000_Click(object sender, EventArgs e)
        {
            double monto = 4000;

            retirarCantidad(monto);
        }

        private void L5000_Click(object sender, EventArgs e)
        {
            double monto = 5000;

            retirarCantidad(monto);
        }

        private void MontoPersonalizado_Click(object sender, EventArgs e)
        {
            if (this.EventoMontoPersonalizado != null)
            {
                this.EventoMontoPersonalizado(this, e);
            }
        }

        private void retirarCantidad(double monto)
        {
            Usuario usuario = GlobalState.Usuario;

            Movimiento movimiento = new Movimiento(usuario.get_numero_cuenta(), usuario.get_pin(), conector);

            bool exito = movimiento.retiro(monto,this.FindForm(), "Retiro");//aqui

            if (exito)
            {
                if (retiroExitoso != null)
                {
                    retiroExitoso(this, EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Error al cambiar de pantalla");
                }
            }
            else
            {
                mostrar_error("Saldo insuficiente para realizar retiro.");
            }
        }

        private void mostrar_error(string mensaje)
        {
            popUp = new PopUps();
            Console.WriteLine(mensaje);
            popUp.mostrar_error(mensaje, this.FindForm());            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
