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

        public Reportes getById()
        {
            var param = new DynamicParameters();
            param.Add("Id", Id_Reporte);
            return data.QuerySingle<Reportes>("stp_Reportes_getById", param);
        }

        public IEnumerable<Reportes> getAll()
        {
            return data.Query<Reportes>("stp_Reportes_getAll");
        }

        public int Insert()
        {
            var param = new DynamicParameters();
            param.Add("Nombre", Nombre);
            param.Add("xml", XML);
            param.Add("Estatus", Estatus);
            return data.Execute("stp_Reportes_Insert", param);
        }

        public int updateEstatus()
        {
            var param = new DynamicParameters();
            param.Add("Estatus", Estatus);
            param.Add("Nombre", Nombre);
            return data.Execute("stp_Reportes_UpdateEstatus", param);
        }

        public int Update()
        {
            var param = new DynamicParameters();

            param.Add("Archivo", XML);
            param.Add("Id", Id_Reporte);
            return data.Execute("stp_Reportes_Update", param);
        }

        public int Delete()
        {
            var param = new DynamicParameters();
            param.Add("Id", Id_Reporte);
            return data.Execute("stp_Reportes_Delete", param);
        }
    }
}
