using Business_Layer;
using Stimulsoft.Report;
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
    public partial class frm_Compra : Form
    {
        private Compras compra = new Compras();

        private IEnumerable<Compras> compras;

        public frm_Compra()
        {
            InitializeComponent();

            cargarFechas();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarFechas()
        {
            DateTime fecha = DateTime.Now;

            DateTime dia1 = new DateTime(fecha.Year, fecha.Month, 1);

            DateTime lastDay = dia1.AddMonths(1).AddDays(-1);

            dtp_FechaInicial.Text = dia1.ToString();

            dtp_FechaFinal.Text = lastDay.ToString();
        }

        private void dgv_Compras_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.p_Opciones.ClientRectangle, System.Drawing.Color.Gainsboro, ButtonBorderStyle.Solid);
        }

        private void cargarTablaCompras()
        {
            compra.Fecha1 = dtp_FechaInicial.Value.ToShortDateString();
            compra.Fecha2 = dtp_FechaFinal.Value.ToShortDateString();

            compras = compra.getByFecha();

            if(compras == null)
            {
                comprasBindingSource.DataSource = compras;
            }
            else
            {
                MessageBox.Show("No hay registros en el periodo seleccionado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtp_FechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if(compras != null)
            {
                cargarTablaCompras();
            }
        }

        private void frm_Compra_Load(object sender, EventArgs e)
        {
            cargarTablaCompras();
        }

        private void dtp_FechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (compras != null)
            {
                cargarTablaCompras();
            }
        }
    }
}
