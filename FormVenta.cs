using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Proyecto__Final
{
    public partial class FormVenta : Form
    {
        private PrintDocument printd;
        private int currentTransactionId; // Almacena el ID de la transacción actual
        public FormVenta()
        {
            InitializeComponent();
            printd = new PrintDocument(); // Crea un nuevo documento para imprimir
            printd.PrintPage += Printd_PrintPage; // Añade el evento PrintPage al documento
        }
        // Al hacer clic en el botón de guardado, este método se encargará de validar y guardar los cambios
        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit(); // Finaliza la edición en curso
            this.tableAdapterManager.UpdateAll(this.elBazarDataSet); // Actualiza todos los cambios en el conjunto de datos

        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            this.ticketTableAdapter.Fill(this.elBazarDataSet.Ticket);
            // TODO: This line of code loads data into the 'elBazarDataSet.Producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.elBazarDataSet.Producto);
            // TODO: This line of code loads data into the 'elBazarDataSet.Transaccion' table. You can move, or remove it, as needed.
            this.transaccionTableAdapter.Fill(this.elBazarDataSet.Transaccion);
            // TODO: This line of code loads data into the 'cafeBDataSet.Transaccion' table. You can move, or remove it, as needed.

            // Establecer etiquetas con los datos del usuario y la fecha actual
            label4.Text = "Usuario: " + Program.nombreUsuario;
            label6.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            NuevaTransaccion();
            ActualizarPrecios();
        }
        // Método de evento para agregar un producto a la lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Habilitar y deshabilitar los botones apropiados
                btnEliminarCLD.Enabled = true;
                btnAgregar.Enabled = false;
                // Limpia el campo de búsqueda y actualiza los datos
                tbBusqueda.Clear();
                Actulizar();
                // Pone el foco en el campo de búsqueda y actualiza los precios
                tbBusqueda.Focus();
                ActualizarPrecios();
            }
            catch (Exception)
            {
                // Si ocurre una excepción, la propagamos
                throw;
            }
        }
        // Método para iniciar una nueva transacción
        public void NuevaTransaccion()
        {
            // Habilitar la caja de texto de búsqueda
            tbBusqueda.Enabled = true;
            // Realiza un clic en el botón de agregar nuevo elemento del navegador de enlace
            bindingNavigatorAddNewItem.PerformClick();
        }
        // Método para actualizar el producto y la lista de tickets
        public void Actulizar()
        {
            // Si hay suficientes existencias, actualiza la cantidad de existencias y agrega un ticket
            if (int.Parse(existenciasTextBox.Text) >= 1)
            {
                existenciasTextBox.Text = (int.Parse(existenciasTextBox.Text) - 1).ToString();
                ticketTableAdapter.Insert(int.Parse(id_transaccionTextBox.Text), int.Parse(id_ProductoTextBox.Text), 1, decimal.Parse(precioTextBox.Text) * 1);
                ticketTableAdapter.Fill(elBazarDataSet.Ticket);
                productoBindingNavigatorSaveItem.PerformClick();

            }
            else
                MessageBox.Show("No hay suficientes existencias");// Muestra un mensaje si no hay suficientes existencias
        }
        // Método para actualizar los precios en las etiquetas
        private void ActualizarPrecios()
        {
            // Si hay elementos en el DataGridView de ticket
            if (ticketDataGridView.RowCount > 0)
            {
                double sutotal = 0;
                foreach (DataGridViewRow row in ticketDataGridView.Rows)
                {
                    // Suma todos los subtotales de los productos en el ticket
                    sutotal += double.Parse(row.Cells["subtotal"].Value.ToString());
                }
                // Calcula el IVA y el total
                double subTotal = sutotal;
                double iva = subTotal * .08;
                double total = subTotal + iva;
                // Muestra los nuevos precios
                lblSubTotalCLD.Text = "$ " + subTotal;
                lblIvaCLD.Text = "$ " + iva;
                lblTotalCLD.Text = "$ " + total;
            }
            else
            {
                // Si no hay elementos, muestra 0 en todos los precios
                lblSubTotalCLD.Text = "$ " + 0;
                lblIvaCLD.Text = "$ " + 0;
                lblTotalCLD.Text = "$ " + 0;
           
            }
        }
        // Método que se dispara cuando se presiona una tecla en el cuadro de búsqueda
        private void tbBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)// Si la tecla presionada es 'Enter'
            {
                
                btnAgregar.Enabled = true;// Habilita el botón de agregar
                                          // Filtra la lista de productos en base al tipo de búsqueda seleccionada
                if (radioButton1.Checked)
                    productoBindingSource.Filter = "CONVERT(Id_Producto, System.String) LiKE '*" + tbBusqueda.Text + "*'";
                else
                    productoBindingSource.Filter = "Nombre LIKE '*" + tbBusqueda.Text + "*'";
            }
        }
        // Método de evento para finalizar una transacción y emitir la factura
        private void btnFacturarCLD_Click(object sender, EventArgs e)
        {
            if (tbCLDMonto.Text == "") // Si el monto introducido está vacío
            {
                MessageBox.Show("Porfavor Introdusca un monto"); // Solicita que se introduzca un monto
            }
            else
            {
                double total = double.Parse(lblTotalCLD.Text.Remove(0, 1)); // Extrae el total actual
                double monto = double.Parse(tbCLDMonto.Text); // Extrae el monto introducido
                if (monto < total) // Si el monto introducido es menor al total
                {
                    MessageBox.Show("El monto es menor al total"); // Informa que el monto introducido es insuficiente
                }
                else
                {
                    // Si el monto introducido es suficiente, continúa con la facturación
                    btnTerminar.Enabled = true; 
                    tbCLDCambio.Text = "$ " + (monto - total); // Calcula y muestra el cambio
                    tbCLDMonto.Clear();
                    transaccionTableAdapter.Insert(Program.Id_Usuario, DateTime.Today, (int)total,null);
                    transaccionTableAdapter.Fill(elBazarDataSet.Transaccion);

                    currentTransactionId = elBazarDataSet.Transaccion.Last().Id_transaccion;

                    NuevaTransaccion();
                    tbBusqueda.Enabled = false;
                    btnFacturarCLD.Enabled = false;
                    // Inicia la vista previa de impresión del recibo
                    PrintPreviewDialog pd = new PrintPreviewDialog();
                    printd.DefaultPageSettings.PaperSize = new PaperSize("Custom Size", 400, 600);
                    pd.Document = printd;
                    pd.ShowDialog();
                }
            }
        }
         // Método para obtener un producto por su ID
        private ElBazarDataSet.ProductoRow GetProductById(int productId)
        {
            foreach (DataRowView productRowView in productoBindingSource.List) // Recorre todos los productos en la lista
            {
                ElBazarDataSet.ProductoRow productRow = productRowView.Row as ElBazarDataSet.ProductoRow; // Obtiene la fila actual
                if (productRow.Id_Producto == productId) // Si el ID del producto de la fila actual coincide con el ID de producto buscado
                {
                    return productRow; // Devuelve el producto encontrado
                }
            }
            return null;
        }
        // Método para la impresión de la página
        private void Printd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Preparación de los elementos gráficos y la fuente
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight();
            float xpos = 10;
            float ypos = 10;

            // Impresión del encabezado
            g.DrawString("Bazar", font, Brushes.Black, xpos, ypos);
            ypos += lineHeight;
            // Filtro temporal para seleccionar solo los tickets de la transacción actual
            string originalFilter = transaccionTicketBindingSource.Filter;
            transaccionTicketBindingSource.Filter = $"Id_transaccion = {currentTransactionId}";
            // Impresión de cada producto en el ticket
            foreach (DataRowView ticketRowView in transaccionTicketBindingSource.List)
            {
                ElBazarDataSet.TicketRow ticketRow = ticketRowView.Row as ElBazarDataSet.TicketRow;
                ElBazarDataSet.ProductoRow productRow = GetProductById(ticketRow.Id_producto);

                if (productRow != null)
                {
                    g.DrawString($"{productRow.Nombre} x {ticketRow.cantidad} : ${ticketRow.Subtotal}", font, Brushes.Black, xpos, ypos);
                    ypos += lineHeight;
                }
            }
            // Impresión del total de la transacción
            g.DrawString($"Total: ${elBazarDataSet.Transaccion.Last().Total} ", font, Brushes.Black, xpos, ypos);
            ypos += lineHeight;
            g.DrawString($"Gracias por tu preferencia. :)", font, Brushes.Black, xpos, ypos);
            // Restauración del filtro original
            transaccionTicketBindingSource.Filter = originalFilter;
        }
        // Manejo de eventos para el botón de salir
        private void btncldSalir_Click(object sender, EventArgs e)
        {
            // Verifica si hay una transacción en curso
            if (ticketDataGridView.Rows.Count > 0)
            {
                // Si hay una transacción en curso, se muestra un mensaje de error
                MessageBox.Show("Porfavor termina la transaccion para poder salir", "Transaccion en progreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {// Si no hay ninguna transacción en curso, se muestra un diálogo de confirmación para salir de la aplicación
                if (MessageBox.Show("Deseas cerrar la aplicacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                {
                    double total = double.Parse(lblTotalCLD.Text.Remove(0, 1));
                    transaccionTableAdapter.Insert(Program.Id_Usuario, DateTime.Today, (int)total,null);
                    Application.Exit();
                }
            }
                
        }
        // Manejo de eventos para el botón de volver
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            // Verifica si hay una transacción en curso
            if (ticketDataGridView.Rows.Count > 0)
            {
                // Si hay una transacción en curso, se muestra un mensaje de error
                MessageBox.Show("Porfavor termina la transaccion para poder salir", "Transaccion en progreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Si no hay ninguna transacción en curso, dependiendo del rol del usuario, se muestra un formulario u otro
            else
            {
                if (Program.rol == "Usuario")
                {
                    if (Program.formLogin == null)
                        Program.formLogin = new FormLogin();
                    Program.formLogin.Show();
                    this.Hide();
                }
                else
                {
                    if (Program.formAdministrador == null)
                        Program.formAdministrador = new FormAdministrador();
                    Program.formAdministrador.Show();
                    this.Hide();
                }
            }
        }
        // Manejo de eventos para el botón de buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se muestra el formulario de búsqueda
            Program.formBuscar = new FormBuscar();
            Program.formBuscar.Show();
        }
        // Manejo de eventos para el botón de eliminar
        private void btnEliminarCLD_Click(object sender, EventArgs e)
        {
            toolStripButton2.PerformClick();
            ActualizarPrecios();
            toolStripButton7.PerformClick();
            this.productoTableAdapter.Fill(this.elBazarDataSet.Producto);
            productoBindingSource.Filter = "CONVERT(Id_Producto, System.String) LiKE '*" + id_productoTextBox1.Text + "*'";
            existenciasTextBox.Text = (int.Parse(existenciasTextBox.Text) + 1).ToString();
            productoBindingNavigatorSaveItem.PerformClick();
        }
        // Manejo de eventos para el botón de guardar
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transaccionTicketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.elBazarDataSet);

        }
        // Manejo de eventos para el botón de terminar
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            tbCLDCambio.Clear(); 
            ActualizarPrecios();
            tbBusqueda.Enabled = true;
            btnFacturarCLD.Enabled = true;
            btnTerminar.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
