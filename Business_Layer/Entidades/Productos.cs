using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public int Marca { get; set; }
        public int Estatus { get; set; }

        public Productos() { }
    }
}
