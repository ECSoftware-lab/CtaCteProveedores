
namespace CtaCteProveedores.VistasAuxiliares
{
    partial class frCargarImagenes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreImg = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.pBoxImagen = new System.Windows.Forms.PictureBox();
            this.btAccion = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.LIdInterno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Imgen";
            // 
            // txtNombreImg
            // 
            this.txtNombreImg.Location = new System.Drawing.Point(105, 43);
            this.txtNombreImg.Name = "txtNombreImg";
            this.txtNombreImg.Size = new System.Drawing.Size(100, 20);
            this.txtNombreImg.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(83, 251);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // pBoxImagen
            // 
            this.pBoxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxImagen.Location = new System.Drawing.Point(26, 85);
            this.pBoxImagen.Name = "pBoxImagen";
            this.pBoxImagen.Size = new System.Drawing.Size(265, 160);
            this.pBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagen.TabIndex = 3;
            this.pBoxImagen.TabStop = false;
            // 
            // btAccion
            // 
            this.btAccion.Location = new System.Drawing.Point(195, 251);
            this.btAccion.Name = "btAccion";
            this.btAccion.Size = new System.Drawing.Size(96, 23);
            this.btAccion.TabIndex = 4;
            this.btAccion.Text = "Guardar/Actualizar";
            this.btAccion.UseVisualStyleBackColor = true;
            this.btAccion.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // LIdInterno
            // 
            this.LIdInterno.AutoSize = true;
            this.LIdInterno.Location = new System.Drawing.Point(23, 261);
            this.LIdInterno.Name = "LIdInterno";
            this.LIdInterno.Size = new System.Drawing.Size(49, 13);
            this.LIdInterno.TabIndex = 5;
            this.LIdInterno.Text = "IdInterno";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frCargarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LIdInterno);
            this.Controls.Add(this.btAccion);
            this.Controls.Add(this.pBoxImagen);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtNombreImg);
            this.Controls.Add(this.label1);
            this.Name = "frCargarImagenes";
            this.Text = "Carga de Imagenes";
            this.Load += new System.EventHandler(this.frCargarImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreImg;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.PictureBox pBoxImagen;
        private System.Windows.Forms.Button btAccion;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label LIdInterno;
    }
}