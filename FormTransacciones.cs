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
    public partial class FormTransacciones : Form
    {
        private PrintDocument printd; // Instancia del objeto PrintDocument para la impresión
        public FormTransacciones()
        {
            InitializeComponent();
            printd = new PrintDocument();
            printd.PrintPage += Printd_PrintPage; // Asigna el evento PrintPage al método Printd_PrintPage
        }
        // Evento click del botón de guardado en el navegador de binding de transacciones
        private void transaccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos antes de guardar
            if (id_usuarioTextBox.Text == "" || totalTextBox.Text == ""|| fechaDateTimePicker.Text=="")
            {
                MessageBox.Show("Porfavor llenar todos lo campos", "Faltan Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.transaccionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.elBazarDataSet);
            }

        }
        // Evento de carga del formulario de transacciones
        private void FormTransacciones_Load(object sender, EventArgs e)
        {
            // Este código carga los datos en las tablas 'Ticket' y 'Transaccion'. Puede moverlo o quitarlo según sea necesario.
            
            this.ticketTableAdapter.Fill(this.elBazarDataSet.Ticket);
           
            this.transaccionTableAdapter.Fill(this.elBazarDataSet.Transaccion);
        }
        // Evento de cambio de selección en cbBuscar
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filtra las transacciones de acuerdo a lo seleccionado en cbBuscar y lo ingresado en textBox1
            transaccionBindingSource.Filter = "CONVERT(" + cbBuscar.Text + ", System.String) LiKE '*" + textBox1.Text + "*'";
        }
        // Evento de cambio de selección en cbBuscar
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita textBox1 cuando se selecciona un ítem en cbBuscar
            textBox1.Enabled = true;
        }
        // Evento click del botón btnBackCLD
        private void btnBackCLD_Click(object sender, EventArgs e)
        {
            // Vuelve al formulario de administrador y oculta el formulario actual
            Program.formAdministrador = new FormAdministrador();
            Program.formAdministrador.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Filtra los tickets de acuerdo a lo seleccionado en comboBox1 y lo ingresado en textBox2
            ticketBindingSource1.Filter = "CONVERT(" + comboBox1.Text + ", System.String) LiKE '*" + textBox2.Text + "*'";
        }
        // Evento de cambio de selección en comboBox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita textBox2 cuando se selecciona un ítem en comboBox1
            textBox2.Enabled = true;
        }
        // Evento de presión de tecla en un cuadro de texto para números
        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Asegura que solo se puedan introducir dígitos y teclas de control en el cuadro de texto
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos antes de guardar
            if (id_transaccionTextBox1.Text == "" || id_productoTextBox.Text == "" || cantidadTextBox.Text == "" || subtotalTextBox.Text == "")
            {
                MessageBox.Show("Porfavor llenar todos lo campos", "Faltan Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.ticketBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.elBazarDataSet);
            }

        }
        // Método para obtener un producto por su Id
        private ElBazarDataSet.ProductoRow GetProductById(int productId)
        {
            // Recorre todos los productos y devuelve aquel con el Id solicitado
            foreach (DataRowView productRowView in productoBindingSource.List)
            {
                ElBazarDataSet.ProductoRow productRow = productRowView.Row as ElBazarDataSet.ProductoRow;
                if (productRow.Id_Producto == productId)
                {
                    return productRow;
                }
            }
            return null;
        }
        // Evento PrintPage del objeto PrintDocument
        private void Printd_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Genera la salida de la impresión de las transacciones
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight();
            float xpos = 10;
            float ypos = 10;

            g.DrawString("Bazar", font, Brushes.Black, xpos, ypos);
            ypos += lineHeight;

            foreach (DataRowView ticketRowView in ticketBindingSource.List)
            {
                ElBazarDataSet.TicketRow ticketRow = ticketRowView.Row as ElBazarDataSet.TicketRow;
                ElBazarDataSet.ProductoRow productRow = GetProductById(ticketRow.Id_producto);

                if (productRow != null)
                {
                    g.DrawString($"{productRow.Nombre} x {ticketRow.cantidad} : ${ticketRow.Subtotal}", font, Brushes.Black, xpos, ypos);
                    ypos += lineHeight;
                }
            }

            g.DrawString($"Total: ${totalTextBox.Text}", font, Brushes.Black, xpos, ypos);
            ypos += lineHeight;
            g.DrawString($"Gracias por tu preferencia. :)", font, Brushes.Black, xpos, ypos);
        }
        // Evento click del botón btnImprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Configura las opciones de impresión y muestra la vista previa de impresión
            printd.DefaultPageSettings.PaperSize = new PaperSize("Custom Size", 400, 600);
            PrintPreviewDialog pd = new PrintPreviewDialog();
            pd.Document = printd;
            pd.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

