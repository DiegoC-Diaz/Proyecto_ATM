using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ATM.api
{
    public class MovimientoModel
    {
        public int id_cliente { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }
        public string monto { get; set; }
        public string tipo_retiro { get; set; }

        public string nombre { get; set; }


        public MovimientoModel()
        {

            id_cliente = 0;
            hora = "";
            fecha = "";
            monto = "";
            tipo_retiro = "";
            nombre= "";

        }
        public MovimientoModel(int id_cliente, string fecha, string hora, string monto, string tipo_retiro, string nombre)
        {

            this.id_cliente = id_cliente;
            this.hora = hora;
            this.fecha = fecha;
            this.monto = monto;
            this.tipo_retiro = tipo_retiro;
            this.nombre = nombre;

        }

    }
}