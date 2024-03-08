using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer
{
    public class Salidas
    {
        private Data data = Data.Instance();


        public int Id_Salida { get; set; }
        public int Folio_Nota { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public String Fecha_Salida { get; set; }
        public String Recibio { get; set; }
        public String Empresa { get; set; }
        public int Tipo { get; set; }

        public String Fecha1 { get; set; }
        public String Fecha2 { get; set; }

        public Salidas() { }

        public IEnumerable<Salidas> ByFecha()
        {
            var param = new DynamicParameters();
            param.Add("Fecha1", Fecha1);
            param.Add("Fecha2", Fecha2);
            param.Add("Tipo", Tipo);

            return data.Query<Salidas>("stp_Salidas_byFecha", param);

        }
    }
}
