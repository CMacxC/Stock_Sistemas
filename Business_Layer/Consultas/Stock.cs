using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer.Consultas
{
    public class Stock
    {
        public int Id_Producto { get; set; }
        public String Producto { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Cantidad { get; set; }

        public Stock() { }
    }
}
