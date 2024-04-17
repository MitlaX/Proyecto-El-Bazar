using System;
using System.Windows.Forms;

namespace Proyecto__Final
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }
        // Método que se ejecuta al hacer click en el botón guardar del navegador de binding de empleado
        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos
            if (nombreTextBox.Text == "" || apellido_PTextBox.Text == "" || contraseñaTextBox.Text == "" || rolComboBox.Text == "")
            {
                MessageBox.Show("Porfavor llenar todos lo campos", "Faltan Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.empleadoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.elBazarDataSet);
                }
                catch (Exception)
                {

                    MessageBox.Show("Porfavor Modifica los campos", "El Empleado ingresado ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        // Método que se ejecuta al cargar el formulario de empleados
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            // Este código carga los datos en la tabla 'Empleado'. Puede moverlo o quitarlo según sea necesario.        
            this.empleadoTableAdapter.Fill(this.elBazarDataSet.Empleado);
          

        }
        // Método que se ejecuta cuando el contenido de un cuadro de texto cambia
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filtra los datos del BindingSource de empleado basándose en el contenido del cuadro de texto
            empleadoBindingSource.Filter = "CONVERT(" + cbBuscar.Text + ", System.String) LiKE '*" + textBox1.Text + "*'";
        }
        // Método que se ejecuta cuando el elemento seleccionado en un combobox cambia
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita el cuadro de texto
            textBox1.Enabled = true;
        }
        // Método que se ejecuta al hacer click en el botón de retroceso
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            // Muestra el formulario del administrador y oculta el actual
            Program.formAdministrador = new FormAdministrador();
            Program.formAdministrador.Show();
            this.Hide();
        }
        // Método que se ejecuta al presionar una tecla en el cuadro de texto. Sólo permite caracteres de letra.
        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica que el caracter presionado sea una letra o la tecla de retroceso
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

    }
}
