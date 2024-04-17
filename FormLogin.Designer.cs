namespace Proyecto__Final
{
    partial class FormLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncldSalir = new System.Windows.Forms.Button();
            this.btnLoginCLD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPasswordCLD = new System.Windows.Forms.TextBox();
            this.lblSaludoCLD = new System.Windows.Forms.Label();
            this.pBoxMostrarCLD = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tBoxUsuarioCLD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.empleadoTableAdapter1 = new Proyecto__Final.ElBazarDataSetTableAdapters.EmpleadoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMostrarCLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btncldSalir);
            this.panel1.Controls.Add(this.btnLoginCLD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBoxPasswordCLD);
            this.panel1.Controls.Add(this.lblSaludoCLD);
            this.panel1.Controls.Add(this.pBoxMostrarCLD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.tBoxUsuarioCLD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(80, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 380);
            this.panel1.TabIndex = 5;
            // 
            // btncldSalir
            // 
            this.btncldSalir.BackColor = System.Drawing.Color.SlateBlue;
            this.btncldSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncldSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncldSalir.FlatAppearance.BorderSize = 0;
            this.btncldSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncldSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncldSalir.ForeColor = System.Drawing.Color.White;
            this.btncldSalir.Location = new System.Drawing.Point(241, 301);
            this.btncldSalir.Name = "btncldSalir";
            this.btncldSalir.Size = new System.Drawing.Size(49, 36);
            this.btncldSalir.TabIndex = 21;
            this.btncldSalir.Text = "Salir";
            this.btncldSalir.UseVisualStyleBackColor = false;
            this.btncldSalir.Click += new System.EventHandler(this.btncldSalir_Click);
            // 
            // btnLoginCLD
            // 
            this.btnLoginCLD.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLoginCLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginCLD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCLD.ForeColor = System.Drawing.Color.White;
            this.btnLoginCLD.Location = new System.Drawing.Point(63, 216);
            this.btnLoginCLD.Name = "btnLoginCLD";
            this.btnLoginCLD.Size = new System.Drawing.Size(227, 36);
            this.btnLoginCLD.TabIndex = 10;
            this.btnLoginCLD.Text = "Ingresar";
            this.btnLoginCLD.UseVisualStyleBackColor = false;
            this.btnLoginCLD.Click += new System.EventHandler(this.btnLoginCLD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(33)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // tBoxPasswordCLD
            // 
            this.tBoxPasswordCLD.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxPasswordCLD.Location = new System.Drawing.Point(63, 173);
            this.tBoxPasswordCLD.Margin = new System.Windows.Forms.Padding(10, 1, 10, 10);
            this.tBoxPasswordCLD.Name = "tBoxPasswordCLD";
            this.tBoxPasswordCLD.PasswordChar = '*';
            this.tBoxPasswordCLD.Size = new System.Drawing.Size(227, 30);
            this.tBoxPasswordCLD.TabIndex = 9;
            this.tBoxPasswordCLD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxPasswordCLD_KeyDown);
            // 
            // lblSaludoCLD
            // 
            this.lblSaludoCLD.AutoSize = true;
            this.lblSaludoCLD.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludoCLD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludoCLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(33)))), ((int)(((byte)(17)))));
            this.lblSaludoCLD.Location = new System.Drawing.Point(11, 26);
            this.lblSaludoCLD.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.lblSaludoCLD.Name = "lblSaludoCLD";
            this.lblSaludoCLD.Size = new System.Drawing.Size(112, 21);
            this.lblSaludoCLD.TabIndex = 8;
            this.lblSaludoCLD.Text = "Buenas tardes";
            // 
            // pBoxMostrarCLD
            // 
            this.pBoxMostrarCLD.BackColor = System.Drawing.Color.Transparent;
            this.pBoxMostrarCLD.Image = global::Proyecto__Final.Properties.Resources.Ojo;
            this.pBoxMostrarCLD.Location = new System.Drawing.Point(300, 173);
            this.pBoxMostrarCLD.Margin = new System.Windows.Forms.Padding(0);
            this.pBoxMostrarCLD.Name = "pBoxMostrarCLD";
            this.pBoxMostrarCLD.Size = new System.Drawing.Size(30, 30);
            this.pBoxMostrarCLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxMostrarCLD.TabIndex = 11;
            this.pBoxMostrarCLD.TabStop = false;
            this.pBoxMostrarCLD.Click += new System.EventHandler(this.pBoxMostrarCCM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(33)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(50, 5, 10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Proyecto__Final.Properties.Resources.Password;
            this.pictureBox2.Location = new System.Drawing.Point(13, 163);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Proyecto__Final.Properties.Resources.Usuario;
            this.pictureBox3.Location = new System.Drawing.Point(13, 80);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // tBoxUsuarioCLD
            // 
            this.tBoxUsuarioCLD.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxUsuarioCLD.Location = new System.Drawing.Point(63, 90);
            this.tBoxUsuarioCLD.Margin = new System.Windows.Forms.Padding(10);
            this.tBoxUsuarioCLD.Name = "tBoxUsuarioCLD";
            this.tBoxUsuarioCLD.Size = new System.Drawing.Size(227, 30);
            this.tBoxUsuarioCLD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(33)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(59, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // empleadoTableAdapter1
            // 
            this.empleadoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(503, 404);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        n ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxMostrarCLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncldSalir;
        private System.Windows.Forms.Button btnLoginCLD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPasswordCLD;
        private System.Windows.Forms.Label lblSaludoCLD;
        private System.Windows.Forms.PictureBox pBoxMostrarCLD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tBoxUsuarioCLD;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ElBazarDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter1;
    }
}