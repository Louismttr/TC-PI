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
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);


        #region Datos_Entrada

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
               txtUsuario.Text = " ";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContras_Enter(object sender, EventArgs e)
        {
            if (txtContras.Text == "Contraseña")
            {
                txtContras.Text = " ";
                txtContras.ForeColor = Color.LightGray;
                txtContras.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == " ")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContras_Leave(object sender, EventArgs e)
        {
            if (txtContras.Text == "")
            {
                txtContras.Text = "Contraseña";
                txtContras.ForeColor = Color.DimGray;
                txtContras.UseSystemPasswordChar = false;
            }
        }

        private void cbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrar.Checked == true)
            {
                txtContras.UseSystemPasswordChar = false;
            }
            else
            {
                txtContras.UseSystemPasswordChar = true;
            }
        }
        #endregion


        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Buscar y entrar en la app
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            fmrSesion abrir = new fmrSesion();
            abrir.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Buscando al archivo...
            try
            {
                TextReader inicio = new StreamReader(txtUsuario.Text + ".txt");
                if (inicio.ReadLine() == txtContras.Text)
                {
                    fmrMenu abri = new fmrMenu();
                    abri.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sección, intente nuevamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception len)
            {
                MessageBox.Show("No se pudo iniciar sección, intente nuevamente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fmrMenu abri = new fmrMenu();
                abri.ShowDialog();
            }
        }
        #endregion

        #region Ajustar_FMR

        private void p_Logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void p_Botones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fmrLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
