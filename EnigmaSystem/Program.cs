using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSystem
{
    static class Program
    {
        public static string Email;

        public static Panel PanelUsuario;
        public static Panel PanelMaterias;
        public static Panel PanelCarregando;
        public static Form Login;
        public static bool Logoff = false;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }
    }
}
