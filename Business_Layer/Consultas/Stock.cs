using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Consultas
{
    public class Stock
    {
        private Data data = Data.Instance();

        public int Id_Producto { get; set; }
        public String Producto { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Cantidad { get; set; }

        public Stock() { }

        public IEnumerable<Stock> getAll()
        {
            return data.Query<Stock>("stp_Stock_getAll");
        }
    }
}
