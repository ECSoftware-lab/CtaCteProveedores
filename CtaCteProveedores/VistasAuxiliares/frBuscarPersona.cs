using CtaCteProveedores.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.VistasAuxiliares
{
    public partial class frBuscarPersona : Form
    {
        public int salida = 0;
        public frBuscarPersona()
        {
            InitializeComponent();
        }


        private void cargarTabla(string dato)
        {
            // List<ClaseProveedores> lista = new List<ClaseProveedores>();
            if (LTabla.Text == "PROVEEDORES") { 
                 ctrProveedores ctrProv = new ctrProveedores();
                dtGridBusqueda.DataSource = ctrProv.consulta(dato);
            }
        }


        private void btSalir_Click(object sender, EventArgs e)
        {
            this.LRespuesta.Text = salida.ToString();
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
            salida = Convert.ToInt32(dtGridBusqueda.CurrentRow.Cells[0].Value.ToString());            
            this.LRespuesta.Text = salida.ToString();
            this.Close();
        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txBuscar.Text);
        }
    }
}


