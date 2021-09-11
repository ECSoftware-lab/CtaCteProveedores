using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.Proveedores
{
    class ctrProveedores:Conexion
    {
        private string sqlcons = "";

        public List<Object> consulta(string dato)
        {
            MySqlDataReader redear;
            List<Object> listaProveedor = new List<object>();
            string consulta = "";

            if (dato == null)
            {

                consulta = "SELECT * FROM proveedores ORDER BY RazonSocial DESC LIMIT 50; ";
            }
            else
            {
                consulta = "SELECT * FROM proveedores WHERE RazonSocial LIKE '%"+dato+"%' OR Cuit LIKE '%"+dato+"%' ORDER BY RazonSocial DESC LIMIT 50; ";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseProveedores objProveedor = new ClaseProveedores();
                    objProveedor.Idproveedor = int.Parse(redear.GetString("idproveedor"));
                    objProveedor.RazonSocial1 = redear.GetString("RazonSocial");
                    objProveedor.Cuit = redear.GetString("Cuit");
                    objProveedor.Provincia = redear.GetString("Provincia");
                    objProveedor.Localidad = redear.GetString("Localidad");
                    objProveedor.Domicilio = redear.GetString("domicilio");
                    objProveedor.Telefono = redear.GetString("telefono");
                    objProveedor.Celular = redear.GetString("celular");
                    objProveedor.Email = redear.GetString("Email");
                    objProveedor.FechaAlta1 = redear.GetString("FechaAlta");
                    objProveedor.RespAlta1 = int.Parse(redear.GetString("RespAlta"));
                    objProveedor.Activo = redear.GetString("Activo");
                    listaProveedor.Add(objProveedor);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            return listaProveedor;
        }
    
    //Devolver Id desde Cuit
    public int DevolverId(string cuit)
        {
            int salida = 0;
            MySqlDataReader redear;
            if (String.IsNullOrEmpty(cuit))
            {//error no paso ningun cuit
                MessageBox.Show("No ingreso cuit  ");
                return -1;
            }
            sqlcons = "SELECT idproveedor FROM proveedores WHERE Cuit='" + cuit + "'  LIMIT 1; ";

            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                if (redear.HasRows)
                {
                    salida=int.Parse( redear.GetString("idproveedor"));
                }
                else
                {
                    salida = 0;
                }

            }
            catch (MySqlException ex)
            {
                salida = -2;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
            return salida;
        }
    
    }
}
