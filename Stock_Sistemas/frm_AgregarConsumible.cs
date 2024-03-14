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

namespace Stock_Sistemas
{
    public partial class frm_AgregarConsumible : Form
    {
        public int tipo;
        private int idP;

        public frm_AgregarConsumible(int id)
        {
            InitializeComponent();

            this.idP = id;

            cargarDatos();
        }

        #region Box-Shadow
        private const int WM_NCHITTEST = 0X84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled = false;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        #endregion

        private void cargarDatos()
        {
            if(idP > 0)
            {
                Productos producto = new Productos() { Id_Producto = idP }.getById();

                if(producto != null)
                {
                    txt_Id.Text = idP.ToString();
                    txt_Descripcion.Text = producto.Nombre;
                    txt_Modelo.Text = producto.Modelo;
                    txt_IdMarca.Text = producto.Marca.ToString();
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CatalogoMarcas_Click(object sender, EventArgs e)
        {
            frm_CatalogoMarcas frmCM = new frm_CatalogoMarcas();
            frmCM.ShowDialog();

            txt_IdMarca.Text = frmCM.idM;
            lbl_DescripcionMarca.Text = frmCM.NombreM;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //si tipo es igual a 1
            //entonces se va a inserar un nuevo registro
            if(tipo == 1)
            {
                if(new Productos() { Nombre = txt_Descripcion.Text,
                                     Modelo = txt_Modelo.Text,
                                     Marca = Convert.ToInt32(txt_IdMarca.Text),
                }.Insert() > 0)
                {
                    MessageBox.Show("Producto agregado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            //se actualizara un registro
            else
            {
                if(new Productos()
                {
                    Id_Producto = Convert.ToInt32(txt_Id.Text),
                    Nombre = txt_Descripcion.Text,
                    Modelo = txt_Modelo.Text,
                    Marca = Convert.ToInt32(txt_IdMarca.Text)
                }.Update() > 0)
                {
                    MessageBox.Show("Producto actualizado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AgregarConsumible_Load(object sender, EventArgs e)
        {
            txt_Id.Focus();
        }
    }
}
