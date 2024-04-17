using System;
using System.Windows.Forms;

namespace Proyecto__Final
{
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al hacer clic en el botón guardar del navegador de binding de producto
        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Valida, finaliza la edición en curso y actualiza todos los cambios a la base de datos
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elBazarDataSet);

        }
        // Método que se ejecuta al cargar el formulario de búsqueda
        private void FormBuscar_Load(object sender, EventArgs e)
        {
            // Este código carga los datos en la tabla 'Producto'. Puede moverlo o quitarlo según sea necesario.
            this.productoTableAdapter.Fill(this.elBazarDataSet.Producto);

        }
        // Método que se ejecuta cuando el contenido de tbBusqueda (cuadro de texto) cambia
        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            // Si el radioButton1 está seleccionado, filtra los productos por categoría.
            if (radioButton1.Checked)
                productoBindingSource.Filter = "CONVERT(Categoria, System.String) LiKE '*" + tbBusqueda.Text + "*'";
            else // Si no, filtra los productos por nombre.
                productoBindingSource.Filter = "Nombre LIKE '*" + tbBusqueda.Text + "*'";


        }
    }
}
