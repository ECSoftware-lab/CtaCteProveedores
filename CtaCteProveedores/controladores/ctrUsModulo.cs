using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.controladores
{
    class ctrUsModulo : Conexion
    {

        public void mostrar_Modulos(ref DataTable dt)
        {

            string consulta = "SELECT IdModulo, Modulo FROM us_modulos ORDER BY Modulo";
            
            MySqlConnection conexionBD = base.conexion();
            



            try
            {
                conexionBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexionBD);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            finally
            { conexionBD.Close(); }

        }

    }
}
