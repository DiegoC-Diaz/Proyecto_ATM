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
    public partial class PantallaMenuTecnico : UserControl
    {
        public PantallaMenuTecnico()
        {
            InitializeComponent();
        }

        public event EventHandler salirMenuTecnico;
        public event EventHandler redMovimientos_MenuTecnico;
        public event EventHandler redEstadoAct_MenuTecnico;

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            if (this.salirMenuTecnico != null)
            {
                this.salirMenuTecnico(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Tecnico -> Bienvenida\n");
            }
        }

        private void MovimientosBtn_Click(object sender, EventArgs e)
        {
            if (this.redMovimientos_MenuTecnico != null)
            {
                this.redMovimientos_MenuTecnico(this, e);
            }

            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Tecnico -> Movimientos\n");
            }
        }

        private void EstadoActBtn_Click(object sender, EventArgs e)
        {
            if (this.redEstadoAct_MenuTecnico != null)
            {
                this.redEstadoAct_MenuTecnico(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Tecnico -> Estado actual\n");
            }
        }
    }
}
