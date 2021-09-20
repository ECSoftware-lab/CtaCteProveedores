using MySql.Data.MySqlClient;
using System;

namespace CtaCteProveedores
{
    class Conexion
    {
        public MySqlConnection conexion()
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
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }

        }
    }
}
