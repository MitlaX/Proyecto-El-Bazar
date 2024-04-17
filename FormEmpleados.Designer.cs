namespace Proyecto__Final
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_usuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellido_PLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label rolLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.id_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elBazarDataSet = new Proyecto__Final.ElBazarDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellido_PTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.btnBackCLD = new System.Windows.Forms.Button();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new Proyecto__Final.ElBazarDataSetTableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new Proyecto__Final.ElBazarDataSetTableAdapters.TableAdapterManager();
            this.empleadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.empleadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            id_usuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellido_PLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elBazarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).BeginInit();
            this.empleadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            id_usuarioLabel.Location = new System.Drawing.Point(16, 32);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(69, 17);
            id_usuarioLabel.TabIndex = 2;
            id_usuarioLabel.Text = "Id usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            nombreLabel.Location = new System.Drawing.Point(16, 63);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // apellido_PLabel
            // 
            apellido_PLabel.AutoSize = true;
            apellido_PLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            apellido_PLabel.Location = new System.Drawing.Point(16, 94);
            apellido_PLabel.Name = "apellido_PLabel";
            apellido_PLabel.Size = new System.Drawing.Size(70, 17);
            apellido_PLabel.TabIndex = 6;
            apellido_PLabel.Text = "Apellido P:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            contraseñaLabel.Location = new System.Drawing.Point(16, 125);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(77, 17);
            contraseñaLabel.TabIndex = 8;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            rolLabel.Location = new System.Drawing.Point(16, 159);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(30, 17);
            rolLabel.TabIndex = 10;
            rolLabel.Text = "Rol:";
            // 
            // id_usuarioTextBox
            // 
            this.id_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Id_usuario", true));
            this.id_usuarioTextBox.Enabled = false;
            this.id_usuarioTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.id_usuarioTextBox.Location = new System.Drawing.Point(120, 32);
            this.id_usuarioTextBox.Name = "id_usuarioTextBox";
            this.id_usuarioTextBox.Size = new System.Drawing.Size(100, 25);
            this.id_usuarioTextBox.TabIndex = 3;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.elBazarDataSet;
            // 
            // elBazarDataSet
            // 
            this.elBazarDataSet.DataSetName = "ElBazarDataSet";
            this.elBazarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nombreTextBox.Location = new System.Drawing.Point(120, 63);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 25);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras_KeyPress);
            // 
            // apellido_PTextBox
            // 
            this.apellido_PTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Apellido_P", true));
            this.apellido_PTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.apellido_PTextBox.Location = new System.Drawing.Point(120, 94);
            this.apellido_PTextBox.Name = "apellido_PTextBox";
            this.apellido_PTextBox.Size = new System.Drawing.Size(100, 25);
            this.apellido_PTextBox.TabIndex = 7;
            this.apellido_PTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letras_KeyPress);
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadoBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.contraseñaTextBox.Location = new System.Drawing.Point(120, 125);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(100, 25);
            this.contraseñaTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 80;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Id_Usuario",
            "Nombre",
            "Apellido_P",
            "Contraseña",
            "Rol"});
            this.cbBuscar.Location = new System.Drawing.Point(437, 27);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(121, 21);
            this.cbBuscar.TabIndex = 79;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // btnBackCLD
            // 
            this.btnBackCLD.BackColor = System.Drawing.Color.Transparent;
            this.btnBackCLD.BackgroundImage = global::Proyecto__Final.Properties.Resources.Back;
            this.btnBackCLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackCLD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(90)))), ((int)(((byte)(70)))));
            this.btnBackCLD.FlatAppearance.BorderSize = 0;
            this.btnBackCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackCLD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCLD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBackCLD.Location = new System.Drawing.Point(699, 327);
            this.btnBackCLD.Name = "btnBackCLD";
            this.btnBackCLD.Size = new System.Drawing.Size(100, 40);
            this.btnBackCLD.TabIndex = 81;
            this.btnBackCLD.UseVisualStyleBackColor = false;
            this.btnBackCLD.Click += new System.EventHandler(this.btnBackCLD_Click);
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empleadoBindingSource, "Rol", true));
            this.rolComboBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "Empleado",
            "Admin"});
            this.rolComboBox.Location = new System.Drawing.Point(99, 159);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(121, 25);
            this.rolComboBox.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Buscar:";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.Modo_pagoTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.TransaccionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proyecto__Final.ElBazarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadoBindingNavigator
            // 
            this.empleadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadoBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.empleadoBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empleadoBindingNavigator.BindingSource = this.empleadoBindingSource;
            this.empleadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.empleadoBindingNavigator.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.empleadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empleadoBindingNavigatorSaveItem});
            this.empleadoBindingNavigator.Location = new System.Drawing.Point(12, 59);
            this.empleadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadoBindingNavigator.Name = "empleadoBindingNavigator";
            this.empleadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadoBindingNavigator.Size = new System.Drawing.Size(299, 29);
            this.empleadoBindingNavigator.TabIndex = 84;
            this.empleadoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 26);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // empleadoBindingNavigatorSaveItem
            // 
            this.empleadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadoBindingNavigatorSaveItem.Image")));
            this.empleadoBindingNavigatorSaveItem.Name = "empleadoBindingNavigatorSaveItem";
            this.empleadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(26, 26);
            this.empleadoBindingNavigatorSaveItem.Text = "Save Data";
            this.empleadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadoBindingNavigatorSaveItem_Click);
            // 
            // empleadoDataGridView
            // 
            this.empleadoDataGridView.AutoGenerateColumns = false;
            this.empleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.empleadoDataGridView.DataSource = this.empleadoBindingSource;
            this.empleadoDataGridView.Location = new System.Drawing.Point(12, 105);
            this.empleadoDataGridView.Name = "empleadoDataGridView";
            this.empleadoDataGridView.Size = new System.Drawing.Size(546, 262);
            this.empleadoDataGridView.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Apellido_P";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido_P";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Rol";
            this.dataGridViewTextBoxColumn5.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 89;
            this.label3.Text = "Ordenar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(id_usuarioLabel);
            this.groupBox1.Controls.Add(rolLabel);
            this.groupBox1.Controls.Add(this.contraseñaTextBox);
            this.groupBox1.Controls.Add(contraseñaLabel);
            this.groupBox1.Controls.Add(this.rolComboBox);
            this.groupBox1.Controls.Add(this.apellido_PTextBox);
            this.groupBox1.Controls.Add(apellido_PLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.id_usuarioTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(564, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 228);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles:";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(807, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empleadoDataGridView);
            this.Controls.Add(this.empleadoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackCLD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elBazarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingNavigator)).EndInit();
            this.empleadoBindingNavigator.ResumeLayout(false);
            this.empleadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_usuarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellido_PTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Button btnBackCLD;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Label label1;
        private ElBazarDataSet elBazarDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private ElBazarDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private ElBazarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton empleadoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}