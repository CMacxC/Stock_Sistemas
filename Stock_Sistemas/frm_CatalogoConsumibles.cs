using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Business_Layer.Entidades;

namespace Stock_Sistemas
{
    public partial class frm_CatalogoConsumibles : Form
    {
        private Productos bissP = new Productos();

        public int ClaveM;
        public String Nombre;

        public frm_CatalogoConsumibles()
        {
            InitializeComponent();

            cargarTabla();
        }

        private void cargarTabla()
        {
            bissP.Nombre = txt_Buscar.Text;

            productosBindingSource.DataSource = bissP.getByNombre();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_Buscar.Text != string.Empty)
            {
                cargarTabla();
            }
        }

        private void dgv_Consumibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Consumibles.SelectedRows.Count > 0)
            {
                ClaveM = Convert.ToInt32(dgv_Consumibles.CurrentRow.Cells[0].Value);
                Nombre = dgv_Consumibles.CurrentRow.Cells[1].Value.ToString();

                this.Close();
            }
        }
    }
}
