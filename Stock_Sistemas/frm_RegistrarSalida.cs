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
    public partial class frm_RegistrarSalida : Form
    {
        private Salidas bissS = new Salidas();

        public frm_RegistrarSalida()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Folio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_Cantidad.Focus();
            }
        }

        private void txt_Cantidad_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_ClaveProducto.Focus();
            }
        }

        private void txt_ClaveProducto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dtp_FechaSalida.Focus();
            }
        }

        private void dtp_FechaSalida_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Recibio.Focus();
            }
        }

        private void btn_CatalogoProductos_Click(object sender, EventArgs e)
        {
            frm_CatalogoConsumibles frmCC = new frm_CatalogoConsumibles();
            frmCC.ShowDialog();
            txt_ClaveProducto.Text = Convert.ToString(frmCC.ClaveM);
            txt_DProducto.Text = frmCC.Nombre;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            bissS.Folio_Nota = Convert.ToInt32(txt_Folio.Text);
            bissS.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
            bissS.Producto = Convert.ToInt32(txt_ClaveProducto.Text);
            bissS.Fecha_Salida = dtp_FechaSalida.Value.ToShortDateString();
            bissS.Recibio = txt_Recibio.Text;

            if(bissS.Insert() > 0)
            {
                MessageBox.Show("Salida guardada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
