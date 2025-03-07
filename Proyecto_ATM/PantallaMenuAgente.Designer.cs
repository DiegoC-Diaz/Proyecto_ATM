namespace Proyecto_ATM
{
    partial class PantallaMenuAgente
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SalirBtn = new RoundButton();
            roundButton2 = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.mantainance;
            pictureBox1.Location = new Point(362, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 69);
            label1.Name = "label1";
            label1.Size = new Size(731, 73);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido Agente Bancario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            SalirBtn.TabIndex = 15;
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
            roundButton2.TabIndex = 16;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // PantallaMenuAgente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 39, 55);
            Controls.Add(SalirBtn);
            Controls.Add(roundButton2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PantallaMenuAgente";
            Size = new Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private RoundButton SalirBtn;
        private RoundButton roundButton2;
    }
}
