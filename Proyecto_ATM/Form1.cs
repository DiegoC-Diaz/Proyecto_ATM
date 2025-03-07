using Proyecto_ATM.api;
using System.ComponentModel;

namespace Proyecto_ATM
{
    public partial class Form1 : Form
    {

        public static int parentX, parentY;
        public Form1()
        {
            InitializeComponent();
        }
        private Usuario usuario;
        private Conector conector;
        private void Form1_Load(object sender, EventArgs e)
        {

            pantallaTomeSuDinero.StopTimer();
            pantallaDespedida.StopTimer();

            //bienvenida & despedida
            pantallaBienvenida.BringToFront();
            pantallaDespedida.Hide();

            //Menus
            pantallaMenuRetiro.Hide();
            pantallaMenuTecnico.Hide();
            pantallaMenuAgente.Hide();
            pantallaMenuConsulta.Hide();

            //Retiro normal
            pantallaRetiroNormalP1.Hide();
            pantallaRetiroNormalP2.Hide();
            pantallaIngresoTarjeta.Hide();
            pantallaIngresoPin.Hide();

            //Retiro sin Tarjeta
            pantallaRetiroSinTarjetaP1.Hide();
            pantallaRetiroSinTarjetaP2.Hide();

            //tecnico
            pantallaMovimientosTecnico.Hide();

            //Tome su Dinero
            pantallaTomeSuDinero.Hide();
            pantallaHistorialRetiro.Hide();

            //PantallSaldo
            pantallaSaldo.cambiarEspera += new EventHandler(switch_to_menu_consulta);


            //Transiciones
            //menu de Retiro
            pantallaMenuRetiro.salirMenuRetiro += new EventHandler(switch_to_bienvenida);
            pantallaMenuRetiro.redIngresoTarjeta_MenuRetiro += new EventHandler(switch_to_ingreso_tarjeta);
            pantallaMenuRetiro.redIngresoSinTarjeta_MenuRetiro += new EventHandler(switch_to_retiro_sin_tarjeta);

            //menu de Consulta
            pantallaMenuConsulta.salirMenuConsulta += new EventHandler(switch_to_bienvenida);
            pantallaMenuConsulta.regresarMenuConsulta += new EventHandler(switch_to_menu_retiro);
            pantallaMenuConsulta.redConsulta_MenuConsulta += new EventHandler(switch_to_pantall_saldo); //La consulta aun no esta :P
            pantallaMenuConsulta.redRetiroP1_MenuConsulta += new EventHandler(switch_to_retiro_normal_1);

            //menu de Tecnico
            pantallaMenuTecnico.salirMenuTecnico += new EventHandler(switch_to_bienvenida);
            pantallaMenuTecnico.redMovimientos_MenuTecnico += new EventHandler(switch_to_movimientos);
            pantallaMenuTecnico.redEstadoAct_MenuTecnico += new EventHandler(switch_to_EstadoActual);

            //menu de Agente
            pantallaMenuAgente.salirMenuAgente += new EventHandler(switch_to_bienvenida);

            //despedida & bienvenida
            pantallaDespedida.despedidaTimeUp += new EventHandler(switch_to_bienvenida);
            pantallaBienvenida.IngresarMenuRetiro += new EventHandler(switch_to_menu_retiro);

            //pantalla Ingreso Tarjeta e Ingreso de pin
            pantallaIngresoTarjeta.IrIngresoPin += new EventHandler(switch_to_ingreso_pin);
            pantallaBienvenida.IrIngresoTarjeta += new EventHandler(switch_to_ingreso_tarjeta);
            pantallaIngresoPin.IngresarMenuConsulta += new EventHandler(switch_to_menu_consulta);
            pantallaIngresoPin.IngresarMenuTecnico += new EventHandler(switch_to_menu_tecnico);
            pantallaIngresoPin.IngresarMenuAgente += new EventHandler(switch_to_menu_agente);

            //Seleccion de Monto
            pantallaRetiroNormalP1.EventoMonto += new EventHandler(switch_to_tome_dinero);
            pantallaRetiroNormalP1.EventoRegresar += new EventHandler(switch_to_menu_retiro);
            pantallaRetiroNormalP1.EventoMontoPersonalizado += new EventHandler(switch_to_retiro_normal_2);

            //EstaodActual del ATM
            pantallaEstadoActual.regresarMenuTecnico += new EventHandler(switch_to_menu_tecnico);
            pantallaEstadoActual.salirPantallaBienvenida += new EventHandler(switch_to_bienvenida);

            pantallaRetiroNormalP2.EventoRegresar1 += new EventHandler(switch_to_menu_retiro);
            pantallaRetiroNormalP2.retiroExitoso += new EventHandler(switch_to_tome_dinero);

            //Pantalla Retiro Sin Tarjeta
            pantallaRetiroSinTarjetaP1.cambioPt2 += new EventHandler(switch_to_RetiroPT2);
            pantallaRetiroSinTarjetaP2.retiroSinTarjetaExitoso += new EventHandler(switch_to_tome_dinero);
            pantallaRetiroSinTarjetaP2.retiroSinTarjetaFallido += new EventHandler(switch_to_bienvenida);
            pantallaRetiroSinTarjetaP2.regresarP2 += new EventHandler(switch_to_menu_retiro);

            //
            pantallaTomeSuDinero.timerDinero += new EventHandler(switch_to_despedida);
            pantallaDespedida.despedidaTimeUp += new EventHandler(switch_to_bienvenida);
            pantallaRetiroSinTarjetaP1.EventoRegresar1 += new EventHandler(switch_to_menu_retiro);
            pantallaRetiroNormalP1.retiroExitoso += new EventHandler(switch_to_tome_dinero);
            pantallaIngresoPin.AcctorPinIncorrect += new EventHandler(switch_to_bienvenida);
            pantallaIngresoPin.RegresarIngresoTarjeta += new EventHandler(switch_to_ingreso_tarjeta);


            //Pantalla Movimiento
            pantallaMovimientosTecnico.regresar += new EventHandler(switch_to_menu_tecnico);
            pantallaMovimientosTecnico.Historialbilletes += new EventHandler(switch_to_HistorialRetiro);

            //Pantalla Historial Billetes de Retiro
            pantallaHistorialRetiro.regresarDePantallaEstadoRetiro += new EventHandler(switch_to_movimientos);


            //Codgigo necesario par alo modals, las notificaicones que se muestran
            usuario = new Usuario();
            pantallaIngresoPin.Usuario = usuario;
            pantallaIngresoTarjeta.usuario = usuario;
            parentX = this.Location.X;
            parentY = this.Location.Y;

            panel1.Hide();


        }

