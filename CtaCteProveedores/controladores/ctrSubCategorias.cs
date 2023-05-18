using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.controladores
{
    class ctrSubCategorias : Conexion
    {
        public void listar(ref DataTable dt,int idCategoria)
        {

            string consulta = "SELECT id, Subcategoria, tipo, idCategoria FROM subcategorias ";
            if (idCategoria != 0) { 
               consulta+=" WHERE idCategoria = '";
                consulta += idCategoria;
                consulta += "' ";
            }
            consulta +=" ORDER BY Subcategoria ";

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
