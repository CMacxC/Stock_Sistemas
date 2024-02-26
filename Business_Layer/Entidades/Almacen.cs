using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer
{
    public class Almacen
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public String Para { get; set; }

        public Almacen() { }


    }
}
