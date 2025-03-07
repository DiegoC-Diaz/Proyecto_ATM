namespace Proyecto_ATM
{
    partial class PantallaMenuTecnico
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SalirBtn = new RoundButton();
            roundButton2 = new RoundButton();
            EstadoActBtn = new PictureBox();
            MovimientosBtn = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)EstadoActBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovimientosBtn).BeginInit();
            SuspendLayout();
            // 
            // SalirBtn
            // 
            SalirBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SalirBtn.BackColor = Color.FromArgb(204, 24, 38);
            SalirBtn.BackgroundColor = Color.FromArgb(204, 24, 38);
            SalirBtn.BorderColor = Color.FromArgb(204, 24, 38);
            SalirBtn.BorderRadius = 10;
            SalirBtn.BorderSize = 1;
            SalirBtn.FlatAppearance.BorderSize = 0;
            SalirBtn.FlatStyle = FlatStyle.Flat;
            SalirBtn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalirBtn.ForeColor = Color.White;
            SalirBtn.Location = new Point(805, 664);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(223, 68);
            SalirBtn.TabIndex = 13;
            SalirBtn.Text = "Salir";
            SalirBtn.TextColor = Color.White;
            SalirBtn.UseVisualStyleBackColor = false;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // roundButton2
            // 
            roundButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            roundButton2.BackColor = Color.FromArgb(143, 14, 24);
            roundButton2.BackgroundColor = Color.FromArgb(143, 14, 24);
            roundButton2.BorderColor = Color.PaleVioletRed;
            roundButton2.BorderRadius = 10;
            roundButton2.BorderSize = 0;
            roundButton2.Enabled = false;
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(805, 677);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(223, 68);
            roundButton2.TabIndex = 14;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // EstadoActBtn
            // 
            EstadoActBtn.Anchor = AnchorStyles.None;
            EstadoActBtn.Image = Properties.Resources.estado_actual;
            EstadoActBtn.Location = new Point(553, 177);
            EstadoActBtn.Name = "EstadoActBtn";
            EstadoActBtn.Size = new Size(400, 400);
            EstadoActBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            EstadoActBtn.TabIndex = 12;
            EstadoActBtn.TabStop = false;
            EstadoActBtn.Click += EstadoActBtn_Click;
            // 
            // MovimientosBtn
            // 
            MovimientosBtn.Anchor = AnchorStyles.None;
            MovimientosBtn.Image = Properties.Resources.movimientos;
            MovimientosBtn.Location = new Point(71, 177);
            MovimientosBtn.Name = "MovimientosBtn";
            MovimientosBtn.Size = new Size(400, 400);
            MovimientosBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            MovimientosBtn.TabIndex = 11;
            MovimientosBtn.TabStop = false;
            MovimientosBtn.Click += MovimientosBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 45);
            label1.Name = "label1";
            label1.Size = new Size(741, 73);
            label1.TabIndex = 15;
            label1.Text = "Bienvenido Tecnico Bancario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PantallaMenuTecnico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 39, 55);
            Controls.Add(label1);
            Controls.Add(SalirBtn);
            Controls.Add(roundButton2);
            Controls.Add(EstadoActBtn);
            Controls.Add(MovimientosBtn);
            Name = "PantallaMenuTecnico";
            Size = new Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)EstadoActBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovimientosBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton SalirBtn;
        private RoundButton roundButton2;
        private PictureBox EstadoActBtn;
        private PictureBox MovimientosBtn;
        private Label label1;
    }
}
