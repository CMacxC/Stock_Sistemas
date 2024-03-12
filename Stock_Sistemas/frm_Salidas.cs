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

namespace Stock_Sistemas
{
    public partial class frm_Salidas : Form
    {
        private cSalidas bissS = new cSalidas();

        private Funciones func = new Funciones();

        public frm_Salidas()
        {
            InitializeComponent();

            Fechas();

            cargarDatos();
        }

        private void Fechas()
        {
            var fecha = func.Periodo(DateTime.Now);

            dtp_FechaInicial.Text = fecha[0].ToString();
            dtp_FechaFinal.Text = fecha[1].ToString();
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
        }
    }
}
