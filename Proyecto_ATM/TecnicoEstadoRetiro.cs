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
    public partial class TecnicoEstadoRetiro : UserControl
    {
        public TecnicoEstadoRetiro()
        {
            InitializeComponent();
            

        }

        private SaldoActual montoRetirado = new SaldoActual();
        public event EventHandler regresarDePantallaEstadoRetiro;

        public void LoadInfo()
        {
            montoRetirado.LoadWithdrawalData();
            this.Valor100.Text = montoRetirado.cant100Retirados.ToString();
            this.Valor200.Text = montoRetirado.cant200Retirados.ToString();
            this.Valor500.Text = montoRetirado.cant500Retirados.ToString();
            this.ValorTotal.Text = montoRetirado.saldoTotalRetirado.ToString() + " Lempiras";
            //this.Total100.Text = (montoRetirado.cant100Retirados * 100).ToString();
            //this.Total200.Text = (montoRetirado.cant200Retirados * 200).ToString();
            //this.Total500.Text = (montoRetirado.cant500Retirados * 500).ToString();

        }

        private void TecnicoEstadoRetiro_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {
            if (this.regresarDePantallaEstadoRetiro != null)
            {
                this.regresarDePantallaEstadoRetiro(this, e);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
