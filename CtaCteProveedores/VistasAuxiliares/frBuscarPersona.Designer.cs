
namespace CtaCteProveedores.VistasAuxiliares
{
    partial class frBuscarPersona
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtGridBusqueda = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LRespuesta = new System.Windows.Forms.Label();
            this.LTabla = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBusqueda)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "sugerencia";
            // 
            // dtGridBusqueda
            // 
            this.dtGridBusqueda.AllowUserToAddRows = false;
            this.dtGridBusqueda.AllowUserToDeleteRows = false;
            this.dtGridBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridBusqueda.Location = new System.Drawing.Point(49, 84);
            this.dtGridBusqueda.Name = "dtGridBusqueda";
            this.dtGridBusqueda.ReadOnly = true;
            this.dtGridBusqueda.Size = new System.Drawing.Size(240, 150);
            this.dtGridBusqueda.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.LRespuesta);
            this.panel4.Controls.Add(this.LTabla);
            this.panel4.Controls.Add(this.btAceptar);
            this.panel4.Controls.Add(this.btSalir);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 62);
            this.panel4.TabIndex = 1;
            // 
            // LRespuesta
            // 
            this.LRespuesta.AutoSize = true;
            this.LRespuesta.Location = new System.Drawing.Point(159, 30);
            this.LRespuesta.Name = "LRespuesta";
            this.LRespuesta.Size = new System.Drawing.Size(13, 13);
            this.LRespuesta.TabIndex = 7;
            this.LRespuesta.Text = "0";
            // 
            // LTabla
            // 
            this.LTabla.AutoSize = true;
            this.LTabla.Location = new System.Drawing.Point(82, 30);
            this.LTabla.Name = "LTabla";
            this.LTabla.Size = new System.Drawing.Size(35, 13);
            this.LTabla.TabIndex = 6;
            this.LTabla.Text = "label1";
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.White;
            this.btAceptar.Image = global::CtaCteProveedores.Properties.Resources.Go_forward;
            this.btAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAceptar.Location = new System.Drawing.Point(293, 9);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(164, 50);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Usar Seleccionado";
            this.btAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
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
            this.btSalir.Location = new System.Drawing.Point(725, 0);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 62);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CtaCteProveedores.Properties.Resources.back;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picLoading);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 54);
            this.panel1.TabIndex = 0;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::CtaCteProveedores.Properties.Resources.Loading;
            this.picLoading.Location = new System.Drawing.Point(399, 5);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(57, 48);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 4;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txBuscar);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(76, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 23);
            this.panel2.TabIndex = 3;
            // 
            // txBuscar
            // 
            this.txBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBuscar.Location = new System.Drawing.Point(0, 0);
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.Size = new System.Drawing.Size(232, 19);
            this.txBuscar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txBuscar, "Si esta buscando una persoan: \r\n   Proveedor, Empleado, Cliente: \r\n   puede busca" +
        "r por DNI,CUIT, Nombre,RazonSoc, Apellido");
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 4);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(92)))), ((int)(((byte)(107)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // frBuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridBusqueda);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frBuscarPersona";
            this.Text = "frBuscarPersona";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridBusqueda)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btSalir;
        public System.Windows.Forms.Label LRespuesta;
        public System.Windows.Forms.Label LTabla;
        private System.Windows.Forms.DataGridView dtGridBusqueda;
        private System.Windows.Forms.PictureBox picLoading;
    }
}