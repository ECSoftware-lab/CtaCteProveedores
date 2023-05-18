using CtaCteProveedores.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.controladores
{
    class ctrMarcasUpload : ConexionSql
    {
        private string sqlcons { set; get; }
       
        public int InsertarMarca()
        {
            List<ClaseMarcas> listaMar = new List<ClaseMarcas>();

            
            
            MySqlDataReader redear;
            sqlcons = "SELECT idMarcas, Marca, Mostrar, NombreExel, Orden, Bloqueada, ";
            sqlcons += "archivo, ImgenTapa, ImgLogo, ActivaEnWeb FROM marcas ";

            var primeraconexion = new Conexion();

            MySqlConnection conexionBD = primeraconexion.conexion();
            try
            {

                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseMarcas objMarca = new ClaseMarcas();
                    objMarca.id = int.Parse(redear.GetString("idMarcas"));
                    objMarca.Marca = redear.GetString("Marca");
                    objMarca.ImgenTapa = redear.GetString("ImgenTapa");
                    objMarca.ImgLogo = redear.GetString("ImgLogo");
                    objMarca.ActivaEnWeb = redear.GetString("ActivaEnWeb");
                  
                    try
                    {
                        objMarca.Orden = redear.GetString("Orden") == null ? 0 : int.Parse(redear.GetString("Orden"));
                    }
                    catch (Exception)
                    {
                        objMarca.Orden = 1;
                    }
                    

                    
                    listaMar.Add(objMarca);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            finally
            { conexionBD.Close(); }


            SqlConnection sqlConnection = base.OpenConnection();

            foreach (var item in listaMar)
            {
                string cons = " INSERT INTO[dbo].[productBrand] ([brand] ,[dateCreation] ,[owner],[active] ,[activeWeb]) VALUES('";
                cons += item.Marca;
                cons += "', GETDATE() ,8,1,1)";


                //sqlConnection.Open();
                SqlCommand comando = new SqlCommand(cons, sqlConnection);
                comando.ExecuteNonQuery();
                return 10;
            }

            return 1;
        }
    }
}
