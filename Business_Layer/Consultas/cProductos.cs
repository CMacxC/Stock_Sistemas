using System;
using System.Collections.Generic;
using Dapper;
using DataAccess_Layer;

namespace Business_Layer.Consultas
{
    public class cProductos
    {
        private Data data = Data.Instance();

        public int Id_Producto { get; set; }
        public String Nombre { get; set; }
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public int Estatus { get; set; }

        public cProductos() { }

        public IEnumerable<cProductos> getAll()
        {
            var param = new DynamicParameters();
            param.Add("Producto", Nombre);
            return data.Query<cProductos>("stp_Productos_getAll", param);
        }
    }
}
