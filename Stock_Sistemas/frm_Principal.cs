using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Stock_Sistemas
{
    public partial class frm_Principal : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form frmChild;

        public frm_Principal()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            pMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();

            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 78, 146);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(29, 29, 29);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void openChildForm(Form childForm)
        {
            if(frmChild != null)
            {
                frmChild.Close();
            }

            frmChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pContainer.Controls.Add(childForm);
            pContainer.Tag = childForm;
            frmChild.Location = new System.Drawing.Point((pContainer.Width - frmChild.Width) / 2, (pContainer.Height - frmChild.Height) / 2);
            childForm.BringToFront();
            childForm.Show();
            lbl_TitleChildForm.Text = childForm.Text;
        }



        private void btn_Existencias_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildForm(new frm_Existencias());

        }

        private void btn_Movimientos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openChildForm(new frm_Movimientos());
        }

        private void btn_Materiales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openChildForm(new frm_Materiales());
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            openChildForm(new frm_Reportes());
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmChild.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkSalmon;
            lbl_TitleChildForm.Text = "Inicio";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btn_ResMax.IconChar = IconChar.WindowRestore;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ResMax_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btn_ResMax.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btn_ResMax.IconChar = IconChar.WindowMaximize;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
