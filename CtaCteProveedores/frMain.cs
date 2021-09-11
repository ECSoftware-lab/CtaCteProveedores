
using CtaCteProveedores.Proveedores;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        frAbmProveedores frPorv;
        private void aBMProvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frPorv == null) {
                MessageBox.Show("nulo ");
            frPorv = new frAbmProveedores();
            frPorv.MdiParent = this;
                frPorv.GIdUsuario = 10;
            frPorv.Show();
                

            }
            else
            {
                MessageBox.Show("no nulo ");
                frPorv.Activate();
            }
        }
    }
}
