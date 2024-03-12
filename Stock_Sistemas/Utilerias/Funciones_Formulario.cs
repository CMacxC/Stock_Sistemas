using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Sistemas.Utilerias
{
    public class Funciones_Formulario
    {
        #region Maximizar/Restaurar
        int LY;
        int LX;
        int SH;
        int SW;

        public void Restaurar(Form frm)
        {
            frm.Size = new Size(SW, SH);
            frm.Location = new Point(LX, LY);
        }

        public void Maximizar(Form frm)
        {
            LX = frm.Location.X;
            LY = frm.Location.Y;
            SW = frm.Size.Width;
            SH = frm.Size.Height;

            frm.Size = Screen.PrimaryScreen.WorkingArea.Size;
            frm.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        #endregion
    }
}
