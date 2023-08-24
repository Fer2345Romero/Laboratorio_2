using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Orientada_Eventos.Laboratorio2.Tarea2
{
    public class Fruta
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }


        public override string ToString()
        {
            return $"{Nombre}  {Precio:C}";
        }
    }

}
