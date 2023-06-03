using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pjAlgebraLineal.Temas;

namespace pjAlgebraLineal
{
    public partial class fmrLecciones : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public fmrLecciones()
        {
            InitializeComponent();
            CargarTema();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cambiar_Tema
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

            p_Boton.BackColor = themeColor;
            pTitulo.BackColor = themeColor;


            //Botones
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
            foreach (Button button in this.p_For.Controls.OfType<Button>())
            {
                button.FlatAppearance.MouseOverBackColor = themeColor;
                button.FlatAppearance.MouseDownBackColor = lightColor;
            }
        }
        #endregion

        private void leccion_uno_Click(object sender, EventArgs e)
        {
            fmrMatrices matri = new fmrMatrices();
            matri.Show();
        }

        private void leccion_dos_Click(object sender, EventArgs e)
        {
            fmrVectores vec = new fmrVectores();
            vec.Show();
        }
    }
}
