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
using System.IO;

namespace pjAlgebraLineal
{
    public partial class fmrSesion : Form
    {
        public fmrSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        private void cB_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Mostrar.Checked == true)
            {
                txtContras.UseSystemPasswordChar = false;
            }
            else
            {
                txtContras.UseSystemPasswordChar = true;
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_Boton_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Ajustar
        private void p_Boton_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fmrSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Boton Registrarse
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarUser = new StreamWriter(@"C:\Users\PC Crossway\Desktop\UNI\II semestre\Programación I\Tarea de Cursooooo\CAlgebraLineal\pjAlgebraLineal\bin" + txtUsuario.Text + ".txt", true);
                RegistrarUser.WriteLine(txtContras.Text);
                RegistrarUser.Close();
                MessageBox.Show("Se ha registrado correctamente", "Bienvendio!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception lEN)
            {
                MessageBox.Show("Hubo un error en..." + lEN , "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
