using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjAlgebraLineal
{
    public partial class fmrInicio : Form
    {
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            lblHor.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
