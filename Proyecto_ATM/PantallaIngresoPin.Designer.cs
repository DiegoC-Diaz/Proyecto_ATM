namespace Proyecto_ATM
{
    partial class PantallaIngresoPin
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            textbox_pin = new TextBox();
            ingresar_btn = new RoundButton();
            roundButton2 = new RoundButton();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(204, 24, 38);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(147, 636);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 85);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 30, 30);
            label2.Location = new Point(453, 215);
            label2.Name = "label2";
            label2.Size = new Size(258, 49);
            label2.TabIndex = 6;
            label2.Text = "Ingrese su pin:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 49.8000031F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 92);
            label1.Name = "label1";
            label1.Size = new Size(767, 103);
            label1.TabIndex = 5;
            label1.Text = " ¡Bienvenido al ATM!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(204, 24, 38);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 721);
            panel1.TabIndex = 4;
            // 
            // textbox_pin
            // 
            textbox_pin.Anchor = AnchorStyles.None;
            textbox_pin.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_pin.Location = new Point(275, 314);
            textbox_pin.Name = "textbox_pin";
            textbox_pin.Size = new Size(629, 56);
            textbox_pin.TabIndex = 7;
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
            ingresar_btn.Location = new Point(816, 544);
            ingresar_btn.Name = "ingresar_btn";
            ingresar_btn.Size = new Size(223, 68);
            ingresar_btn.TabIndex = 9;
            ingresar_btn.Text = "Ingresar";
            ingresar_btn.TextColor = Color.White;
            ingresar_btn.UseVisualStyleBackColor = false;
            ingresar_btn.Click += ingresar_btn_Click;
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
            roundButton2.Location = new Point(816, 557);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(223, 68);
            roundButton2.TabIndex = 10;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // PantallaIngresoPin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ingresar_btn);
            Controls.Add(roundButton2);
            Controls.Add(textbox_pin);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "PantallaIngresoPin";
            Size = new Size(1024, 721);
            VisibleChanged += Reset;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox textbox_pin;
        private RoundButton ingresar_btn;
        private RoundButton roundButton2;
    }
}
