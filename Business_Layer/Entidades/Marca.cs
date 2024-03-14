using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer
{
    public class Marca
    {
        private Data data = Data.Instance();

        public int Id_Marca { get; set; }
        public String Descripcion { get; set; }
        public int Activo { get; set; }

        public Marca() { }

        public IEnumerable<Marca> getAll()
        {
            var param = new DynamicParameters();
            param.Add("Marca", Descripcion);
            return data.Query<Marca>("stp_Marca_getAll", param);
        }
    }
}
