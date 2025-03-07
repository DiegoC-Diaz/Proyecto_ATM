using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.Timer;

namespace Proyecto_ATM
{
    public partial class PantallaTomeSuDinero : UserControl
    {
        private System.Windows.Forms.Timer timer;
        public event EventHandler timerDinero;
        public PantallaTomeSuDinero()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaTomeSuDinero_Load(object sender, EventArgs e)
        {
            timer.Start(); 
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000; 
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            timerDinero?.Invoke(this, EventArgs.Empty);

            if (timerDinero != null)
            {
                timerDinero(this, EventArgs.Empty);

            }
            else
            {
                Console.WriteLine("Error al cambiar de pantalla");
            }
        }

        public void StartTimer()
        {
            timer.Start(); 
        }

        public void StopTimer()
        {
            timer.Stop(); 
        }

    }
}
