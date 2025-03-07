using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Timer;

namespace Proyecto_ATM
{
    public partial class PantallaDespedida : UserControl
    {
        private System.Windows.Forms.Timer Relojito;
        public event EventHandler despedidaTimeUp;
        private string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName;
        private string imageFolderPath;
        private string[] imageFiles;
        public PantallaDespedida()
        {
            InitializeComponent();
            InitializeTimer();

            imageFolderPath = Path.Combine(projectDirectory, "Pantalla de Despedida");
        }
        private void PantallaDespedida_Load(object sender, EventArgs e)
        {
            //Agarrar el arreglo de las imagenes para solo agarrarse la primera
           imageFiles = Directory.GetFiles(imageFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                  .Where(file => file.ToLower().EndsWith("jpg") ||
                                                 file.ToLower().EndsWith("png") ||
                                                 file.ToLower().EndsWith("bmp") ||
                                                 file.ToLower().EndsWith("jpeg"))
                                  .OrderBy(file => file)
                                  .ToArray();

            //Solo agarra la primera imagen que detecta en orden alfabetico
            pictureBox1.Image = Image.FromFile(imageFiles[0]);

            Relojito.Start();
        }

        private void InitializeTimer()
        {
            Relojito = new System.Windows.Forms.Timer();
            Relojito.Interval = 10000;
            Relojito.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Relojito.Stop();
            despedidaTimeUp?.Invoke(this, EventArgs.Empty);

            if (despedidaTimeUp != null)
            {
                despedidaTimeUp(this, EventArgs.Empty);

            }
            else
            {
                Console.WriteLine("Error al cambiar de pantalla");
            }
        }

        public void StartTimer()
        {
            Relojito.Start();
        }

        public void StopTimer()
        {
            Relojito.Stop();
        }

    }
}
