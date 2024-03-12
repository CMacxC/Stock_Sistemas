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


        public int Id { get; set; }
        public int Folio_Nota { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public String Fecha_Salida { get; set; }
        public String Recibio { get; set; }
        public String Empresa { get; set; }

        public Salidas() { }

        public int Insert()
        {
            var param = new DynamicParameters();

            param.Add("Nota", Folio_Nota);
            param.Add("Cantidad", Cantidad);
            param.Add("Producto", Producto);
            param.Add("Fecha", Fecha_Salida);
            param.Add("Persona", Recibio);

            return data.Execute("stp_Salidas_Insert", param);
        }
    }
}
