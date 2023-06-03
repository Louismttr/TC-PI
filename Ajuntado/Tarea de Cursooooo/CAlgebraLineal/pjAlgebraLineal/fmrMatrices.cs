using pjAlgebraLineal;
using pjMatiz_1._1;
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
    public partial class fmrMatrices : Form
    {
        public fmrMatrices()
        {
            InitializeComponent();
        }
            

        private void leccionesal1_Load(object sender, EventArgs e)
        {
            frmResta resta = new frmResta();
            resta.Show();
        }

        private void laSuma_Click_1(object sender, EventArgs e)
        {
            frmSuma suma = new frmSuma();
            suma.Show();
        }

        private void laResta_Click(object sender, EventArgs e)
        {
            frmResta suma = new frmResta();
            suma.Show();
        }

        private void laMultiplica_Click(object sender, EventArgs e)
        {
            frmMulti mul = new frmMulti();
            mul.Show();
        }
    }
}
