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
    public partial class ModalRetiro : Form
    {
        EventHandler cerrar_form;
        int cant_billetes_500;
        int cant_billetes_200;
        int cant_billetes_100;
        public ModalRetiro(int cant_billetes_100, int cant_billetes_200,int cant_billetes_500)
        {
            InitializeComponent();
            this.cant_billetes_100 = cant_billetes_100;
            this.cant_billetes_200 = cant_billetes_200;
            this.cant_billetes_500 = cant_billetes_500;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        public void set_cantidades(int cant_billetes_500, int cant_billetes_200, int cant_billetes_100)
        {


            this.cant_billetes_100 = cant_billetes_100;
            this.cant_billetes_200 = cant_billetes_200;
            this.cant_billetes_500 = cant_billetes_500;


        }

        private void ModalRetiro_Load(object sender, EventArgs e)
        {

            cantidad_billetes_500.Text = cant_billetes_500+"";
            cantidad_billetes_100.Text = cant_billetes_100+"";
            cantidad_billetes_200.Text = cant_billetes_200 + "";
            total_billetes_500.Text = "L."+(cant_billetes_500 * 500);
            total_billetes_100.Text = "L." + (cant_billetes_100 * 100);
            total_billetes_200.Text = "L." + (cant_billetes_200 * 200);



        }
    }
}
