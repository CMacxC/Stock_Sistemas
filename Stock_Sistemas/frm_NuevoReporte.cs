using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer.Entidades;

namespace Stock_Sistemas
{
    public partial class frm_NuevoReporte : Form
    {
        private Reportes bissR = new Reportes();

        public frm_NuevoReporte()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                if (new Reportes
                {
                    Nombre = txt_Nombre.Text.Trim(),
                    XML = System.IO.File.ReadAllText(txt_Reporte.Text),
                    Estatus = Convert.ToInt32(cb_Check.CheckState)
                }.Insert() > 0)
                {
                    MessageBox.Show("Reporte guardado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el reporte. No se pudo guardar el reporte.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarCampos()
        {
            if(txt_Nombre.Text != string.Empty)
            {
                txt_Nombre.Focus();
                MessageBox.Show("El campo nombre esta vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if(txt_Reporte.Text != string.Empty)
            {
                txt_Reporte.Focus();
                MessageBox.Show("El campo reporte esta vacío", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Archivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_Reporte.Text = fileDialog.FileName;
            }
        }
    }
}
