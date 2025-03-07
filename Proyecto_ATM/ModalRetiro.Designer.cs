namespace Proyecto_ATM
{
    partial class ModalRetiro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cantidad_billetes_100 = new Label();
            cantidad_billetes_200 = new Label();
            cantidad_billetes_500 = new Label();
            total_billetes_100 = new Label();
            total_billetes_200 = new Label();
            total_billetes_500 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ok_btn = new RoundButton();
            roundButton2 = new RoundButton();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(cantidad_billetes_100, 1, 0);
            tableLayoutPanel1.Controls.Add(cantidad_billetes_200, 1, 1);
            tableLayoutPanel1.Controls.Add(cantidad_billetes_500, 1, 2);
            tableLayoutPanel1.Controls.Add(total_billetes_100, 2, 0);
            tableLayoutPanel1.Controls.Add(total_billetes_200, 2, 1);
            tableLayoutPanel1.Controls.Add(total_billetes_500, 2, 2);
            tableLayoutPanel1.Location = new Point(199, 171);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.49505F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.50495F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(507, 186);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 20);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 0;
            label4.Text = "L. 100";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 81);
            label5.Name = "label5";
            label5.Size = new Size(70, 24);
            label5.TabIndex = 1;
            label5.Text = "L. 200";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 142);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 2;
            label6.Text = "L. 500";
            // 
            // cantidad_billetes_100
            // 
            cantidad_billetes_100.Anchor = AnchorStyles.Left;
            cantidad_billetes_100.AutoSize = true;
            cantidad_billetes_100.Font = new Font("Segoe UI", 14.25F);
            cantidad_billetes_100.Location = new Point(184, 19);
            cantidad_billetes_100.Name = "cantidad_billetes_100";
            cantidad_billetes_100.Size = new Size(63, 25);
            cantidad_billetes_100.TabIndex = 3;
            cantidad_billetes_100.Text = "label7";
            // 
            // cantidad_billetes_200
            // 
            cantidad_billetes_200.Anchor = AnchorStyles.Left;
            cantidad_billetes_200.AutoSize = true;
            cantidad_billetes_200.Font = new Font("Segoe UI", 14.25F);
            cantidad_billetes_200.Location = new Point(184, 81);
            cantidad_billetes_200.Name = "cantidad_billetes_200";
            cantidad_billetes_200.Size = new Size(63, 25);
            cantidad_billetes_200.TabIndex = 4;
            cantidad_billetes_200.Text = "label8";
            // 
            // cantidad_billetes_500
            // 
            cantidad_billetes_500.Anchor = AnchorStyles.Left;
            cantidad_billetes_500.AutoSize = true;
            cantidad_billetes_500.Font = new Font("Segoe UI", 14.25F);
            cantidad_billetes_500.Location = new Point(184, 142);
            cantidad_billetes_500.Name = "cantidad_billetes_500";
            cantidad_billetes_500.Size = new Size(63, 25);
            cantidad_billetes_500.TabIndex = 5;
            cantidad_billetes_500.Text = "label9";
            // 
            // total_billetes_100
            // 
            total_billetes_100.Anchor = AnchorStyles.Left;
            total_billetes_100.AutoSize = true;
            total_billetes_100.Font = new Font("Segoe UI", 12F);
            total_billetes_100.Location = new Point(363, 21);
            total_billetes_100.Name = "total_billetes_100";
            total_billetes_100.Size = new Size(61, 21);
            total_billetes_100.TabIndex = 6;
            total_billetes_100.Text = "label10";
            // 
            // total_billetes_200
            // 
            total_billetes_200.Anchor = AnchorStyles.Left;
            total_billetes_200.AutoSize = true;
            total_billetes_200.Font = new Font("Segoe UI", 12F);
            total_billetes_200.Location = new Point(363, 83);
            total_billetes_200.Name = "total_billetes_200";
            total_billetes_200.Size = new Size(61, 21);
            total_billetes_200.TabIndex = 7;
            total_billetes_200.Text = "label11";
            // 
            // total_billetes_500
            // 
            total_billetes_500.Anchor = AnchorStyles.Left;
            total_billetes_500.AutoSize = true;
            total_billetes_500.Font = new Font("Segoe UI", 12F);
            total_billetes_500.Location = new Point(363, 144);
            total_billetes_500.Name = "total_billetes_500";
            total_billetes_500.Size = new Size(61, 21);
            total_billetes_500.TabIndex = 8;
            total_billetes_500.Text = "label12";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(204, 24, 38);
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.13774F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.86226F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new Point(199, 120);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(507, 54);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(408, 16);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Total";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(186, 16);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 1;
            label2.Text = "Billetes Dispensados";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Tipo Billete";
            label1.Click += label1_Click;
            // 
            // ok_btn
            // 
            ok_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ok_btn.BackColor = Color.FromArgb(204, 24, 38);
            ok_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderColor = Color.FromArgb(204, 24, 38);
            ok_btn.BorderRadius = 10;
            ok_btn.BorderSize = 1;
            ok_btn.FlatAppearance.BorderSize = 0;
            ok_btn.FlatStyle = FlatStyle.Flat;
            ok_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ok_btn.ForeColor = Color.White;
            ok_btn.Location = new Point(368, 409);
            ok_btn.Margin = new Padding(3, 2, 3, 2);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(195, 51);
            ok_btn.TabIndex = 11;
            ok_btn.Text = "Ok";
            ok_btn.TextColor = Color.White;
            ok_btn.UseVisualStyleBackColor = false;
            ok_btn.Click += ok_btn_Click;
            // 
            // roundButton2
            // 
            roundButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            roundButton2.Location = new Point(368, 420);
            roundButton2.Margin = new Padding(3, 2, 3, 2);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(195, 51);
            roundButton2.TabIndex = 12;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(204, 24, 38);
            label7.Location = new Point(368, 35);
            label7.Name = "label7";
            label7.Size = new Size(209, 32);
            label7.TabIndex = 13;
            label7.Text = "Retiro Exitoso!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(204, 24, 38);
            label8.Location = new Point(175, 76);
            label8.Name = "label8";
            label8.Size = new Size(570, 32);
            label8.TabIndex = 14;
            label8.Text = "Se han dispensado los siguientes billetes:";
            // 
            // ModalRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 541);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ok_btn);
            Controls.Add(roundButton2);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "ModalRetiro";
            Text = "ModalRetiro";
            Load += ModalRetiro_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label cantidad_billetes_100;
        private Label cantidad_billetes_200;
        private Label cantidad_billetes_500;
        private Label total_billetes_100;
        private Label total_billetes_200;
        private Label total_billetes_500;
        private Label label3;
        private Label label2;
        private RoundButton ok_btn;
        private RoundButton roundButton2;
        private Label label7;
        private Label label8;
    }
}