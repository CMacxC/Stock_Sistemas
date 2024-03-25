using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Entidades
{
    public class EquiposC
    {
        private Data data = Data.Instance();

        public String Codigo { get; set; }
        public int Marca { get; set; }
        public String Modelo { get; set; }
        public DateTime Fecha_Compra { get; set; }

        public EquiposC() { }

        

    }
}
