using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores
{
    class Conexion
    {
        public  MySqlConnection conexion()
        {
            string servidor = "localhost";
            string puerto = "3308";
            string usuario = "root";
            string password = "maxima0606";
            
            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; userid=" + usuario + "; password=" + password + "; database=ctacteproveedores;";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);
                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: "+ ex.Message);
                return null;
            }
            
        }
    }
}
