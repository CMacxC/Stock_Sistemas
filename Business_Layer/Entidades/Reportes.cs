using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Entidades
{
    public class Reportes
    {
        private Data data = Data.Instance();

        public int Id_Reporte { get; set; }
        public String Nombre { get; set; }
        public String XML { get; set; }
        public int Estatus { get; set; }

        public Reportes() { }

        public Reportes getByNombre()
        {
            var param = new DynamicParameters();
            param.Add("Nombre", Nombre);
            return data.QuerySingle<Reportes>("stp_Reportes_getByName", param);
        }
    }
}
