using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace pjAlgebraLineal
{
    public static class Temas
    {
        #region Extra
        public static Color panel_Botones;
        public static Color panel_Titulo;
        public static Color formulario;
        public static Color barra_Busqueda;
        public static Color fuente_A;
        public static Color fuente_B;
        public static Color lecciones;
        public static Color botones_Lecciones;


        //Tema Oscuro
        private static Color panelBoton() => Color.FromArgb(10, 10, 10);
        private static Color panelTitulo() => Color.FromArgb(10, 10, 10);
        private static Color formular() => Color.FromArgb(31,31,31);
        private static Color barraBusqueda() => Color.FromArgb(18,18,18);
        private static Color FuenteA() => Color.White;
        private static Color FuenteB() => Color.Silver;
        private static Color leccione() => Color.FromArgb(10, 10, 10);
       

        //Tema Claro

        private static Color pBoton() => Color.FromArgb(235,235,235);
        private static Color pTitulo() => Color.FromArgb(70,71,117);
        private static Color form() => Color.FromArgb(245,245,245);
        private static Color bBusqueda() => Color.FromArgb(218,218,227);
        private static Color FuentA() => Color.FromArgb(36,36,36);
        private static Color FuentB() => Color.FromArgb(60,60,60);
        private static Color leccion() => Color.White;

        public static void ElegirTema(string tema)
        {
            if (tema.Equals("Oscuro"))
            {
                panel_Botones = panelBoton();
                panel_Titulo = panelTitulo();
                formulario = formular();
                barra_Busqueda = barraBusqueda();
                fuente_A = FuentA();
                fuente_B = FuenteB();
                lecciones = leccione();
            }
            else if(tema.Equals("Claro"))
            {
                panel_Botones = pBoton();
                panel_Titulo = pTitulo();
                formulario = form();
                barra_Busqueda = bBusqueda();
                fuente_A = FuentA();
                fuente_B = FuentB();
                lecciones = leccione();
            }
        }

        #endregion

        public class WinTheme
        {
            //Extern methods
            [DllImport("uxtheme.dll", EntryPoint = "#95")]
            private static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType,
                                                                        bool bIgnoreHighContrast, uint dwHighContrastCacheMode);
            [DllImport("uxtheme.dll", EntryPoint = "#96")]
            private static extern uint GetImmersiveColorTypeFromName(IntPtr pName);
            [DllImport("uxtheme.dll", EntryPoint = "#98")]
            private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);
            //Public methods
            public static Color GetAccentColor()
            {
                var userColorSet = GetImmersiveUserColorSetPreference(false, false);
                var colorType = GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
                var colorSetEx = GetImmersiveColorFromColorSetEx((uint)userColorSet, colorType, false, 0);
                return ConvertDWordColorToRGB(colorSetEx);
            }
            //Private methods
            private static Color ConvertDWordColorToRGB(uint colorSetEx)
            {
                byte redColor = (byte)((0x000000FF & colorSetEx) >> 0);
                byte greenColor = (byte)((0x0000FF00 & colorSetEx) >> 8);
                byte blueColor = (byte)((0x00FF0000 & colorSetEx) >> 16);
                //byte alphaColor = (byte)((0xFF000000 & colorSetEx) >> 24);
                return Color.FromArgb(redColor, greenColor, blueColor);
            }
        }

    }
}
