using CtaCteProveedores.Proveedores;
using CtaCteProveedores.VistasAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.vistas
{
    public partial class frCtrCompras : UserControl
    {
        ctrProveedores objPrveedor;
        public frCtrCompras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Text = "";
            frBuscarPersona form2 = new frBuscarPersona();
            form2.LTabla.Text = "PROVEEDORES";
            form2.ShowDialog();

            int aux = 0;
            int.TryParse(form2.LRespuesta.Text, out aux);
            if (aux != 0)
            {
                txtIdProveedor.Text = aux.ToString();
                //MessageBox.Show("idrespuesta " + aux);
            }
        }

        private void frCtrCompras_Load(object sender, EventArgs e)
        {
            objPrveedor = new ctrProveedores();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            LRazonSocial.Text = "";
            if (!string.IsNullOrEmpty(txtIdProveedor.Text)) {

                LRazonSocial.Text = objPrveedor.DevolverRazonSoc(int.Parse(txtIdProveedor.Text));
                    
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
