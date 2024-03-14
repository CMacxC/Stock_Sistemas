using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Business_Layer.Entidades;
using Business_Layer.Consultas;
using Stock_Sistemas.Utilerias;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace Stock_Sistemas
{
    public partial class frm_Salidas : Form
    {
        private cSalidas bissS = new cSalidas();
        //private Reportes reporte = new Reportes();

        private Funciones func = new Funciones();

        public frm_Salidas()
        {
            InitializeComponent();

            Fechas();

            cargarDatos();
        }

        private void Fechas()
        {
            DateTime fecha = DateTime.Now;

            DateTime dia1 = new DateTime(fecha.Year, fecha.Month, 1);

            DateTime lastDay = dia1.AddMonths(1).AddDays(-1);

            dtp_FechaInicial.Text = dia1.ToString();

            dtp_FechaFinal.Text = lastDay.ToString();
        }

        private void p_Opciones_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.p_Opciones.ClientRectangle, System.Drawing.Color.Gainsboro, ButtonBorderStyle.Solid);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarDatos()
        {
            bissS.Fecha1 = dtp_FechaInicial.Value.ToShortDateString();
            bissS.Fecha2 = dtp_FechaFinal.Value.ToShortDateString();

            cSalidasBindingSource.DataSource = bissS.getbyFecha();
        }

        private void cb_Compras_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            frm_Compra frmc = new frm_Compra();
            frm_Fondo frmF = new frm_Fondo();
            frmF.Show();
            frmc.ShowDialog();
            frmF.Close();
        }

        private void dtp_FechaInicial_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dtp_FechaFinal_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btn_Salidas_Click(object sender, EventArgs e)
        {
            frm_RegistrarSalida frmRS = new frm_RegistrarSalida();
            frm_Fondo frmF = new frm_Fondo();
            frmF.Show();
            frmRS.ShowDialog();
            frmF.Close();
            cargarDatos();
        }

        private void btn_ImprimirMovimiento_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes() { Nombre = "Lista Salidas" }.getByNombre();
            if(reporte == null)
            {
                MessageBox.Show("El reporte no existe.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
