
namespace CtaCteProveedores
{
    partial class frMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProvedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesYConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCtaCteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPagos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btCompras = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btEgresos = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btIngresos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.informesYConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraseñaToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // contraseñaToolStripMenuItem
            // 
            this.contraseñaToolStripMenuItem.Name = "contraseñaToolStripMenuItem";
            this.contraseñaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.contraseñaToolStripMenuItem.Text = "Contraseña";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMProvedoresToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // aBMProvedoresToolStripMenuItem
            // 
            this.aBMProvedoresToolStripMenuItem.Image = global::CtaCteProveedores.Properties.Resources.Boss;
            this.aBMProvedoresToolStripMenuItem.Name = "aBMProvedoresToolStripMenuItem";
            this.aBMProvedoresToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aBMProvedoresToolStripMenuItem.Text = "ABM Provedores";
            this.aBMProvedoresToolStripMenuItem.Click += new System.EventHandler(this.aBMProvedoresToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // informesYConsultasToolStripMenuItem
            // 
            this.informesYConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarCtaCteToolStripMenuItem});
            this.informesYConsultasToolStripMenuItem.Name = "informesYConsultasToolStripMenuItem";
            this.informesYConsultasToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.informesYConsultasToolStripMenuItem.Text = "Informes y Consultas";
            // 
            // consultarCtaCteToolStripMenuItem
            // 
            this.consultarCtaCteToolStripMenuItem.Name = "consultarCtaCteToolStripMenuItem";
            this.consultarCtaCteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarCtaCteToolStripMenuItem.Text = "Consultar CtaCte";
            this.consultarCtaCteToolStripMenuItem.Click += new System.EventHandler(this.consultarCtaCteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPagos);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btCompras);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btEgresos);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btIngresos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 483);
            this.panel1.TabIndex = 5;
            // 
            // btPagos
            // 
            this.btPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPagos.Location = new System.Drawing.Point(0, 356);
            this.btPagos.Name = "btPagos";
            this.btPagos.Size = new System.Drawing.Size(145, 59);
            this.btPagos.TabIndex = 7;
            this.btPagos.Text = "Pagos";
            this.btPagos.UseVisualStyleBackColor = true;
            this.btPagos.Click += new System.EventHandler(this.btPagos_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 40);
            this.panel5.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btCompras
            // 
            this.btCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCompras.Location = new System.Drawing.Point(0, 257);
            this.btCompras.Name = "btCompras";
            this.btCompras.Size = new System.Drawing.Size(145, 59);
            this.btCompras.TabIndex = 5;
            this.btCompras.Text = "Compras";
            this.btCompras.UseVisualStyleBackColor = true;
            this.btCompras.Click += new System.EventHandler(this.btCompras_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 40);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btEgresos
            // 
            this.btEgresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEgresos.Location = new System.Drawing.Point(0, 158);
            this.btEgresos.Name = "btEgresos";
            this.btEgresos.Size = new System.Drawing.Size(145, 59);
            this.btEgresos.TabIndex = 3;
            this.btEgresos.Text = "Egresos";
            this.btEgresos.UseVisualStyleBackColor = true;
            this.btEgresos.Visible = false;
            this.btEgresos.Click += new System.EventHandler(this.btEgresos_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 40);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btIngresos
            // 
            this.btIngresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btIngresos.Location = new System.Drawing.Point(0, 59);
            this.btIngresos.Name = "btIngresos";
            this.btIngresos.Size = new System.Drawing.Size(145, 59);
            this.btIngresos.TabIndex = 1;
            this.btIngresos.Text = "Ingresos";
            this.btIngresos.UseVisualStyleBackColor = true;
            this.btIngresos.Visible = false;
            this.btIngresos.Click += new System.EventHandler(this.btIngresos_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 59);
            this.panel3.TabIndex = 0;
            // 
            // pContenedor
            // 
            this.pContenedor.Location = new System.Drawing.Point(210, 81);
            this.pContenedor.Name = "pContenedor";
            this.pContenedor.Size = new System.Drawing.Size(306, 191);
            this.pContenedor.TabIndex = 7;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CtaCteProveedores.Properties.Resources.cuentas_corrientes_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 507);
            this.Controls.Add(this.pContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Corriente Proveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProvedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesYConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCtaCteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btIngresos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pContenedor;
        private System.Windows.Forms.Button btEgresos;
        private System.Windows.Forms.Button btPagos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btCompras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
    }
}