        private void PantallaEstadoActual_salirPantallaBienvenida(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch_to_bienvenida(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch_to_retiro_normal_1(sender, e);

        }

        /// <summary>
        /// Esta funcion hace qu todas las pantallas se oculten
        /// </summary>
        private void hide_all()
        {

            pantallaDespedida.Hide();
            pantallaMenuRetiro.Hide();
            pantallaRetiroNormalP1.Hide();
            pantallaRetiroNormalP2.Hide();
            pantallaMenuTecnico.Hide();
            pantallaBienvenida.Hide();
            pantallaIngresoTarjeta.Hide();
            pantallaIngresoPin.Hide();
            pantallaSaldo.Hide();
            pantallaTomeSuDinero.Hide();
            pantallaEstadoActual.Hide();
            pantallaMenuTecnico.Hide();
            pantallaMovimientosTecnico.Hide();
        
        }

        //Transiciones

        //Bienvenida & Despedida
        public void switch_to_bienvenida(object sender, EventArgs e)
        {
            hide_all();
            pantallaBienvenida.Show();
            pantallaBienvenida.BringToFront();
            usuario = new Usuario();

        }
        public void switch_to_despedida(object sender, EventArgs e)
        {

            hide_all();
            pantallaDespedida.Show();
            pantallaDespedida.BringToFront();
            pantallaDespedida.StartTimer();

        }

        //Ingreso de Tarjeta & Pin
        public void switch_to_ingreso_tarjeta(object sender, EventArgs e)
        {
            hide_all();
            pantallaIngresoTarjeta.Show();
            pantallaIngresoTarjeta.BringToFront();

        }

        public void switch_to_movimientos(object sender, EventArgs e) {
            hide_all();
            pantallaMovimientosTecnico.refrescar(sender, e);
            pantallaMovimientosTecnico.Show();
            pantallaMovimientosTecnico.BringToFront();
          

        }
        public void switch_to_ingreso_pin(object sender, EventArgs e)
        {
            hide_all();
            pantallaIngresoPin.Show();
            pantallaIngresoPin.BringToFront();

        }

        //Retiro Normal 
        public void switch_to_retiro_normal_1(object sender, EventArgs e)
        {
            hide_all();
            pantallaRetiroNormalP1.Show();
            pantallaRetiroNormalP1.BringToFront();
        }

        private void switch_to_retiro_normal_2(object sender, EventArgs e)
        {
            hide_all();
            pantallaRetiroNormalP2.Show();
            pantallaRetiroNormalP2.BringToFront();
        }
        private void switch_to_retiro_normal_2()
        {

            hide_all();
            pantallaRetiroNormalP2.Show();
            pantallaRetiroNormalP2.BringToFront();
        }
        //Retiro Sin Tarjeta
        private void switch_to_retiro_sin_tarjeta(object sender, EventArgs e)
        {
            hide_all();
            pantallaRetiroSinTarjetaP1.Show();
            pantallaRetiroSinTarjetaP1.BringToFront();
        }

        //Menus
        private void switch_to_menu_retiro(object sender, EventArgs e)
        {
            hide_all();

            pantallaMenuRetiro.Show();
            pantallaMenuRetiro.BringToFront();
        }
        private void switch_to_pantall_saldo(object sender, EventArgs e)
        {
            hide_all();
            pantallaSaldo.Show();
            pantallaSaldo.BringToFront();
        }

        private void switch_to_menu_tecnico(object sender, EventArgs e)
        {
            hide_all();
            pantallaMenuTecnico.Show();
            pantallaMenuTecnico.BringToFront();
           

        }

        private void switch_to_menu_consulta(object sender, EventArgs e)
        {
            hide_all();
            pantallaMenuConsulta.Show();
            pantallaMenuConsulta.BringToFront();
        }

        private void switch_to_menu_agente(object sender, EventArgs e)
        {
            hide_all();
            pantallaMenuAgente.Show();
            pantallaMenuAgente.BringToFront();
        }

        private void switch_to_tome_dinero(object sender, EventArgs e)
        {
            hide_all();
            pantallaTomeSuDinero.Show();
            pantallaTomeSuDinero.BringToFront();
            pantallaTomeSuDinero.StartTimer();
        }

        private void switch_to_EstadoActual(object sender, EventArgs e) {
            hide_all();
            pantallaEstadoActual.Show();
            pantallaEstadoActual.BringToFront();
            pantallaEstadoActual.LoadInfo();
        }

        private void switch_to_RetiroPT2(object sender, EventArgs e) {
            hide_all();
            pantallaRetiroSinTarjetaP2.Show();
            pantallaRetiroSinTarjetaP2.BringToFront();

        }

        private void switch_to_HistorialRetiro(object sender, EventArgs e)
        {
            hide_all();
            pantallaHistorialRetiro.Show();
            pantallaHistorialRetiro.BringToFront();
            pantallaHistorialRetiro.LoadInfo();
        }

        //Botones 
        private void button3_Click(object sender, EventArgs e)
        {
            switch_to_despedida(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch_to_retiro_normal_2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch_to_menu_tecnico(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch_to_menu_retiro(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch_to_menu_consulta(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch_to_menu_agente(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch_to_tome_dinero(sender, e);
        }

        //private void pantallaTomeSuDinero1_Load(object sender, EventArgs e)
        //{

        //}

        private void pantallaSaldo_Load(object sender, EventArgs e)
        {

        }
    }
}
