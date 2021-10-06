
using CtaCteProveedores.Proveedores;
using CtaCteProveedores.vistas;
using System;
using System.Windows.Forms;

namespace CtaCteProveedores
{
    public partial class frMain : Form
    {

        frAbmProveedores frPorv;
        frConsultaCtaCteProv frConsCtaProv;
        frUsuarios frUsu;

        public frMain()
        {
            InitializeComponent();

            CerrarTodosLosHijos();
            ActivarContenedor();
            PaHome ctrEmp = new PaHome();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;

        }

        #region General
        private void CerrarTodosLosHijos()
        {

            //MessageBox.Show("hijos " + this.MdiChildren.Length.ToString());
            for (int x = this.MdiChildren.Length - 1; x >= 0; x--)
            {
               // MessageBox.Show(" H " + x);
                //MessageBox.Show( this.MdiChildren[x].Text);
                this.MdiChildren[x].Close();
            }
        }
        private void DesactivarContenedor()
        {
            pContenedor.Controls.Clear();
            pContenedor.Visible = false;
            
        }

        private void ActivarContenedor()
        {
            pContenedor.Visible = true;
            pContenedor.Controls.Clear();
            pContenedor.Dock = DockStyle.Fill;
        }
        #endregion

        #region MenuSuperior

        #region abmproveedor
        private void aBMProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarContenedor();
            if (frPorv == null)
            {
                frPorv = new frAbmProveedores();
                frPorv.MdiParent = this;
                frPorv.FormClosed += new FormClosedEventHandler(frPorv_FormClosed);
                frPorv.GIdUsuario = 10;
                frPorv.Show();
                frPorv.BringToFront();
            }
            else
            {
                frPorv.Activate();
                frPorv.WindowState = FormWindowState.Maximized;
            }
        }

        private void frPorv_FormClosed(object sender, FormClosedEventArgs e)
        {
            frPorv = null;
            
        }
        #endregion

        #region ConsCtaCteTodos
        private void consultarCtaCteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DesactivarContenedor();

            if (frConsCtaProv == null)
            {
                pContenedor.Controls.Clear();
                pContenedor.Visible = false;
                frConsCtaProv = new frConsultaCtaCteProv();
                frConsCtaProv.FormClosed += new FormClosedEventHandler(frConsCtaProv_FormClosed);

                frConsCtaProv.MdiParent = this;
                frConsCtaProv.Show();

            }
            else
            {

                frConsCtaProv.Activate();
                frConsCtaProv.WindowState = FormWindowState.Maximized;
            }
        }

        private void frConsCtaProv_FormClosed(object sender, FormClosedEventArgs e)
        {
            frConsCtaProv = null;
        }
        #endregion
        #endregion



        #region MenuLateral
        private void btIngresos_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            PaIngresos ctrEmp = new PaIngresos();            
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btEgresos_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            PaEgresos ctrEmp = new PaEgresos();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btCompras_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            PaCompras ctrEmp = new PaCompras();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btPagos_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            PaPagosProveedor ctrEmp = new PaPagosProveedor();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            CerrarTodosLosHijos();
            ActivarContenedor();
            PaHome ctrEmp = new PaHome();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            CerrarTodosLosHijos();
            ActivarContenedor();
            PaEgresos ctrEmp = new PaEgresos();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesactivarContenedor();
            if (frUsu == null)
            {
                frUsu = new frUsuarios();
                frUsu.MdiParent = this;
                frUsu.FormClosed += new FormClosedEventHandler(frUsu_FormClosed);
                frUsu.Show();
                frUsu.BringToFront();
            }
            else
            {
                frUsu.Activate();
                frUsu.WindowState = FormWindowState.Maximized;
            }

        }

        private void frUsu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frUsu = null;
        }
    }
}
