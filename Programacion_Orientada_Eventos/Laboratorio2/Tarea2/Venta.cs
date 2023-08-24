using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Orientada_Eventos.Laboratorio2.Tarea2
{

    public class Venta
    {
        public Fruta Fruta { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public Cliente Cliente { get; set; }
    }
}
