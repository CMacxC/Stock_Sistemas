using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Business_Layer.Entidades;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace Stock_Sistemas
{
    public partial class frm_Reportes : Form
    {
        private Reportes bissR = new Reportes();

        public frm_Reportes()
        {
            InitializeComponent();

            //ejecutamos el metodo cuando se abre el formulario
            cargarTabla();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarTabla()
        {
            IEnumerable<Reportes> reportes = bissR.getAll();

            //si la consulta tiene registros, mostramos los datos
            if(reportes.Count() > 0)
            {
                reportesBindingSource.DataSource = reportes;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos de la tabla.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_Reportes_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgv_Reportes.IsCurrentCellDirty)
            {
                dgv_Reportes.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_Reportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            DataGridViewRow row = dgv_Reportes.CurrentRow;

            int index = e.ColumnIndex;

            switch(index)
            {
                case 3:
                    if (Convert.ToInt32(row.Cells[3].Value) == 1)
                    {
                        new Reportes { Estatus = 0, Nombre = row.Cells[1].Value.ToString() }.updateEstatus();
                        cargarTabla();
                    }
                    else
                    {
                        new Reportes { Estatus = 1, Nombre = row.Cells[1].Value.ToString() }.updateEstatus();
                        cargarTabla();
                    }
                    break;

                case 4:
                    Reportes reporte = new Reportes() { Id_Reporte = (int)row.Cells[0].Value }.getById();

                    StiReport stiReporte = new StiReport();
                    stiReporte.LoadFromString(reporte.XML);
                    stiReporte.Save(string.Format("{0}\\{1}.mrt", Environment.GetFolderPath(Environment.SpecialFolder.Personal), reporte.Nombre));
                    stiReporte.Load(string.Format("{0}\\{1}.mrt", Environment.GetFolderPath(Environment.SpecialFolder.Personal), reporte.Nombre));
                    stiReporte.Dictionary.Databases.Clear();
                    stiReporte.Dictionary.Databases.Add(new StiSqlDatabase("Inventario Sistemas", DataAccess_Layer.Data.conString));
                    stiReporte.Design();
                    reporte.XML = stiReporte.SaveToString();
                    reporte.Update();
                    break;

                case 5:
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que desea eliminar el reporte seleccionado?", 
                                                             Application.ProductName, 
                                                             MessageBoxButtons.YesNo, 
                                                             MessageBoxIcon.Question);

                    if(resultado == DialogResult.Yes)
                    {
                        if (new Reportes
                        {
                            Id_Reporte = Convert.ToInt32(row.Cells[0].Value)
                        }.Delete() > 0)
                        {
                            MessageBox.Show("Reporte eliminado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error en el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    break;
            }
        }

        private void btn_NuevoReporte_Click(object sender, EventArgs e)
        {
            frm_Fondo frmF = new frm_Fondo();
            frm_NuevoReporte frmNR = new frm_NuevoReporte();
            frmF.Show();
            frmNR.ShowDialog();
            frmF.Close();
            cargarTabla();
        }
    }
}
