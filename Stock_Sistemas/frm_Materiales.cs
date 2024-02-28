using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Stock_Sistemas
{
    public partial class frm_Materiales : Form
    {
        private Business_Layer.Consultas.Productos bissP = new Business_Layer.Consultas.Productos();
        private Business_Layer.Productos bissPe = new Business_Layer.Productos();

        public frm_Materiales()
        {
            InitializeComponent();

            cargarTabla();
        }

        private void cargarTabla()
        {
            bissP.Nombre = txt_Buscar.Text;

            productosBindingSource.DataSource = bissP.getAll();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgv_Productos.IsCurrentCellDirty)
            {
                dgv_Productos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dgv_Productos.CurrentRow;

            int indexC = e.ColumnIndex;

            switch(indexC)
            {
                case 4:
                    if (Convert.ToInt32(row.Cells[4].Value) == 1)
                    {
                        new Productos { Id_Producto = Convert.ToInt32(row.Cells[0].Value), Estatus = 0 }.updateEstatus();
                        cargarTabla();
                    }
                    else
                    {
                        new Productos { Id_Producto = Convert.ToInt32(row.Cells[0].Value), Estatus = 1 }.updateEstatus();
                        cargarTabla();
                    }
                    break;

                case 5:
                    frm_AgregarConsumible frmAC = new frm_AgregarConsumible();
                    frmAC.lbl_Titulo.Text = "Editar Consumible";
                    frmAC.Show();
                    break;
            }
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cargarTabla();
        }

        private void btn_NuevoMaterial_Click(object sender, EventArgs e)
        {
            frm_AgregarConsumible frmAC = new frm_AgregarConsumible();
            frm_Fondo frmF = new frm_Fondo();
            frmAC.lbl_Titulo.Text = "Nuevo consumible";
            frmF.Show();
            frmAC.ShowDialog();
            frmF.Close();

        }
    }
}
