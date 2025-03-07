namespace Proyecto_ATM
{
    partial class PantallaMenuConsulta
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
            RetiroBtn = new PictureBox();
            ConsultaBtn = new PictureBox();
            RegresarBtn = new RoundButton();
            roundButton3 = new RoundButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)RetiroBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConsultaBtn).BeginInit();
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
            SalirBtn.TabIndex = 9;
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
            roundButton2.TabIndex = 10;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // RetiroBtn
            // 
            RetiroBtn.Anchor = AnchorStyles.None;
            RetiroBtn.Image = Properties.Resources.Retiro;
            RetiroBtn.Location = new Point(553, 177);
            RetiroBtn.Name = "RetiroBtn";
            RetiroBtn.Size = new Size(400, 400);
            RetiroBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            RetiroBtn.TabIndex = 8;
            RetiroBtn.TabStop = false;
            RetiroBtn.Click += RetiroBtn_Click;
            // 
            // ConsultaBtn
            // 
            ConsultaBtn.Anchor = AnchorStyles.None;
            ConsultaBtn.Image = Properties.Resources.consulta;
            ConsultaBtn.Location = new Point(71, 177);
            ConsultaBtn.Name = "ConsultaBtn";
            ConsultaBtn.Size = new Size(400, 400);
            ConsultaBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ConsultaBtn.TabIndex = 7;
            ConsultaBtn.TabStop = false;
            ConsultaBtn.Click += ConsultaBtn_Click;
            // 
            // RegresarBtn
            // 
            RegresarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RegresarBtn.BackColor = Color.FromArgb(204, 24, 38);
            RegresarBtn.BackgroundColor = Color.FromArgb(204, 24, 38);
            RegresarBtn.BorderColor = Color.FromArgb(204, 24, 38);
            RegresarBtn.BorderRadius = 10;
            RegresarBtn.BorderSize = 1;
            RegresarBtn.FlatAppearance.BorderSize = 0;
            RegresarBtn.FlatStyle = FlatStyle.Flat;
            RegresarBtn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegresarBtn.ForeColor = Color.White;
            RegresarBtn.Location = new Point(-3, 664);
            RegresarBtn.Name = "RegresarBtn";
            RegresarBtn.Size = new Size(223, 68);
            RegresarBtn.TabIndex = 11;
            RegresarBtn.Text = "Regresar";
            RegresarBtn.TextColor = Color.White;
            RegresarBtn.UseVisualStyleBackColor = false;
            RegresarBtn.Click += RegresarBtn_Click;
            // 
            // roundButton3
            // 
            roundButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            roundButton3.BackColor = Color.FromArgb(143, 14, 24);
            roundButton3.BackgroundColor = Color.FromArgb(143, 14, 24);
            roundButton3.BorderColor = Color.PaleVioletRed;
            roundButton3.BorderRadius = 10;
            roundButton3.BorderSize = 0;
            roundButton3.Enabled = false;
            roundButton3.FlatAppearance.BorderSize = 0;
            roundButton3.FlatStyle = FlatStyle.Flat;
            roundButton3.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundButton3.ForeColor = Color.White;
            roundButton3.Location = new Point(-3, 677);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(223, 68);
            roundButton3.TabIndex = 12;
            roundButton3.TextColor = Color.White;
            roundButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 45);
            label1.Name = "label1";
            label1.Size = new Size(536, 73);
            label1.TabIndex = 13;
            label1.Text = "¡Bienvenido al ATM!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PantallaMenuConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 39, 55);
            Controls.Add(label1);
            Controls.Add(RegresarBtn);
            Controls.Add(roundButton3);
            Controls.Add(SalirBtn);
            Controls.Add(roundButton2);
            Controls.Add(RetiroBtn);
            Controls.Add(ConsultaBtn);
            Name = "PantallaMenuConsulta";
            Size = new Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)RetiroBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConsultaBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundButton SalirBtn;
        private RoundButton roundButton2;
        private PictureBox RetiroBtn;
        private PictureBox ConsultaBtn;
        private RoundButton RegresarBtn;
        private RoundButton roundButton3;
        private Label label1;
    }
}
