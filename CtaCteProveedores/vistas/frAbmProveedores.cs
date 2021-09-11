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

namespace CtaCteProveedores.Proveedores
{
    public partial class frAbmProveedores : Form
    {
        public int GIdUsuario;
        public frAbmProveedores()
        {
            InitializeComponent();
            cargarTabla(null);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {


            //int idproveedor = 0;
            String RazonSocial,  Cuit;
            String provincia, localidad, domicilio;
            String telefono, celular, email,activo;
           // int RespAlta=0;

            RazonSocial = txRazonSocial.Text;
            Cuit = txCuit.Text;
            provincia = cbProvincia.Text;
            localidad = cbLocalidad.Text;
            domicilio = txDomicilio.Text;
            telefono = txTelefono.Text;
            celular = txCelular.Text;
            email = txEmail.Text;
            if (chActivo.Checked)
                activo = "SI";
            else
                activo = "NO";

            string sql = "INSERT INTO proveedores ( RazonSocial, Cuit, Provincia, Localidad, " +
                "domicilio, telefono, celular, Email, FechaAlta, RespAlta) VALUES('";
            sql += RazonSocial + "', '" + Cuit + "', '" + provincia + "', '";
            sql += localidad;
            sql += "', '";
            sql += domicilio;
            sql += "', '";
            sql += telefono;
            sql += "', '";
            sql += celular;
            sql += "', '";
            sql += email;
            sql += "', CURDATE(), '";
            sql += GIdUsuario;
            sql += "')";
            
            Conexion objConexion = new Conexion();
            

            MySqlConnection conexionBD = objConexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql,conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Registro guardado " + ex);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {

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
            string Cuit = "";
            Cuit = txBuscar.Text;

            ctrProveedores objprueba = new ctrProveedores();
            objprueba.DevolverId(Cuit);
            return;
            MySqlDataReader reader = null;

            string sql = "SELECT idproveedor, RazonSocial, NombreFantacia, Cuit, Provincia, "+
                "Localidad, domicilio, telefono, celular, Email, date(FechaAlta) as FechaAlta, RespAlta, Activo " +
                " FROM proveedores WHERE Cuit LIKE '%"+Cuit+"%' LIMIT 1; ";
            Conexion objConexion = new Conexion();
            MySqlConnection conexionDB = objConexion.conexion();
            conexionDB.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionDB);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lbFechaAlta.Text ="Fecha Alta " + reader.GetString("FechaAlta");
                        laRespAlta.Text = reader.GetString("RespAlta");
                        laIdProveedor.Text = reader.GetString("idproveedor");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al consultar " + ex);
            }
            finally
            {
                conexionDB.Close();
            }
        }



        private void cargarTabla(string dato)
        {
            List <ClaseProveedores> lista = new List<ClaseProveedores>();
            ctrProveedores ctrProv = new ctrProveedores();
            dtgProveedores.DataSource = ctrProv.consulta(dato);
        }
    }


    
}
