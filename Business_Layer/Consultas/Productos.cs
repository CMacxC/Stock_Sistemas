using System;
using System.Collections.Generic;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Consultas
{
    public class Productos
    {
        private Data data = Data.Instance();

        public int Id_Producto { get; set; }
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Estatus { get; set; }

        public Productos() { }

        public IEnumerable<Productos> getAll()
        {
            var param = new DynamicParameters();
            param.Add("Producto", Nombre);
            return data.Query<Productos>("stp_Productos_getAll", param);
        }
    }
}
