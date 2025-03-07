using Proyecto_ATM.api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ATM
{
    public partial class PantallaMovimientosTecnico : UserControl
    {
        public PantallaMovimientosTecnico()
        {
            InitializeComponent();

        }
        private Tecnico tecnico;
        public EventHandler regresar;
        public EventHandler Historialbilletes;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regresar_btn_Click(object sender, EventArgs e)
        {
            if (this.regresar != null)
            {
                this.regresar(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Tecnico -> Bienvenida\n");
            }
        }

        private void mas_btn_click(object sender, EventArgs e)
        {
            if (this.Historialbilletes != null)
            {
                this.Historialbilletes(this, e);
            }
            else
            {
                Console.WriteLine("Error al cambiar panel Menu de Tecnico -> Bienvenida\n");
            }
        }

        private void PantallaMovimientosTecnico_Load(object sender, EventArgs e)
        {
     

        }

        private void PantallaMovimientosTecnico_Validating(object sender, CancelEventArgs e)
        {

        }

        private void PantallaMovimientosTecnico_VisibleChanged(object sender, EventArgs e)
        {




        }

        public void refrescar(object sender, EventArgs e)
        {
            tecnico = new Tecnico();

            tecnico.obtener_movimientos();
            panel3.Hide();
            ClearTableLayoutPanel(tablaMovimientos);

            List<MovimientoModel> movimientos = tecnico.movimientos;

            decimal monto = 0;

            for (int i = 0; i < movimientos.Count; i++)
            {
                monto = decimal.Parse(movimientos[i].monto);

                tablaMovimientos.RowCount = tablaMovimientos.RowCount + 1;
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].fecha, AutoSize = true }, 0, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].hora, AutoSize = true }, 1, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].nombre + "", AutoSize = true }, 2, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = movimientos[i].tipo_retiro, AutoSize = true }, 3, tablaMovimientos.RowCount - 1);
                tablaMovimientos.Controls.Add(new Label() { Text = "L. " + monto.ToString("N0", CultureInfo.InvariantCulture), AutoSize = true }, 4, tablaMovimientos.RowCount - 1);
                tablaMovimientos.RowStyles.Add(new System.Windows.Forms.RowStyle(SizeType.AutoSize, 30));
                tablaMovimientos.Size = new System.Drawing.Size(tablaMovimientos.Width, tablaMovimientos.Height + 28);

            }
            panel3.Show();
           
        }
        private void ClearTableLayoutPanel(TableLayoutPanel tableLayoutPanel)
        {
            // Check if the tableLayoutPanel is not null
           
            if (tableLayoutPanel == null)
            {
                throw new ArgumentNullException(nameof(tableLayoutPanel));
            }

            // Iterate through the controls in reverse order to avoid issues with collection modification
            foreach (Control control in tableLayoutPanel.Controls.Cast<Control>().ToList())
            {
                // Remove the control from the TableLayoutPanel
                tableLayoutPanel.Controls.Remove(control);

                // Dispose of the control to free resources
                control.Dispose();
            }

            // Optionally, reset RowCount and ColumnCount if you want to completely clear the TableLayoutPanel
            tableLayoutPanel.RowCount = 0;
            tableLayoutPanel.ColumnCount = 0;

            // Optionally, clear any row styles if needed
            tableLayoutPanel.RowStyles.Clear();
            //tableLayoutPanel.ColumnStyles.Clear();
        }

    }

}
