using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Consultas
{
    public class cStock
    {
        private Data data = Data.Instance();

        public int Id_Producto { get; set; }
        public String Producto { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Cantidad { get; set; }

        public cStock() { }

        public IEnumerable<cStock> getAll()
        {
            return data.Query<cStock>("stp_Stock_getAll");
        }
    }
}
