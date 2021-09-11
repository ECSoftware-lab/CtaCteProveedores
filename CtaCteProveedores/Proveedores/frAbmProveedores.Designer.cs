
namespace CtaCteProveedores.Proveedores
{
    partial class frAbmProveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txCelular = new System.Windows.Forms.TextBox();
            this.txTelefono = new System.Windows.Forms.TextBox();
            this.txDomicilio = new System.Windows.Forms.TextBox();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFechaAlta = new System.Windows.Forms.Label();
            this.laRespAlta = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.laIdProveedor = new System.Windows.Forms.Label();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.claseProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseProveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laIdProveedor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btSalir);
            this.panel3.Controls.Add(this.btEliminar);
            this.panel3.Controls.Add(this.btModificar);
            this.panel3.Controls.Add(this.btAgregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 64);
            this.panel3.TabIndex = 2;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(776, 26);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(348, 19);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(238, 16);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(123, 13);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.laRespAlta);
            this.panel2.Controls.Add(this.lbFechaAlta);
            this.panel2.Controls.Add(this.chActivo);
            this.panel2.Controls.Add(this.txEmail);
            this.panel2.Controls.Add(this.txCelular);
            this.panel2.Controls.Add(this.txTelefono);
            this.panel2.Controls.Add(this.txDomicilio);
            this.panel2.Controls.Add(this.cbLocalidad);
            this.panel2.Controls.Add(this.cbProvincia);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txCuit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txRazonSocial);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 326);
            this.panel2.TabIndex = 3;
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Checked = true;
            this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chActivo.Location = new System.Drawing.Point(95, 256);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(56, 17);
            this.chActivo.TabIndex = 16;
            this.chActivo.Text = "Activo";
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(95, 230);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(127, 20);
            this.txEmail.TabIndex = 15;
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(95, 204);
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(127, 20);
            this.txCelular.TabIndex = 14;
            this.txCelular.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(95, 174);
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(127, 20);
            this.txTelefono.TabIndex = 13;
            // 
            // txDomicilio
            // 
            this.txDomicilio.Location = new System.Drawing.Point(95, 143);
            this.txDomicilio.Name = "txDomicilio";
            this.txDomicilio.Size = new System.Drawing.Size(127, 20);
            this.txDomicilio.TabIndex = 12;
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Items.AddRange(new object[] {
            "San Miguel de Tucuman",
            "Las Talitas",
            "Once"});
            this.cbLocalidad.Location = new System.Drawing.Point(95, 103);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cbLocalidad.TabIndex = 11;
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "Tucuman",
            "BsAs",
            "CABA",
            "Cordoba",
            "Santa Fe"});
            this.cbProvincia.Location = new System.Drawing.Point(95, 64);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cbProvincia.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Domicilio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Provincia";
            // 
            // txCuit
            // 
            this.txCuit.Location = new System.Drawing.Point(95, 38);
            this.txCuit.Name = "txCuit";
            this.txCuit.Size = new System.Drawing.Size(127, 20);
            this.txCuit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "C.U.I.T.";
            // 
            // txRazonSocial
            // 
            this.txRazonSocial.Location = new System.Drawing.Point(95, 12);
            this.txRazonSocial.Name = "txRazonSocial";
            this.txRazonSocial.Size = new System.Drawing.Size(127, 20);
            this.txRazonSocial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RazonSocial";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgProveedores);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(228, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 326);
            this.panel4.TabIndex = 4;
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(321, 21);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(100, 20);
            this.txBuscar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbFechaAlta
            // 
            this.lbFechaAlta.AutoSize = true;
            this.lbFechaAlta.Location = new System.Drawing.Point(17, 275);
            this.lbFechaAlta.Name = "lbFechaAlta";
            this.lbFechaAlta.Size = new System.Drawing.Size(55, 13);
            this.lbFechaAlta.TabIndex = 17;
            this.lbFechaAlta.Text = "FechaAlta";
            // 
            // laRespAlta
            // 
            this.laRespAlta.AutoSize = true;
            this.laRespAlta.Location = new System.Drawing.Point(17, 297);
            this.laRespAlta.Name = "laRespAlta";
            this.laRespAlta.Size = new System.Drawing.Size(50, 13);
            this.laRespAlta.TabIndex = 18;
            this.laRespAlta.Text = "Res. Alta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "N Proveedor";
            // 
            // laIdProveedor
            // 
            this.laIdProveedor.AutoSize = true;
            this.laIdProveedor.Location = new System.Drawing.Point(97, 23);
            this.laIdProveedor.Name = "laIdProveedor";
            this.laIdProveedor.Size = new System.Drawing.Size(50, 13);
            this.laIdProveedor.TabIndex = 20;
            this.laIdProveedor.Text = "Res. Alta";
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.AutoGenerateColumns = false;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.razonSocial1DataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.fechaAlta1DataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dtgProveedores.DataSource = this.claseProveedoresBindingSource;
            this.dtgProveedores.Location = new System.Drawing.Point(22, 20);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.Size = new System.Drawing.Size(647, 290);
            this.dtgProveedores.TabIndex = 0;
            // 
            // claseProveedoresBindingSource
            // 
            this.claseProveedoresBindingSource.DataSource = typeof(CtaCteProveedores.Proveedores.ClaseProveedores);
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "Idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "Idproveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razonSocial1DataGridViewTextBoxColumn
            // 
            this.razonSocial1DataGridViewTextBoxColumn.DataPropertyName = "RazonSocial1";
            this.razonSocial1DataGridViewTextBoxColumn.HeaderText = "RazonSocial1";
            this.razonSocial1DataGridViewTextBoxColumn.Name = "razonSocial1DataGridViewTextBoxColumn";
            this.razonSocial1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "Cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            this.cuitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAlta1DataGridViewTextBoxColumn
            // 
            this.fechaAlta1DataGridViewTextBoxColumn.DataPropertyName = "FechaAlta1";
            this.fechaAlta1DataGridViewTextBoxColumn.HeaderText = "FechaAlta1";
            this.fechaAlta1DataGridViewTextBoxColumn.Name = "fechaAlta1DataGridViewTextBoxColumn";
            this.fechaAlta1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frAbmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frAbmProveedores";
            this.Text = "frAbmProveeores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseProveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txCelular;
        private System.Windows.Forms.TextBox txTelefono;
        private System.Windows.Forms.TextBox txDomicilio;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Label lbFechaAlta;
        private System.Windows.Forms.Label laRespAlta;
        private System.Windows.Forms.Label laIdProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.BindingSource claseProveedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}