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
using static pjAlgebraLineal.Temas;
using Microsoft.Win32;

namespace pjAlgebraLineal
{
    public partial class fmrMenu : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public fmrMenu()
        {
            InitializeComponent();
            CargarTema();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        #region Cambiar_Tema_FMR
        private void Form_Disposed(object? sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {

            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                CargarTema();
            }
        }

        private void CargarTema()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            panel_Botones = themeColor;
            p_Botones.BackColor = themeColor;
            

            //Botones
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
            foreach (Button button in this.p_Menu.Controls.OfType<Button>())
            {
                button.FlatAppearance.MouseOverBackColor = themeColor;
                button.FlatAppearance.MouseDownBackColor = lightColor;
            }
        }
        #endregion


        #region Redimensionar_FMR
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg,
        int wparam, int lparam);

        private void fmrMenu_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }
        #endregion

        #region Botones_fmrMenu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (p_Menu.Width == 250)
            {
                p_Menu.Width = 79;
            }
            else { p_Menu.Width = 250; }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Ajustar_fmr

        private void p_Botones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void p_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fmrMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void p_Contendor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Abrir_Fmr

        private void AbrirFormulario(object formulariohijo)
        {
            if (p_Contendor.Controls.Count > 0)
                this.p_Contendor.Controls.RemoveAt(0);
                Form fH = formulariohijo as Form;
                fH.TopLevel = false;
                fH.Dock = DockStyle.Fill;
                this.p_Contendor.Controls.Add(fH);
                this.p_Contendor.Tag = fH;
                fH.Show();
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmrInicio());
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new fmrLecciones());
        }
        #endregion
    }
}
