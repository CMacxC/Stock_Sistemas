using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer.Consultas;
using Business_Layer.Entidades;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using DataAccess_Layer;

namespace Stock_Sistemas
{
    public partial class frm_Existencias : Form
    {
        private Stock stock = new Stock();
        private Reportes reporte = new Reportes();

        public frm_Existencias()
        {
            InitializeComponent();

            //Cargamos los datos en la tabla
            cargarStock();

            txt_Buscar.Focus();
        }

        private void cargarStock()
        {
            stock.Producto = txt_Buscar.Text;

            IEnumerable<Stock> almacen = stock.getAll();

            if(almacen.Count() > 0)
            {
                stockBindingSource.DataSource = almacen;
            }
        }

        private void dgv_Almacen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                if(Convert.ToInt32(e.Value) <= 1)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(188, 84, 73);

                }
            }
        }

        private void btn_ImprimirReporte_Click(object sender, EventArgs e)
        {
            reporte = new Reportes() { Nombre = "Existencias" }.getByNombre();

            if(reporte == null)
            {
                MessageBox.Show("El reporte no existe o esta dado de baja.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                StiReport stiReporte = new StiReport();
                stiReporte.LoadFromString(reporte.XML);
                stiReporte.ReportName = reporte.Nombre;
                stiReporte.Dictionary.Databases.Clear();
                stiReporte.Dictionary.Databases.Add(new StiSqlDatabase("CpmAlmacen", Data.conString));
                //stiReporte.Dictionary.Variables.Add(new StiVariable("programa"));
                stiReporte.Show();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cargarStock();
        }
    }
}
