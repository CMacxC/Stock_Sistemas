using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Consultas
{
    public class cSalidas
    {
        private Data data = Data.Instance();

        public int Folio_Nota { get; set; }
        public int Cantidad { get; set; }
        public String Producto { get; set; }
        public String Modelo { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public String Recibio { get; set; }
        public String Empresa { get; set; }


        public String Fecha1 {get; set; }
        public String Fecha2 { get; set; }

        public cSalidas() { }

        public IEnumerable<cSalidas> getbyFecha()
        {
            var param = new DynamicParameters();
            param.Add("Fecha1", Fecha1);
            param.Add("Fecha2", Fecha2);

            return data.Query<cSalidas>("stp_Salidas_byFecha", param);
        }
    }
}
