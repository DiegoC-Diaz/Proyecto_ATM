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
    public partial class PantallaMenuConsulta : UserControl
    {
        public PantallaMenuConsulta()
        {
            InitializeComponent();
        }
        public event EventHandler salirMenuConsulta;
        public event EventHandler regresarMenuConsulta;
        public event EventHandler redConsulta_MenuConsulta;
        public event EventHandler redRetiroP1_MenuConsulta;

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            if (this.salirMenuConsulta != null)
            {
                this.salirMenuConsulta(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de consulta -> Bienvenida\n");
            }
        }

        private void RegresarBtn_Click(object sender, EventArgs e)
        {
            if (this.regresarMenuConsulta != null)
            {
                this.regresarMenuConsulta(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de consulta -> menu de retiro/menu de opciones\n");
            }
        }

        private void ConsultaBtn_Click(object sender, EventArgs e)
        {
            if (this.redConsulta_MenuConsulta != null)
            {
                this.redConsulta_MenuConsulta(this, e);
         
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de consulta -> consulta\n");
            }
        }

        private void RetiroBtn_Click(object sender, EventArgs e)
        {
            if (this.redRetiroP1_MenuConsulta != null)
            {
                this.redRetiroP1_MenuConsulta(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de consulta -> RetiroP1\n");
            }
        }
    }
}
