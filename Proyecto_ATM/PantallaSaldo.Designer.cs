namespace Proyecto_ATM
{
    partial class PantallaSaldo
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            regresar_btn = new RoundButton();
            roundButton2 = new RoundButton();
            salir_btn = new RoundButton();
            roundButton3 = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(238, 39, 55);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 902);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(204, 24, 38);
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(147, 724);
            pictureBox2.Margin = new Padding(4, 7, 4, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1133, 178);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(420, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(588, 88);
            label1.TabIndex = 2;
            label1.Text = "Su saldo actual es:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(546, 357);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 70);
            label2.TabIndex = 6;
            label2.Text = "Dinero";
            label2.Click += label2_Click;
            // 
            // regresar_btn
            // 
            regresar_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            regresar_btn.BackColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BorderColor = Color.FromArgb(204, 24, 38);
            regresar_btn.BorderRadius = 10;
            regresar_btn.BorderSize = 1;
            regresar_btn.FlatAppearance.BorderSize = 0;
            regresar_btn.FlatStyle = FlatStyle.Flat;
            regresar_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regresar_btn.ForeColor = Color.White;
            regresar_btn.Location = new Point(147, 607);
            regresar_btn.Margin = new Padding(4, 5, 4, 5);
            regresar_btn.Name = "regresar_btn";
            regresar_btn.Size = new Size(279, 85);
            regresar_btn.TabIndex = 11;
            regresar_btn.Text = "Regresar";
            regresar_btn.TextColor = Color.White;
            regresar_btn.UseVisualStyleBackColor = false;
            regresar_btn.Click += regresar_btn_Click;
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
            roundButton2.Location = new Point(147, 617);
            roundButton2.Margin = new Padding(4, 5, 4, 5);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(279, 85);
            roundButton2.TabIndex = 12;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // salir_btn
            // 
            salir_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            salir_btn.BackColor = Color.FromArgb(204, 24, 38);
            salir_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            salir_btn.BorderColor = Color.FromArgb(204, 24, 38);
            salir_btn.BorderRadius = 10;
            salir_btn.BorderSize = 1;
            salir_btn.FlatAppearance.BorderSize = 0;
            salir_btn.FlatStyle = FlatStyle.Flat;
            salir_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salir_btn.ForeColor = Color.White;
            salir_btn.Location = new Point(997, 607);
            salir_btn.Margin = new Padding(4, 5, 4, 5);
            salir_btn.Name = "salir_btn";
            salir_btn.Size = new Size(279, 85);
            salir_btn.TabIndex = 13;
            salir_btn.Text = "Salir";
            salir_btn.TextColor = Color.White;
            salir_btn.UseVisualStyleBackColor = false;
            salir_btn.Click += salir_btn_Click;
            // 
            // roundButton3
            // 
            roundButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            roundButton3.Location = new Point(997, 617);
            roundButton3.Margin = new Padding(4, 5, 4, 5);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(279, 85);
            roundButton3.TabIndex = 14;
            roundButton3.TextColor = Color.White;
            roundButton3.UseVisualStyleBackColor = false;
            // 
            // PantallaSaldo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salir_btn);
            Controls.Add(roundButton3);
            Controls.Add(regresar_btn);
            Controls.Add(roundButton2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PantallaSaldo";
            Size = new Size(1280, 902);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private RoundButton regresar_btn;
        private RoundButton roundButton2;
        private RoundButton salir_btn;
        private RoundButton roundButton3;
        static public Label label2;
    }
}
