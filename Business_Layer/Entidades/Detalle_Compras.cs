using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer
{
    public class Detalle_Compras
    {
        private Data data = Data.Instance();

        public String CFDI { get; set; }
        public DateTime Fecha { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio_Unidad { get; set; }
        public Decimal IVA { get; set; }
        public Decimal Total { get; set; }

        public Detalle_Compras() { }

        public int Insert()
        {
            var param = new DynamicParameters();

            param.Add("Factura", CFDI);
            param.Add("Fecha", Fecha);
            param.Add("Producto", Producto);
            param.Add("Cantidad", Cantidad);
            param.Add("Costo_U", Precio_Unidad);
            param.Add("IVA", IVA);
            param.Add("Total", Total);

            return data.Execute("stp_DetalleCompras_Insert", param);
        }
    }
}
