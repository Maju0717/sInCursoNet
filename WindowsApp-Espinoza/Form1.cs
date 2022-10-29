using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp_Espinoza.Entidades;


namespace WindowsApp_Espinoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DECLARAR
            ClienteEmpresa ClienteEmp1 = new ClienteEmpresa();
            ClienteIndividuo ClienteIng1 = new ClienteIndividuo();
            Factura Factura1 = new Factura();
            Producto Prod1 = new Producto();
            Proveedor Provee2 = new Proveedor();
            Remito Remitos = new Remito();
            Vendedor Venddor = new Vendedor();



            Prod1.PrecioBruto = Prod1.PrecioCosto + (decimal)(System.Convert.ToDouble(Prod1.Margen));
            Prod1.PrecioVenta = Prod1.PrecioBruto + (decimal)(System.Convert.ToDouble(Prod1.Iva));

            Convert.ToDecimal(1 + Prod1.Iva);





        }
    }
}
