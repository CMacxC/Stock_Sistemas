using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Sistemas.Utilerias
{
    public class Funciones
    {
        #region Periodo
        public DateTime[] Periodo(DateTime date)
        {
            DayOfWeek day = date.DayOfWeek;
            int diffLunes = DayOfWeek.Monday - day;
            if(diffLunes > 0)
            {
                diffLunes -= 6;
            }
            DateTime lunes = date.AddDays(diffLunes);

            int diffViernes = DayOfWeek.Friday - day;
            if(diffViernes < 0)
            {
                diffViernes += 6; 
            }
            DateTime viernes = date.AddDays(diffViernes);

            var res = new DateTime[2];
            res[0] = lunes;
            res[1] = viernes;

            return res;
        }
        #endregion
    }
}
