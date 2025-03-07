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
    public partial class PantallaMenuAgente : UserControl
    {
        public PantallaMenuAgente()
        {
            InitializeComponent();
        }

        public event EventHandler salirMenuAgente;
        private void SalirBtn_Click(object sender, EventArgs e)
        {
            if (this.salirMenuAgente != null)
            {
                this.salirMenuAgente(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Agente Bancario -> Bienvenida\n");
            }

        }
    }
}
