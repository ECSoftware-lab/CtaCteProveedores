using CtaCteProveedores.clases;
using CtaCteProveedores.VistasAuxiliares;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.Proveedores
{
    public partial class frAbmProveedores : Form
    {
        public int GIdUsuario;
        ClaseAuxiliar objAuxiliar = new ClaseAuxiliar();
        public frAbmProveedores()
        {
            InitializeComponent();
            cargarTabla(null);
            cargarProvincias();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btAgregar_Click(object sender, EventArgs e)
        {


            String activo;

            if (chActivo.Checked)
                activo = "SI";
            else
                activo = "NO";

            ClaseProveedores objProveedor = new ClaseProveedores(txRazonSocial.Text, txCuit.Text, cbProvincia.Text
                , cbLocalidad.Text, txDomicilio.Text, txTelefono.Text, txCelular.Text, txEmail.Text, GIdUsuario);

            ctrProveedores ctrlProv = new ctrProveedores();

            if (laIdProveedor.Text != "")
            {
                objProveedor.Idproveedor = int.Parse(laIdProveedor.Text);
                if (ctrlProv.update(objProveedor))
                    MessageBox.Show("Registro actualizado");
            }
            else
            {
                int auxint = ctrlProv.inserta(objProveedor);
                if (auxint != 0)
                {

                    MessageBox.Show("Se Creo el Proveedor N: " + auxint);
                    limpia();
                    cargarTabla(null);
                }
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            int idProv = 0;
            idProv = Convert.ToInt32(dtgProveedores.CurrentRow.Cells["NProveedor"].Value.ToString());
            laIdProveedor.Text = idProv.ToString();

            ClaseProveedores objProveedor = new ClaseProveedores();
            ctrProveedores ctrProv = new ctrProveedores();
             
            ctrProv.DevolverDatos(ref objProveedor, idProv);
            txRazonSocial.Text = objProveedor.RazonSocial1;
            txCuit.Text = objProveedor.Cuit;
            cbProvincia.Text = objProveedor.Provincia;
            cbLocalidad.Text = objProveedor.Localidad;
            txDomicilio.Text = objProveedor.Domicilio;
            txTelefono.Text = objProveedor.Telefono;
            txCelular.Text = objProveedor.Celular;
            txEmail.Text = objProveedor.Email;
            lbFechaAlta.Text = "Fecha Alta " + objProveedor.FechaAlta1;
            laRespAlta.Text = "Responsable N: "+objProveedor.RespAlta1.ToString();
            if (objProveedor.Activo == "SI")
            {
                chActivo.Checked = true;
            }
            else
            {
                chActivo.Checked = true;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*buscar en la tabla */
            string Cuit = "";
            Cuit = txBuscar.Text;

            ctrProveedores objprueba = new ctrProveedores();
            int axuint = objprueba.DevolverId(Cuit);
            laIdProveedor.Text = axuint.ToString();
            return;
                   }



        private void cargarTabla(string dato)
        {
           // List<ClaseProveedores> lista = new List<ClaseProveedores>();
            ctrProveedores ctrProv = new ctrProveedores();
            dtgProveedores.DataSource =  ctrProv.consulta(dato);
        }
        private void cargarProvincias()
        {


            cbProvincia.DataSource = null;
            cbProvincia.Items.Clear();

            cbProvincia.ValueMember = "provincia";
            cbProvincia.DisplayMember = "provincia";
            cbProvincia.DataSource = objAuxiliar.cargarProvincias();

        }
        private void limpia()
        {
            txRazonSocial.Text = "";
            txCuit.Text = "";
            cbProvincia.SelectedItem = 0;
            cbLocalidad.SelectedIndex = 0;
            txDomicilio.Text = "";
            txTelefono.Text = "";
            txCelular.Text = "";
            txEmail.Text = "";
            laIdProveedor.Text = "";
        }

        private void cbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cbLocalidad.DataSource = null;
            cbLocalidad.Items.Clear();

            cbLocalidad.ValueMember = "Localidad";
            cbLocalidad.DisplayMember = "Localidad";



            cbLocalidad.DataSource = objAuxiliar.cargarLocalidades(cbProvincia.SelectedValue.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frCargarImagenes form2 = new frCargarImagenes();
            form2.LIdInterno.Text = "3";
            form2.ShowDialog();

            int aux = 0;
            int.TryParse(form2.LIdInterno.Text, out aux);
            if (aux != 0)
            {
                //** Hay un id de imagen *///
                MessageBox.Show("id imagen " + aux);
            }

        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txBuscar.Text);
        }

    }



}
