using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Salidas
    {
        public int Id_Salida { get; set; }
        public int Folio_Nota { get; set; }
        public int Cantidad { get; set; }
        public int Producto { get; set; }
        public String Fecha_Salida { get; set; }
        public String Recibio { get; set; }
        public String Empresa { get; set; }

        public Salidas() { }

    }
}
