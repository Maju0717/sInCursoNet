using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp_Espinoza.Entidades
{
    public class Producto
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double Iva { get; set; }
        //Solo Lectura
        public decimal PrecioBruto { get; set; }
        public decimal PrecioVenta { get; set; }
        //
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }




    }


}
