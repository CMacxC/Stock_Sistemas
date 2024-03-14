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
using Business_Layer.Consultas;

namespace Stock_Sistemas
{
    public partial class frm_Materiales : Form
    {
        private cProductos bissP = new cProductos();
        private Productos bissPe = new Productos();

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
                    int id = Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value);

                    frm_Fondo frmF = new frm_Fondo();
                    frm_AgregarConsumible frmAC = new frm_AgregarConsumible(id);
                    frmAC.lbl_Titulo.Text = "Editar Consumible";
                    frmAC.tipo = 2;
                    frmF.Show();
                    frmAC.ShowDialog();
                    frmF.Close();
                    cargarTabla();
                    break;

                case 6:
                    DialogResult mdg = MessageBox.Show("¿Esta seguro que desea eliminar el producto seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(mdg == DialogResult.Yes)
                    {
                        if(new Productos() { Id_Producto = Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value)}.Delete() > 0)
                        {
                            MessageBox.Show("Registro borrado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarTabla();
                        }
                    }
                    break;
            }
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            cargarTabla();
        }

        private void btn_NuevoMaterial_Click(object sender, EventArgs e)
        {
            frm_AgregarConsumible frmAC = new frm_AgregarConsumible(0);
            frm_Fondo frmF = new frm_Fondo();
            frmAC.lbl_Titulo.Text = "Nuevo consumible";
            frmAC.tipo = 1;
            frmF.Show();
            frmAC.ShowDialog();
            frmF.Close();

            cargarTabla();

        }
    }
}
