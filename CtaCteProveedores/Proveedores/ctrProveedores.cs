using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.Proveedores
{
    class ctrProveedores:Conexion
    {
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
    }
}
