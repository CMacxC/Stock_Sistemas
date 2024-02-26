using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer
{
    public class Compras
    {
        public int Id_Compra { get; set; }
        public String CFDI { get; set; }
        public String Fecha_Compra { get; set; }
        public String Proveedor { get; set; }
        public Double SubTotal { get; set; }
        public Double IVA { get; set; }
        public Double Total { get; set; }

        public Compras() { }
    }
}
