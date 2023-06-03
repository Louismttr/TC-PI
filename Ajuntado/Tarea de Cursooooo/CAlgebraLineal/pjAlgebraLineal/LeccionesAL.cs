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
    public partial class LeccionesAL : UserControl
    {

       public string CambiarLbl
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image CambiarImagen
        {
            get { return pbImagen.Image; }
            set { pbImagen.Image = value; }
        }


        public LeccionesAL()
        {
            InitializeComponent();
        }

        private void LeccionesAL_Load(object sender, EventArgs e)
        {

        }
    }
}
