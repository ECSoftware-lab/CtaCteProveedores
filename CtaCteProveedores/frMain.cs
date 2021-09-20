
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

        public frMain()
        {
            InitializeComponent();
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
            frCtrIngresos ctrEmp = new frCtrIngresos();            
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btEgresos_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            frCtrEgresos ctrEmp = new frCtrEgresos();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btCompras_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            frCtrCompras ctrEmp = new frCtrCompras();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }

        private void btPagos_Click(object sender, EventArgs e)
        {
            CerrarTodosLosHijos();
            ActivarContenedor();
            frCtrPagosProveedor ctrEmp = new frCtrPagosProveedor();
            pContenedor.Controls.Add(ctrEmp);
            ctrEmp.Dock = DockStyle.Fill;
        }
        #endregion

      
    }
}
