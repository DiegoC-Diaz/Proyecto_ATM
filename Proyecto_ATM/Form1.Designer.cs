namespace Proyecto_ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            pantallaEstadoActual = new TecnicoEstadoActual();
            pantallaTomeSuDinero = new PantallaTomeSuDinero();
            pantallaSaldo = new PantallaSaldo();
            pantallaRetiroNormalP2 = new PantallaRetiroNormalP2();
            pantallaRetiroNormalP1 = new PantallaRetiroNormalP1();
            pantallaRetiroSinTarjetaP2 = new PantallaRetiroSinTarjetaP2();
            pantallaRetiroSinTarjetaP1 = new PantallaRetiroSinTarjetaP1();
            pantallaMenuRetiro = new PantallaMenuRetiro();
            pantallaMenuTecnico = new PantallaMenuTecnico();
            pantallaMenuConsulta = new PantallaMenuConsulta();
            pantallaMenuAgente = new PantallaMenuAgente();
            pantallaDespedida = new PantallaDespedida();
            pantallaBienvenida = new PantallaBienvenida();
            pantallaIngresoTarjeta = new PantallaIngresoTarjeta();
            pantallaIngresoPin = new PantallaIngresoPin();
            pantallaMovimientosTecnico = new PantallaMovimientosTecnico();
            pantallaHistorialRetiro = new TecnicoEstadoRetiro();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(105, 800);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.Location = new Point(0, 240);
            button9.Name = "button9";
            button9.Size = new Size(105, 30);
            button9.TabIndex = 7;
            button9.Text = "TomeDinero";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.Location = new Point(0, 210);
            button8.Name = "button8";
            button8.Size = new Size(105, 30);
            button8.TabIndex = 6;
            button8.Text = "PMenuA";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.Location = new Point(0, 180);
            button7.Name = "button7";
            button7.Size = new Size(105, 30);
            button7.TabIndex = 5;
            button7.Text = "PMenuC";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 150);
            button5.Name = "button5";
            button5.Size = new Size(105, 30);
            button5.TabIndex = 3;
            button5.Text = "PMenuR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 120);
            button6.Name = "button6";
            button6.Size = new Size(105, 30);
            button6.TabIndex = 4;
            button6.Text = "PMenuT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 90);
            button4.Name = "button4";
            button4.Size = new Size(105, 30);
            button4.TabIndex = 2;
            button4.Text = "PRetiroN2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 60);
            button1.Name = "button1";
            button1.Size = new Size(105, 30);
            button1.TabIndex = 0;
            button1.Text = "PRetiroN1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 30);
            button3.Name = "button3";
            button3.Size = new Size(105, 30);
            button3.TabIndex = 1;
            button3.Text = "PDespedida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(105, 30);
            button2.TabIndex = 0;
            button2.Text = "PBienvenida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pantallaEstadoActual);
            panel2.Controls.Add(pantallaTomeSuDinero);
            panel2.Controls.Add(pantallaSaldo);
            panel2.Controls.Add(pantallaRetiroNormalP2);
            panel2.Controls.Add(pantallaRetiroNormalP1);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP2);
            panel2.Controls.Add(pantallaRetiroSinTarjetaP1);
            panel2.Controls.Add(pantallaMenuRetiro);
            panel2.Controls.Add(pantallaMenuTecnico);
            panel2.Controls.Add(pantallaMenuConsulta);
            panel2.Controls.Add(pantallaMenuAgente);
            panel2.Controls.Add(pantallaDespedida);
            panel2.Controls.Add(pantallaBienvenida);
            panel2.Controls.Add(pantallaIngresoTarjeta);
            panel2.Controls.Add(pantallaIngresoPin);
            panel2.Controls.Add(pantallaMovimientosTecnico);
            panel2.Controls.Add(pantallaHistorialRetiro);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(105, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1085, 800);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pantallaEstadoActual
            // 
            pantallaEstadoActual.Dock = DockStyle.Fill;
            pantallaEstadoActual.Location = new Point(0, 0);
            pantallaEstadoActual.Margin = new Padding(2, 2, 2, 2);
            pantallaEstadoActual.Name = "pantallaEstadoActual";
            pantallaEstadoActual.Size = new Size(1085, 800);
            pantallaEstadoActual.TabIndex = 8;
            pantallaEstadoActual.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaTomeSuDinero
            // 
            pantallaTomeSuDinero.BackColor = Color.FromArgb(238, 39, 55);
            pantallaTomeSuDinero.Dock = DockStyle.Fill;
            pantallaTomeSuDinero.Location = new Point(0, 0);
            pantallaTomeSuDinero.Margin = new Padding(3, 2, 3, 2);
            pantallaTomeSuDinero.Name = "pantallaTomeSuDinero";
            pantallaTomeSuDinero.Size = new Size(1085, 800);
            pantallaTomeSuDinero.TabIndex = 8;
            pantallaTomeSuDinero.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaSaldo
            // 
            pantallaSaldo.Dock = DockStyle.Fill;
            pantallaSaldo.Location = new Point(0, 0);
            pantallaSaldo.Margin = new Padding(4, 4, 4, 4);
            pantallaSaldo.Name = "pantallaSaldo";
            pantallaSaldo.Size = new Size(1085, 800);
            pantallaSaldo.TabIndex = 6;
            pantallaSaldo.Load += pantallaSaldo_Load;
            pantallaSaldo.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroNormalP2
            // 
            pantallaRetiroNormalP2.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroNormalP2.Dock = DockStyle.Fill;
            pantallaRetiroNormalP2.Location = new Point(0, 0);
            pantallaRetiroNormalP2.Margin = new Padding(4, 4, 4, 4);
            pantallaRetiroNormalP2.Name = "pantallaRetiroNormalP2";
            pantallaRetiroNormalP2.Size = new Size(1085, 800);
            pantallaRetiroNormalP2.TabIndex = 5;
            pantallaRetiroNormalP2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroNormalP1
            // 
            pantallaRetiroNormalP1.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroNormalP1.Dock = DockStyle.Fill;
            pantallaRetiroNormalP1.Location = new Point(0, 0);
            pantallaRetiroNormalP1.Margin = new Padding(5, 5, 5, 5);
            pantallaRetiroNormalP1.Name = "pantallaRetiroNormalP1";
            pantallaRetiroNormalP1.Size = new Size(1085, 800);
            pantallaRetiroNormalP1.TabIndex = 4;
            pantallaRetiroNormalP1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroSinTarjetaP2
            // 
            pantallaRetiroSinTarjetaP2.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroSinTarjetaP2.Dock = DockStyle.Fill;
            pantallaRetiroSinTarjetaP2.Location = new Point(0, 0);
            pantallaRetiroSinTarjetaP2.Margin = new Padding(4, 4, 4, 4);
            pantallaRetiroSinTarjetaP2.Name = "pantallaRetiroSinTarjetaP2";
            pantallaRetiroSinTarjetaP2.Size = new Size(1085, 800);
            pantallaRetiroSinTarjetaP2.TabIndex = 5;
            pantallaRetiroSinTarjetaP2.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaRetiroSinTarjetaP1
            // 
            pantallaRetiroSinTarjetaP1.BackColor = Color.FromArgb(238, 39, 55);
            pantallaRetiroSinTarjetaP1.Dock = DockStyle.Fill;
            pantallaRetiroSinTarjetaP1.Location = new Point(0, 0);
            pantallaRetiroSinTarjetaP1.Margin = new Padding(4, 4, 4, 4);
            pantallaRetiroSinTarjetaP1.Name = "pantallaRetiroSinTarjetaP1";
            pantallaRetiroSinTarjetaP1.Size = new Size(1085, 800);
            pantallaRetiroSinTarjetaP1.TabIndex = 4;
            pantallaRetiroSinTarjetaP1.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuRetiro
            // 
            pantallaMenuRetiro.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuRetiro.Dock = DockStyle.Fill;
            pantallaMenuRetiro.Location = new Point(0, 0);
            pantallaMenuRetiro.Margin = new Padding(4, 4, 4, 4);
            pantallaMenuRetiro.Name = "pantallaMenuRetiro";
            pantallaMenuRetiro.Size = new Size(1085, 800);
            pantallaMenuRetiro.TabIndex = 3;
            pantallaMenuRetiro.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuTecnico
            // 
            pantallaMenuTecnico.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuTecnico.Dock = DockStyle.Fill;
            pantallaMenuTecnico.Location = new Point(0, 0);
            pantallaMenuTecnico.Margin = new Padding(4, 4, 4, 4);
            pantallaMenuTecnico.Name = "pantallaMenuTecnico";
            pantallaMenuTecnico.Size = new Size(1085, 800);
            pantallaMenuTecnico.TabIndex = 2;
            pantallaMenuTecnico.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuConsulta
            // 
            pantallaMenuConsulta.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuConsulta.Dock = DockStyle.Fill;
            pantallaMenuConsulta.Location = new Point(0, 0);
            pantallaMenuConsulta.Margin = new Padding(4, 4, 4, 4);
            pantallaMenuConsulta.Name = "pantallaMenuConsulta";
            pantallaMenuConsulta.Size = new Size(1085, 800);
            pantallaMenuConsulta.TabIndex = 3;
            pantallaMenuConsulta.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaMenuAgente
            // 
            pantallaMenuAgente.BackColor = Color.FromArgb(238, 39, 55);
            pantallaMenuAgente.Dock = DockStyle.Fill;
            pantallaMenuAgente.Location = new Point(0, 0);
            pantallaMenuAgente.Margin = new Padding(4, 4, 4, 4);
            pantallaMenuAgente.Name = "pantallaMenuAgente";
            pantallaMenuAgente.Size = new Size(1085, 800);
            pantallaMenuAgente.TabIndex = 2;
            pantallaMenuAgente.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaDespedida
            // 
            pantallaDespedida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaDespedida.Dock = DockStyle.Fill;
            pantallaDespedida.Location = new Point(0, 0);
            pantallaDespedida.Margin = new Padding(4, 4, 4, 4);
            pantallaDespedida.Name = "pantallaDespedida";
            pantallaDespedida.Size = new Size(1085, 800);
            pantallaDespedida.TabIndex = 1;
            pantallaDespedida.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaBienvenida
            // 
            pantallaBienvenida.BackColor = Color.FromArgb(238, 39, 55);
            pantallaBienvenida.Dock = DockStyle.Fill;
            pantallaBienvenida.Location = new Point(0, 0);
            pantallaBienvenida.Margin = new Padding(4, 4, 4, 4);
            pantallaBienvenida.Name = "pantallaBienvenida";
            pantallaBienvenida.Size = new Size(1085, 800);
            pantallaBienvenida.TabIndex = 0;
            pantallaBienvenida.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaIngresoTarjeta
            // 
            pantallaIngresoTarjeta.BackColor = SystemColors.Control;
            pantallaIngresoTarjeta.Dock = DockStyle.Fill;
            pantallaIngresoTarjeta.Location = new Point(0, 0);
            pantallaIngresoTarjeta.Margin = new Padding(4, 4, 4, 4);
            pantallaIngresoTarjeta.Name = "pantallaIngresoTarjeta";
            pantallaIngresoTarjeta.Size = new Size(1085, 800);
            pantallaIngresoTarjeta.TabIndex = 0;
            pantallaIngresoTarjeta.usuario = null;
            pantallaIngresoTarjeta.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            // 
            // pantallaIngresoPin
            // 
            pantallaIngresoPin.Dock = DockStyle.Fill;
            pantallaIngresoPin.Location = new Point(0, 0);
            pantallaIngresoPin.Margin = new Padding(4, 4, 4, 4);
            pantallaIngresoPin.Name = "pantallaIngresoPin";
            pantallaIngresoPin.Size = new Size(1085, 800);
            pantallaIngresoPin.TabIndex = 1;
            pantallaIngresoPin.Usuario = null;
            pantallaIngresoPin.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //pantallaMovimientosTecnico
            pantallaMovimientosTecnico.BackColor = SystemColors.Control;
            pantallaMovimientosTecnico.Dock = DockStyle.Fill;
            pantallaMovimientosTecnico.Location = new Point(0, 0);
            pantallaMovimientosTecnico.Margin = new Padding(4, 4, 4, 4);
            pantallaMovimientosTecnico.Name = "pantallaMovimientosTecnico";
            pantallaMovimientosTecnico.Size = new Size(1085, 800);
            pantallaMovimientosTecnico.TabIndex = 0;
            pantallaMovimientosTecnico.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //
            // pantalla historial billetes
            //
            pantallaHistorialRetiro.BackColor = SystemColors.Control;
            pantallaHistorialRetiro.Dock = DockStyle.Fill;
            pantallaHistorialRetiro.Location = new Point(0, 0);
            pantallaHistorialRetiro.Margin = new Padding(4, 4, 4, 4);
            pantallaHistorialRetiro.Name = "pantallaMovimientosTecnico";
            pantallaHistorialRetiro.Size = new Size(1085, 800);
            pantallaHistorialRetiro.TabIndex = 0;
            pantallaHistorialRetiro.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1190, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        //Despedida & bienvenida
        private PantallaDespedida pantallaDespedida;
        private PantallaBienvenida pantallaBienvenida;
        //Menus
        private PantallaMenuTecnico pantallaMenuTecnico;
        private PantallaMenuAgente pantallaMenuAgente;
        private PantallaMenuConsulta pantallaMenuConsulta;
        private PantallaMenuRetiro pantallaMenuRetiro;
        //Retiro normal
        private PantallaIngresoTarjeta pantallaIngresoTarjeta;
        private PantallaIngresoPin pantallaIngresoPin;
        private PantallaRetiroNormalP1 pantallaRetiroNormalP1;
        private PantallaRetiroNormalP2 pantallaRetiroNormalP2;
        //Retiro sin Tarjeta
        private PantallaRetiroSinTarjetaP1 pantallaRetiroSinTarjetaP1;
        private PantallaRetiroSinTarjetaP2 pantallaRetiroSinTarjetaP2;
        //Movimientos
        private PantallaMovimientosTecnico pantallaMovimientosTecnico;

        

        private Button button7;
        private Button button8;
        private Button button9;
        private PantallaSaldo pantallaSaldo;
        private PantallaTomeSuDinero pantallaTomeSuDinero;
        private TecnicoEstadoActual pantallaEstadoActual;
        private TecnicoEstadoRetiro pantallaHistorialRetiro;

    }
}
