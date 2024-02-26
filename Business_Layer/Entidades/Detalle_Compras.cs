using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer
{
    public class Detalle_Compras
    {
        public String CFDI { get; set; }
        public String Fecha { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }
        public Double Precio_Unidad { get; set; }
        public Double IVA { get; set; }
        public Double Total { get; set; }

        public Detalle_Compras() { }
    }
}
