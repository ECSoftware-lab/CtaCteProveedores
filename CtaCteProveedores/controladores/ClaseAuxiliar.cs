using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace CtaCteProveedores.clases
{
    class ClaseAuxiliar : Conexion
    {
        private string sqlcons = "";
        public DataTable cargarProvincias()
        {

            DataTable dt = new DataTable();

            sqlcons = "SELECT idprovincia, provincia FROM provincia ORDER BY provincia";


            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                data.Fill(dt);

            }

            catch (MySqlException ex)
            {
                dt = null;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }


            return dt;
        }


        public DataTable cargarLocalidades(string provincia)
        {

            DataTable dt = new DataTable();

            sqlcons = "SELECT idprov_localidad, Localidad, COD FROM provincia_localidad ";
            sqlcons += " WHERE idprovincia = FucIdProvincia('";
            sqlcons += provincia;
            sqlcons += "') ORDER BY Localidad ";

            //MessageBox.Show(sqlcons);
            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                data.Fill(dt);

            }

            catch (MySqlException ex)
            {
                dt = null;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }


            return dt;
        }
    }
}
