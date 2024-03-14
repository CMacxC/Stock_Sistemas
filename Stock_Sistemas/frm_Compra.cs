using Business_Layer;
using Business_Layer.Entidades;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stock_Sistemas
{
    public partial class frm_Compra : Form
    {
        private int estatus;

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

            if(compras.Count() > 0)
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

        private void txt_NCompra_Click(object sender, EventArgs e)
        {
            frm_NuevaCompra frmNC = new frm_NuevaCompra();
            frm_Fondo frmF = new frm_Fondo();
            frmF.Show();
            frmNC.ShowDialog();
            this.estatus = frmNC.estatus;
            frmF.Close();

            if(estatus == 1)
            {
                cargarTablaCompras();
            }
        }

        private void btn_ImprimirCompras_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes() { Nombre = "Lista_Entradas"}.getByNombre();

            if(reporte == null )
            {
                MessageBox.Show("El reporte seleccionado no existe.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            StiReport stiReporte = new StiReport();
            stiReporte.LoadFromString(reporte.XML);
            stiReporte.ReportName = reporte.Nombre;
            stiReporte.Dictionary.Databases.Clear();
            stiReporte.Dictionary.Databases.Add(new StiSqlDatabase("Almacen Sistemas", DataAccess_Layer.Data.conString));
            stiReporte.Dictionary.Variables.Add(new StiVariable("Fecha1", dtp_FechaInicial.Value.ToShortDateString()));
            stiReporte.Dictionary.Variables.Add(new StiVariable("Fecha2", dtp_FechaFinal.Value.ToShortDateString()));
            stiReporte.Show();
        }
    }
}
