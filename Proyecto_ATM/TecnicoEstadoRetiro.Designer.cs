namespace Proyecto_ATM
{
    partial class TecnicoEstadoRetiro
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            regresar_btn = new RoundButton();
            roundButton2 = new RoundButton();
            salir_btn = new RoundButton();
            roundButton3 = new RoundButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label100 = new Label();
            label200 = new Label();
            label500 = new Label();
            label3 = new Label();
            label4 = new Label();
            Valor100 = new Label();
            Valor200 = new Label();
            Valor500 = new Label();
            labelMontoRetirado = new Label();
            ValorTotal = new Label();
            EstadoActual = new Label();
            TotalLabel = new Label();
            Total100 = new Label();
            Total200 = new Label();
            Total500 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(204, 24, 38);
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(90, 461);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(806, 80);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(238, 39, 55);
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 541);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
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
            regresar_btn.Location = new Point(90, 376);
            regresar_btn.Margin = new Padding(3, 2, 3, 2);
            regresar_btn.Name = "regresar_btn";
            regresar_btn.Size = new Size(195, 51);
            regresar_btn.TabIndex = 13;
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
            roundButton2.Location = new Point(90, 382);
            roundButton2.Margin = new Padding(3, 2, 3, 2);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(195, 51);
            roundButton2.TabIndex = 14;
            roundButton2.TextColor = Color.White;
            roundButton2.UseVisualStyleBackColor = false;
            // 
            // salir_btn
            // 
            //salir_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            //salir_btn.BackColor = Color.FromArgb(204, 24, 38);
            //salir_btn.BackgroundColor = Color.FromArgb(204, 24, 38);
            //salir_btn.BorderColor = Color.FromArgb(204, 24, 38);
            //salir_btn.BorderRadius = 10;
            //salir_btn.BorderSize = 1;
            //salir_btn.FlatAppearance.BorderSize = 0;
            //salir_btn.FlatStyle = FlatStyle.Flat;
            //salir_btn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //salir_btn.ForeColor = Color.White;
            //salir_btn.Location = new Point(701, 376);
            //salir_btn.Margin = new Padding(3, 2, 3, 2);
            //salir_btn.Name = "salir_btn";
            //salir_btn.Size = new Size(195, 51);
            //salir_btn.TabIndex = 15;
            //salir_btn.Text = "Salir";
            //salir_btn.TextColor = Color.White;
            //salir_btn.UseVisualStyleBackColor = false;
            //salir_btn.Click += salir_btn_Click;
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
            roundButton3.Location = new Point(701, 382);
            roundButton3.Margin = new Padding(3, 2, 3, 2);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(195, 51);
            roundButton3.TabIndex = 16;
            roundButton3.TextColor = Color.White;
            roundButton3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Location = new Point(205, 109);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutPanel1.Size = new Size(0, 0);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // label100
            // 
            label100.BackColor = Color.FromArgb(238, 39, 55);
            label100.BorderStyle = BorderStyle.FixedSingle;
            label100.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label100.ForeColor = Color.White;
            label100.Location = new Point(302, 96);
            label100.Margin = new Padding(2, 0, 2, 0);
            label100.Name = "label100";
            label100.Size = new Size(162, 44);
            label100.TabIndex = 0;
            label100.Text = "100";
            label100.TextAlign = ContentAlignment.MiddleCenter;
            label100.Click += label1_Click_1;
            // 
            // label200
            // 
            label200.BackColor = Color.FromArgb(238, 39, 55);
            label200.BorderStyle = BorderStyle.FixedSingle;
            label200.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label200.ForeColor = Color.White;
            label200.Location = new Point(461, 96);
            label200.Margin = new Padding(2, 0, 2, 0);
            label200.Name = "label200";
            label200.Size = new Size(162, 44);
            label200.TabIndex = 18;
            label200.Text = "200";
            label200.TextAlign = ContentAlignment.MiddleCenter;
            label200.Click += label1_Click_2;
            // 
            // label500
            // 
            label500.BackColor = Color.FromArgb(238, 39, 55);
            label500.BorderStyle = BorderStyle.FixedSingle;
            label500.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label500.ForeColor = Color.White;
            label500.Location = new Point(612, 96);
            label500.Margin = new Padding(2, 0, 2, 0);
            label500.Name = "label500";
            label500.Size = new Size(162, 44);
            label500.TabIndex = 19;
            label500.Text = "500";
            label500.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(238, 39, 55);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(150, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 44);
            label3.TabIndex = 20;
            label3.Text = "Billetes de:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(150, 139);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 44);
            label4.TabIndex = 21;
            label4.Text = "Cantidad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Valor100
            // 
            Valor100.BackColor = Color.White;
            Valor100.BorderStyle = BorderStyle.FixedSingle;
            Valor100.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Valor100.ForeColor = Color.Black;
            Valor100.Location = new Point(302, 139);
            Valor100.Margin = new Padding(2, 0, 2, 0);
            Valor100.Name = "Valor100";
            Valor100.Size = new Size(162, 44);
            Valor100.TabIndex = 22;
            Valor100.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Valor200
            // 
            Valor200.BackColor = Color.White;
            Valor200.BorderStyle = BorderStyle.FixedSingle;
            Valor200.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Valor200.ForeColor = Color.Black;
            Valor200.Location = new Point(461, 139);
            Valor200.Margin = new Padding(2, 0, 2, 0);
            Valor200.Name = "Valor200";
            Valor200.Size = new Size(162, 44);
            Valor200.TabIndex = 23;
            Valor200.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Valor500
            // 
            Valor500.BackColor = Color.White;
            Valor500.BorderStyle = BorderStyle.FixedSingle;
            Valor500.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Valor500.ForeColor = Color.Black;
            Valor500.Location = new Point(612, 139);
            Valor500.Margin = new Padding(2, 0, 2, 0);
            Valor500.Name = "Valor500";
            Valor500.Size = new Size(162, 44);
            Valor500.TabIndex = 24;
            Valor500.TextAlign = ContentAlignment.MiddleCenter;
            Valor500.Click += label7_Click;
            // 
            // labelMontoRetirado
            // 
            labelMontoRetirado.BackColor = Color.FromArgb(238, 39, 55);
            labelMontoRetirado.BorderStyle = BorderStyle.FixedSingle;
            labelMontoRetirado.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMontoRetirado.ForeColor = Color.White;
            labelMontoRetirado.Location = new Point(150, 268);
            labelMontoRetirado.Margin = new Padding(2, 0, 2, 0);
            labelMontoRetirado.Name = "labelMontoRetirado";
            labelMontoRetirado.Size = new Size(624, 44);
            labelMontoRetirado.TabIndex = 25;
            labelMontoRetirado.Text = "Monto Retirado Total";
            labelMontoRetirado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ValorTotal
            // 
            ValorTotal.BackColor = Color.White;
            ValorTotal.BorderStyle = BorderStyle.FixedSingle;
            ValorTotal.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValorTotal.ForeColor = Color.Black;
            ValorTotal.Location = new Point(150, 312);
            ValorTotal.Margin = new Padding(2, 0, 2, 0);
            ValorTotal.Name = "ValorTotal";
            ValorTotal.Size = new Size(624, 44);
            ValorTotal.TabIndex = 26;
            ValorTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EstadoActual
            // 
            EstadoActual.AutoSize = true;
            EstadoActual.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EstadoActual.Location = new Point(262, 23);
            EstadoActual.Margin = new Padding(2, 0, 2, 0);
            EstadoActual.Name = "HistorialRetiro";
            EstadoActual.Size = new Size(373, 46);
            EstadoActual.TabIndex = 27;
            EstadoActual.Text = "Historial de Billetes Retirados";
            // 
            // TotalLabel
            // 
            TotalLabel.BackColor = Color.White;
            TotalLabel.BorderStyle = BorderStyle.FixedSingle;
            TotalLabel.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalLabel.ForeColor = Color.Black;
            TotalLabel.Location = new Point(150, 183);
            TotalLabel.Margin = new Padding(2, 0, 2, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(162, 44);
            TotalLabel.TabIndex = 28;
            TotalLabel.Text = "Total";
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            TotalLabel.Click += TotalLabel_Click;
            // 
            // Total100
            // 
            Total100.BackColor = Color.White;
            Total100.BorderStyle = BorderStyle.FixedSingle;
            Total100.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total100.ForeColor = Color.Black;
            Total100.Location = new Point(302, 183);
            Total100.Margin = new Padding(2, 0, 2, 0);
            Total100.Name = "Total100";
            Total100.Size = new Size(162, 44);
            Total100.TabIndex = 29;
            Total100.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Total200
            // 
            Total200.BackColor = Color.White;
            Total200.BorderStyle = BorderStyle.FixedSingle;
            Total200.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total200.ForeColor = Color.Black;
            Total200.Location = new Point(461, 183);
            Total200.Margin = new Padding(2, 0, 2, 0);
            Total200.Name = "Total200";
            Total200.Size = new Size(162, 44);
            Total200.TabIndex = 30;
            Total200.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Total500
            // 
            Total500.BackColor = Color.White;
            Total500.BorderStyle = BorderStyle.FixedSingle;
            Total500.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Total500.ForeColor = Color.Black;
            Total500.Location = new Point(612, 183);
            Total500.Margin = new Padding(2, 0, 2, 0);
            Total500.Name = "Total500";
            Total500.Size = new Size(162, 44);
            Total500.TabIndex = 31;
            Total500.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TecnicoEstadoRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //Controls.Add(Total500);
            //Controls.Add(Total200);
            //Controls.Add(Total100);
            //Controls.Add(TotalLabel);
            Controls.Add(EstadoActual);
            Controls.Add(ValorTotal);
            Controls.Add(labelMontoRetirado);
            Controls.Add(label100);
            Controls.Add(Valor500);
            Controls.Add(Valor200);
            Controls.Add(Valor100);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label500);
            Controls.Add(label200);
            Controls.Add(tableLayoutPanel1);
            //Controls.Add(salir_btn);
            //Controls.Add(roundButton3);
            Controls.Add(regresar_btn);
            Controls.Add(roundButton2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "TecnicoEstadoRetiro";
            Size = new Size(896, 541);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RoundButton regresar_btn;
        private RoundButton roundButton2;
        private RoundButton salir_btn;
        private RoundButton roundButton3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label100;
        private Label label200;
        private Label label500;
        private Label label3;
        private Label label4;
        private Label Valor100;
        private Label Valor200;
        private Label Valor500;
        private Label labelMontoRetirado;
        private Label ValorTotal;
        private Label EstadoActual;
        private Label TotalLabel;
        private Label Total100;
        private Label Total200;
        private Label Total500;
    }
}
