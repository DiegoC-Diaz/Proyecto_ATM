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
    public partial class PantallaSaldo : UserControl
    {
        public PantallaSaldo()
        {
            InitializeComponent();
        }

        public event EventHandler cambiarEspera;

        private void pictureBox4_Click(object sender, EventArgs e)
        {


        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {
            if (this.cambiarEspera != null)
            {
                this.cambiarEspera(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            if (this.cambiarEspera != null)
            {
                this.cambiarEspera(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
