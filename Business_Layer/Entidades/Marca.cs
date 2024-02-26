using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Business_Layer
{
    public class Marca
    {
        public int Id_Marca { get; set; }
        public String Descripcion { get; set; }
        public int Activo { get; set; }

        public Marca() { }
    }
}
