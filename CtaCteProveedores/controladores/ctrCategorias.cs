using CtaCteProveedores.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.controladores
{
    class ctrCategorias : Conexion
    {
        private string sqlcons = "";

        public void listar(ref DataTable dt,string tipo)
        {

            string WHERE = "";
            if ((string.IsNullOrEmpty(tipo)) || (tipo.Equals("-")))
                WHERE = "";
            else
            { WHERE = " WHERE tipo='" + tipo + "' "; }

            sqlcons = "SELECT id, Categoria, tipo FROM categorias ";
            sqlcons += WHERE;
            sqlcons += " ORDER BY Categoria ";

            //Console.WriteLine(sqlcons);
            MySqlConnection conexionBD = base.conexion();
            try
            {
                
                conexionBD.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlcons, conexionBD);
                da.Fill(dt);
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            finally
            { conexionBD.Close(); }
        }
        public List<Object> listar(string tipo)
        {
            MySqlDataReader redear;
            List<Object> listaCatego = new List<object>();
            string WHERE = "";
            if ((string.IsNullOrEmpty(tipo)) || (tipo.Equals("-")))
                WHERE = "";
            else
            { WHERE = " WHERE tipo='" +tipo +"' "; }

            sqlcons = "SELECT id, Categoria, tipo FROM categorias ";
            sqlcons += WHERE;
            sqlcons += " ORDER BY Categoria ";

            Console.WriteLine(sqlcons);
            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseCategorias objCatego = new ClaseCategorias();

                    objCatego.id = int.Parse(redear.GetString("id"));
                    objCatego.Categoria = redear.GetString("Categoria");
                    objCatego.tipo = redear.GetString("tipo");

                    listaCatego.Add(objCatego);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            return listaCatego;
        }

        public int inserta(ClaseCategorias categoria)
        {
            int salida = 0;

            try
            {
                string cons = " INSERT INTO categorias(Categoria, tipo) VALUES(@Categoria, @tipo) ";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(cons, conexionBD);

                comando.Parameters.AddWithValue("@Categoria", categoria.Categoria);
                comando.Parameters.AddWithValue("@tipo", categoria.tipo);
                comando.ExecuteNonQuery();
                salida = 1;
            }
            catch (MySqlException ex)
            {

                salida = 0;
                Console.WriteLine(ex.Message.ToString());
            }
            return salida;
        }

    }
}
