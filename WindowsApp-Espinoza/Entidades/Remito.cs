using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp_Espinoza.Entidades
{
    public class Remito
    {
        public String Numero { get; set; }
        public DateTime Fecha { get; set; }
        public String Cliente { get; set; }
        public String Direccion { get; set; }
        public String CondicionIVA { get; set; }
        public String CondicionVenta { get; set; }
        public String Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Total { get; set; }
    }
}
