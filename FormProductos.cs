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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        // Método que se ejecuta al hacer clic en el botón guardar del navegador de binding de producto
        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Verifica si todos los campos están llenos antes de guardar
            if (nombreTextBox.Text == "" || precioTextBox.Text == "" || categoriaTextBox.Text == "" || existenciasTextBox.Text == "")
            {
                MessageBox.Show("Porfavor llenar todos lo campos", "Faltan Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.productoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.elBazarDataSet);

                }
                catch (Exception)
                {

                    MessageBox.Show("Porfavor Modifica los campos", "El producto ingresado ya existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Método que se ejecuta al cargar el formulario de productos
        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Este código carga los datos en la tabla 'Producto'. Puede moverlo o quitarlo según sea necesario.
            this.productoTableAdapter.Fill(this.elBazarDataSet.Producto);
        

        }
        // Método que se ejecuta cuando el contenido de textBox1 (cuadro de texto) cambia
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filtra los productos de acuerdo a lo seleccionado en cbBuscar y lo ingresado en textBox1
            productoBindingSource.Filter = "CONVERT("+cbBuscar.Text+", System.String) LiKE '*" + textBox1.Text + "*'";
        }
        // Método que se ejecuta al cambiar la selección en cbBuscar
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita textBox1 cuando se selecciona un ítem en cbBuscar
            textBox1.Enabled = true;
        }
        // Método que se ejecuta al hacer clic en btnBackCLD
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            // Vuelve al formulario de administrador y oculta el formulario actual          
            Program.formAdministrador = new FormAdministrador();
            Program.formAdministrador.Show();
            this.Hide();
        }
        // Método que se ejecuta al presionar una tecla en el campo de texto para los números
        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Asegura que solo se puedan introducir dígitos y teclas de control en el campo de texto
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // Método que se ejecuta al hacer clic en el botón guardar del navegador de binding de producto
        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida, finaliza la edición en curso y actualiza todos los cambios a la base de datos
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    
    }
}
