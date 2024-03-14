using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Entidades;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer
{
    public class Productos
    {
        private Data data = Data.Instance();

        public int Id_Producto { get; set; }
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public int Marca { get; set; }
        public int Estatus { get; set; }

        public String DMarca { get; set; }

        public Productos() { }

        public IEnumerable<Productos> getByNombre()
        {
            var param = new DynamicParameters();
            param.Add("Nombre", Nombre);

            return data.Query<Productos>("stp_Productos_getByNombre", param);
        }

        public Productos getById()
        {
            var param = new DynamicParameters();

            param.Add("IdP", Id_Producto);

            return data.QuerySingle<Productos>("stp_Productos_getById", param);
        }

        public int updateEstatus()
        {
            var param = new DynamicParameters();
            param.Add("Id", Id_Producto);
            param.Add("Estatus", Estatus);
            return data.Execute("stp_Productos_updateEstatus", param);
        }
    }
}
