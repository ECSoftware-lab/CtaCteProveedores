
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAbmProveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.laIdProveedor = new System.Windows.Forms.Label();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.NProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.laRespAlta = new System.Windows.Forms.Label();
            this.lbFechaAlta = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseProveedoresBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.laIdProveedor);
            this.panel1.Controls.Add(this.txBuscar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 60);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Buscar RazonSocial o CUIT";
            // 
            // laIdProveedor
            // 
            this.laIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIdProveedor.Location = new System.Drawing.Point(97, 12);
            this.laIdProveedor.Name = "laIdProveedor";
            this.laIdProveedor.Size = new System.Drawing.Size(75, 29);
            this.laIdProveedor.TabIndex = 20;
            // 
            // txBuscar
            // 
            this.txBuscar.Location = new System.Drawing.Point(478, 18);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(189, 20);
            this.txBuscar.TabIndex = 0;
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btEliminar);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btAgregar);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btSalir);
            this.panel3.Controls.Add(this.btModificar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 386);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 2, 10, 2);
            this.panel3.Size = new System.Drawing.Size(909, 64);
            this.panel3.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user.png");
            this.imageList1.Images.SetKeyName(1, "user_add.png");
            this.imageList1.Images.SetKeyName(2, "user_delete.png");
            this.imageList1.Images.SetKeyName(3, "user_edit.png");
            this.imageList1.Images.SetKeyName(4, "user_go.png");
            this.imageList1.Images.SetKeyName(5, "door_out.png");
            this.imageList1.Images.SetKeyName(6, "images.png");
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(335, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(42, 60);
            this.panel8.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(782, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(42, 60);
            this.panel7.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(218, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(42, 60);
            this.panel6.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(95, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(42, 60);
            this.panel5.TabIndex = 6;
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
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.AutoGenerateColumns = false;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NProveedor,
            this.RazonSocial,
            this.Cuit,
            this.fechaAlta,
            this.Telefono,
            this.Celular,
            this.Email});
            this.dtgProveedores.DataSource = this.claseProveedoresBindingSource;
            this.dtgProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProveedores.Location = new System.Drawing.Point(0, 0);
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.Size = new System.Drawing.Size(681, 326);
            this.dtgProveedores.TabIndex = 0;
            // 
            // NProveedor
            // 
            this.NProveedor.DataPropertyName = "Idproveedor";
            this.NProveedor.HeaderText = "N Proveedor";
            this.NProveedor.Name = "NProveedor";
            this.NProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial1";
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.DataPropertyName = "FechaAlta1";
            this.fechaAlta.HeaderText = "Fecha Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // claseProveedoresBindingSource
            // 
            this.claseProveedoresBindingSource.DataSource = typeof(CtaCteProveedores.Proveedores.ClaseProveedores);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // laRespAlta
            // 
            this.laRespAlta.AutoSize = true;
            this.laRespAlta.Location = new System.Drawing.Point(12, 300);
            this.laRespAlta.Name = "laRespAlta";
            this.laRespAlta.Size = new System.Drawing.Size(50, 13);
            this.laRespAlta.TabIndex = 18;
            this.laRespAlta.Text = "Res. Alta";
            // 
            // lbFechaAlta
            // 
            this.lbFechaAlta.AutoSize = true;
            this.lbFechaAlta.Location = new System.Drawing.Point(12, 275);
            this.lbFechaAlta.Name = "lbFechaAlta";
            this.lbFechaAlta.Size = new System.Drawing.Size(55, 13);
            this.lbFechaAlta.TabIndex = 17;
            this.lbFechaAlta.Text = "FechaAlta";
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
            this.txEmail.MaxLength = 45;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(127, 20);
            this.txEmail.TabIndex = 15;
            // 
            // txCelular
            // 
            this.txCelular.Location = new System.Drawing.Point(95, 204);
            this.txCelular.MaxLength = 12;
            this.txCelular.Name = "txCelular";
            this.txCelular.Size = new System.Drawing.Size(127, 20);
            this.txCelular.TabIndex = 14;
            this.txCelular.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txTelefono
            // 
            this.txTelefono.Location = new System.Drawing.Point(95, 174);
            this.txTelefono.MaxLength = 12;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.Size = new System.Drawing.Size(127, 20);
            this.txTelefono.TabIndex = 13;
            // 
            // txDomicilio
            // 
            this.txDomicilio.Location = new System.Drawing.Point(95, 143);
            this.txDomicilio.MaxLength = 45;
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
            this.cbProvincia.SelectionChangeCommitted += new System.EventHandler(this.cbProvincia_SelectionChangeCommitted);
            this.cbProvincia.SelectedValueChanged += new System.EventHandler(this.cbProvincia_SelectedValueChanged);
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
            this.label3.Location = new System.Drawing.Point(28, 72);
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
            // button2
            // 
            this.button2.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 6;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(377, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "CargarLogo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.btEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEliminar.ImageIndex = 2;
            this.btEliminar.ImageList = this.imageList1;
            this.btEliminar.Location = new System.Drawing.Point(260, 2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 60);
            this.btEliminar.TabIndex = 9;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregar.BackgroundImage")));
            this.btAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAgregar.ImageIndex = 1;
            this.btAgregar.ImageList = this.imageList1;
            this.btAgregar.Location = new System.Drawing.Point(137, 2);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(81, 60);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.btSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.Color.White;
            this.btSalir.Image = global::CtaCteProveedores.Properties.Resources.Exit;
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalir.Location = new System.Drawing.Point(824, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 60);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btModificar.BackgroundImage")));
            this.btModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btModificar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btModificar.ImageIndex = 3;
            this.btModificar.ImageList = this.imageList1;
            this.btModificar.Location = new System.Drawing.Point(20, 2);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 60);
            this.btModificar.TabIndex = 1;
            this.btModificar.Text = "Modificar";
            this.btModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frAbmProveedores";
            this.Text = "ADMINISTRACION DE PROVEEDORES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseProveedoresBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Label lbFechaAlta;
        private System.Windows.Forms.Label laRespAlta;
        private System.Windows.Forms.Label laIdProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.BindingSource claseProveedoresBindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn NProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Panel panel6;
    }
}