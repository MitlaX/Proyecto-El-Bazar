using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto__Final
{
    public partial class FormLogin : Form
    {
        // Contador para llevar la cuenta de intentos de inicio de sesión
        int contIntentos = 0;
        // Id del usuario que intenta iniciar sesión
        long idUsuario;
        // Nombre de usuario que intenta iniciar sesión
        string usuario;

        // Flag para verificar si el usuario fue encontrado o no
        private bool encontrado = false;
        // Cadena de conexión a la base de datos
        string coneccion = "Host=localhost;Database=ElBazar;Username=postgres;Password=root";
        // Flag para mostrar u ocultar la contraseña
        bool mostrar = true;
        public FormLogin()
        {
            InitializeComponent();
        }
        // Método para establecer el saludo de la aplicación basado en la hora del día
        public void Hora() { 
            DateTime time = DateTime.Now;
            DateTime dia = DateTime.Today.AddHours(12D);
            DateTime noche = DateTime.Today.AddHours(20D);
            if (time < dia)
                lblSaludoCLD.Text = "Buenos dias!";
            else if (time < noche)
                lblSaludoCLD.Text = "Buenas tardes!";
            else
                lblSaludoCLD.Text = "Buenas noches!";
        }
        // Método para obtener los datos del empleado por su id
        public ElBazarDataSet.EmpleadoDataTable GetEmpleadoPorId(long idUsuario)
        {
            using (var connection = new NpgsqlConnection(coneccion))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("SELECT * FROM \"Empleado\" WHERE \"Id_usuario\" = @IdUsuario", connection))
                {
                    command.Parameters.AddWithValue("IdUsuario", idUsuario);
                    using (var adapter = new NpgsqlDataAdapter(command))
                    {
                        ElBazarDataSet.EmpleadoDataTable empleadoDataTable = new ElBazarDataSet.EmpleadoDataTable();
                        adapter.Fill(empleadoDataTable);
                        return empleadoDataTable;
                    }
                }
            }
        }
        // Método para verificar si los datos ingresados por el usuario corresponden a un usuario en la base de datos
        public void Comprueba()
        {
            ElBazarDataSet.EmpleadoDataTable empleadoDataTable = empleadoTableAdapter1.GetData();

            if (contIntentos <= 2) // Al tercer intento fallido se bloquea
            {
                for (int i = 0; i < empleadoDataTable.Rows.Count; i++)
                {
                    var renglontabla = empleadoDataTable[i];
                    if (renglontabla.Nombre == tBoxUsuarioCLD.Text && renglontabla.Contraseña.ToString() == tBoxPasswordCLD.Text)
                    {
                        encontrado = true;
                        idUsuario = renglontabla.Id_usuario;
                        usuario = renglontabla.Nombre;
                        break;
                    }
                }
                if (encontrado)
                {
                    contIntentos = 0;
                    Program.nombreUsuario = usuario;
                    Program.Id_Usuario = (int)idUsuario;

                    var empleadoPorIdDataTable = GetEmpleadoPorId(idUsuario);
                    var empleado = empleadoPorIdDataTable[0];
                    Program.rol = empleado.Rol;

                    switch (empleado.Rol)
                    {
                        case "Admin":
                            MessageBox.Show("Bienvenid@ " + usuario, "Administrador");
                            if (Program.formAdministrador == null)
                                Program.formAdministrador = new FormAdministrador();
                            Program.formAdministrador.Show();
                            this.Hide();
                            break;
                        case "Empleado":
                            MessageBox.Show("Bienvenid@ " + usuario, "Empleado ");
                            if (Program.formMenu == null)
                                Program.formMenu = new FormVenta();
                            Program.formMenu.Show();
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    tBoxUsuarioCLD.Clear();
                    tBoxPasswordCLD.Clear();
                    tBoxUsuarioCLD.Focus();
                    MessageBox.Show("Intenta de Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contIntentos++;
                }
            }
            else
            {
                MessageBox.Show("Intentos maximos alcanzados.", "Atencion!", MessageBoxButtons.OK);
                btnLoginCLD.Enabled = false;
            }
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de inicio de sesión
        private void btnLoginCLD_Click(object sender, EventArgs e)
        {
            Comprueba();
        }
        // Método que se ejecuta cuando el usuario hace clic en el botón de salir
        private void btncldSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                Application.Exit();
        }
        // Método que se ejecuta cuando el formulario de inicio de sesión se carga
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Hora();
        }
        // Método que se ejecuta cuando el usuario presiona una tecla en el campo de la contraseña
        private void tBoxPasswordCLD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoginCLD.PerformClick();
            }
        }
        // Método que se ejecuta cuando el usuario hace clic en el icono de mostrar contraseña
        private void pBoxMostrarCCM_Click(object sender, EventArgs e)
        {
           
            if (mostrar)
            {
                tBoxPasswordCLD.PasswordChar = '\0';
                mostrar = false;
            }

            else
            {
                tBoxPasswordCLD.PasswordChar = '*';
                mostrar = true;

            }
                
        }
    }
}

