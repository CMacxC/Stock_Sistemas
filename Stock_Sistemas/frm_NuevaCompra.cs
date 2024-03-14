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
    public partial class frm_NuevaCompra : Form
    {
        //Business Layer
        private Productos producto = new Productos();

        //Variables
        private Decimal sumas = 0;
        private Decimal sumai = 0;
        private Decimal sumat = 0;

        public frm_NuevaCompra()
        {
            InitializeComponent();


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

        private void btn_Cerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Lista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Lista.RowCount == 0)
            {
                return;
            }

            if (e.ColumnIndex == 1)
            {
                if (dgv_Lista.CurrentRow.Cells[1].Value == null)
                {

                }
                else
                {
                    Productos producto = new Productos() { Id_Producto = Convert.ToInt32(dgv_Lista.CurrentRow.Cells[1].Value) }.getById();

                    if (producto != null)
                    {
                        dgv_Lista.CurrentRow.Cells[2].Value = producto.Nombre;
                        dgv_Lista.CurrentRow.Cells[3].Value = producto.Modelo;
                    }
                }
            }
            else if (e.ColumnIndex == 4)
            {
                Decimal costoUnitario = Convert.ToDecimal(dgv_Lista.CurrentRow.Cells[4].Value.ToString());
                int cantidad = Convert.ToInt32(dgv_Lista.CurrentRow.Cells[0].Value.ToString());
                
                Decimal totalImporte = costoUnitario * cantidad;
                Decimal _iva = (totalImporte * new decimal(1.16)) - totalImporte;

                dgv_Lista.CurrentRow.Cells[5].Value = _iva;
                dgv_Lista.CurrentRow.Cells[6].Value = totalImporte;

                sumas += totalImporte;
                sumai += Convert.ToDecimal(dgv_Lista.CurrentRow.Cells[5].Value);
                sumat += (Convert.ToDecimal(dgv_Lista.CurrentRow.Cells[6].Value) + Convert.ToDecimal(dgv_Lista.CurrentRow.Cells[5].Value));

                dgv_Lista.Columns[4].DefaultCellStyle.Format = "C2";
                lbl_SubTotal.Text = sumas.ToString("C");
                lbl_TotalIVA.Text = sumai.ToString("C");
                lbl_TotalImporte.Text = sumat.ToString("C");
            }
        }

        private void txt_Factura_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                txt_Fecha.Focus();
            }
        }

        private void txt_Fecha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                txt_Proveedor.Focus();
            }
        }

        private void txt_Proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode.Equals(Keys.Enter))
            {
                dgv_Lista.Rows.Insert(0);
                dgv_Lista.Focus();
            }
        }

        private void dgv_Lista_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                dgv_Lista.Rows.Add();
            }
        }

        private void p_Totales_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.p_Totales.ClientRectangle, System.Drawing.Color.WhiteSmoke, ButtonBorderStyle.Solid);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                char[] moneda = { '$' };

                if (new Compras()
                {
                    CFDI = txt_Factura.Text,
                    Fecha_Compra = Convert.ToDateTime(txt_Fecha.Text),
                    Proveedor = txt_Proveedor.Text,
                    SubTotal = Convert.ToDecimal(lbl_SubTotal.Text.TrimStart(moneda)),
                    IVA = Convert.ToDecimal(lbl_TotalIVA.Text.TrimStart(moneda)),
                    Total = Convert.ToDecimal(lbl_TotalImporte.Text.TrimStart(moneda))
                }.Insert() > 0)
                {
                    foreach (DataGridViewRow row in dgv_Lista.Rows)
                    {
                        new Detalle_Compras() { CFDI = txt_Factura.Text,
                            Fecha = Convert.ToDateTime(txt_Fecha.Text),
                            Producto = Convert.ToInt32(row.Cells[1].Value),
                            Cantidad = Convert.ToInt32(row.Cells[0].Value),
                            Precio_Unidad = Convert.ToDecimal(row.Cells[4].Value.ToString().TrimStart(moneda)),
                            IVA = Convert.ToDecimal(row.Cells[5].Value.ToString().TrimStart(moneda)),
                            Total = Convert.ToDecimal(row.Cells[6].Value.ToString().TrimStart(moneda))
                        }.Insert();
                    }

                    MessageBox.Show("Compra guardada.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error durante el proceso. No se guardaron todos los registros.\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
