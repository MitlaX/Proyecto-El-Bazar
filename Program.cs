using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__Final
{
    internal static class Program
    {
        public static string nombreUsuario;
        public static string rol;
        public static int Id_Usuario;
        public static FormAdministrador formAdministrador = null;
        public static FormLogin formLogin = null;
        public static FormVenta formMenu = null;
        public static FormBuscar formBuscar = null;
        public static FormEmpleados formEmpleados = null;
        public static FormProductos formProductos = null;   
        public static FormTransacciones formTransacciones = null;  
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
