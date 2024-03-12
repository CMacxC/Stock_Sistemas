using Stock_Sistemas.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Sistemas
{
    public partial class frm_Fondo : Form
    {

        private Funciones_Formulario frm = new Funciones_Formulario();

        public frm_Fondo()
        {
            InitializeComponent();

            frm.Maximizar(this);
        }
    }
}
