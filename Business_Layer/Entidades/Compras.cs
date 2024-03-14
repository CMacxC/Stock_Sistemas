using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer
{
    public class Compras
    {
        private Data data = Data.Instance();

        public int Id_Compra { get; set; }
        public String CFDI { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public String Proveedor { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal IVA { get; set; }
        public Decimal Total { get; set; }

        public String Fecha1 { get; set; }
        public String Fecha2 { get; set; }

        public Compras() { }

        public IEnumerable<Compras> getByFecha()
        {
            var param = new DynamicParameters();
            param.Add("Fecha1", Fecha1);
            param.Add("Fecha2", Fecha2);

            return data.Query<Compras>("stp_ReporteCompras_getByFecha", param);
        }

        public int Insert()
        {
            var param = new DynamicParameters();

            param.Add("Factura", CFDI);
            param.Add("Fecha", Fecha_Compra);
            param.Add("Proveedor", Proveedor);
            param.Add("SubTotal", SubTotal);
            param.Add("IVA", IVA);
            param.Add("Total", Total);

            return data.Execute("stp_Compras_Insert", param);
        }
    }
}
