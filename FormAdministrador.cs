using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__Final
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando el formulario del administrador se carga
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            // Asignar el nombre de usuario al saludo de bienvenida
            lblBienvenidaCLD.Text = "Bienvenid@ " + Program.nombreUsuario;
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de retroceso
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de inicio de sesión y ocultar el actual
            if (Program.formLogin == null)
                Program.formLogin = new FormLogin();
            Program.formLogin.Show();
            this.Hide();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de alimentos
        private void pbAlimentosCLD_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de productos y ocultar el actual
            if (Program.formProductos == null)
                Program.formProductos = new FormProductos();
            Program.formProductos.Show();
            this.Hide();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón del menú
        private void pbMenuCLD_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de venta y ocultar el actual
            if (Program.formMenu == null)
                Program.formMenu = new FormVenta();
            Program.formMenu.Show();
            this.Hide();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de empleados
        private void pbEmpleadosCLD_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de empleados y ocultar el actual
            if (Program.formEmpleados == null)
                Program.formEmpleados = new FormEmpleados();
            Program.formEmpleados.Show();
            this.Hide();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de salir
        private void btncldSalir_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación y cierra la aplicación si el usuario confirma
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                Application.Exit();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de transacciones
        private void pbTransaccionesCLD_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de transacciones y ocultar el actual
            if (Program.formTransacciones == null)
                Program.formTransacciones = new FormTransacciones();
            Program.formTransacciones.Show();
            this.Hide();
        }
    }
}
