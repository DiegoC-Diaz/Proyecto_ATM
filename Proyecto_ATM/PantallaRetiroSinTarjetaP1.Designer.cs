﻿namespace Proyecto_ATM
{
    partial class PantallaRetiroSinTarjetaP1
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
            textBox1 = new TextBox();
            label1 = new Label();
            RegresarBtn = new RoundButton();
            roundButton3 = new RoundButton();
            ingresar_btn = new RoundButton();
            roundButton2 = new RoundButton();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(259, 327);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(497, 61);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(192, 176);
            label1.Name = "label1";
            label1.Size = new Size(703, 73);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su codigo de retiro:";
            label1.Click += label1_Click;
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
            RegresarBtn.Location = new Point(-3, 567);
            RegresarBtn.Name = "RegresarBtn";
            RegresarBtn.Size = new Size(255, 91);
            RegresarBtn.TabIndex = 13;
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
            roundButton3.Location = new Point(-3, 580);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(255, 91);
            roundButton3.TabIndex = 14;
            roundButton3.TextColor = Color.White;
            roundButton3.UseVisualStyleBackColor = false;
            // 
            // ingresar_btn
            // 
            ingresar_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ingresar_btn.BackColor = Color.FromArgb(204, 24, 38);
            ingresar_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            ingresar_btn.BorderColor = Color.FromArgb(204, 24, 38);
            ingresar_btn.BorderRadius = 10;
            ingresar_btn.BorderSize = 1;
            ingresar_btn.FlatAppearance.BorderSize = 0;
            ingresar_btn.FlatStyle = FlatStyle.Flat;
            ingresar_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ingresar_btn.ForeColor = Color.White;
            ingresar_btn.Location = new Point(776, 567);
            ingresar_btn.Name = "ingresar_btn";
            ingresar_btn.Size = new Size(255, 91);
            ingresar_btn.TabIndex = 15;
            ingresar_btn.Text = "Ingresar";
            ingresar_btn.TextColor = Color.White;
            ingresar_btn.UseVisualStyleBackColor = false;
            ingresar_btn.Click += pictureBox2_Click;
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
            roundButton2.Location = new Point(776, 580);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(255, 91);
            roundButton2.TabIndex = 16;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // PantallaRetiroSinTarjetaP1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 39, 55);
            Controls.Add(ingresar_btn);
            Controls.Add(roundButton2);
            Controls.Add(RegresarBtn);
            Controls.Add(roundButton3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "PantallaRetiroSinTarjetaP1";
            Size = new Size(1024, 721);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private RoundButton RegresarBtn;
        private RoundButton roundButton3;
        private RoundButton ingresar_btn;
        private RoundButton roundButton2;
    }
}
