using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Sistemas
{
    public partial class frm_Movimientos : Form
    {
        public frm_Movimientos()
        {
            InitializeComponent();

            cargarDatos();

            //cb_Salidas.Checked = true;

            //cargarDatos();

            rd_Salidas.Checked = true;
            
        }

        private void p_Opciones_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.p_Opciones.ClientRectangle, Color.Gainsboro, ButtonBorderStyle.Solid);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
        }

        private void cb_Compras_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
