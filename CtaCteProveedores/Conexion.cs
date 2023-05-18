using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CtaCteProveedores
{
    class Conexion
    {
        public MySqlConnection conexion()
        {
            string servidor = "192.168.100.14";
            string puerto = "3308";
            string usuario = "root";
            string password = "maxima0606";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; userid=" + usuario + "; password=" + password + "; database=ctacteproveedores;";
            Console.WriteLine(cadenaConexion);
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
