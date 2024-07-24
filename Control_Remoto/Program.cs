using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Control_Remoto
{
    static class Program
    {                    
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          
            Application.Run(new Sistema_Vision());
            
            
        }

        public static IniFile.Ini IniSettings = new IniFile.Ini(Directory.GetCurrentDirectory() + "\\Settings\\Settings.ini");
        public static IniFile.Ini settings = IniSettings;
        //Datos para sacar usuario del archivo settings
        public static string usuario = settings.IniReadValue("Parametros", "usuario");
        public static string contrasena = settings.IniReadValue("Parametros", "contrasena");

        //public static string stingray = settings.IniReadValue("Settings", "Modelos0");//guarda en variable publica stingray la receta del modelo 8M2101000
        //public static string greatwhite = settings.IniReadValue("Settings", "Modelos1");//guarda en variable publica greatwhite la receta del modelo 8M2100843
               

    }
}
