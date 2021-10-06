using CtaCteProveedores.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.controladores
{
    class ctrEgresos : Conexion
    {
        private string sqlcons = "";

        public List<Object> consultaPaginadaPeriodo(string anio,string mes, int inicio, int fin)
        {
            MySqlDataReader redear;
            List<Object> listaCompras = new List<object>();


            sqlcons = "SELECT  IdEgresos, Fecha, Categoria, SubCategoria, Descripcion, Cuenta, Total FROM egresos WHERE YEAR(fecha)='";
            sqlcons += anio;
            sqlcons += "' AND MONTH(fecha)='";
            sqlcons += mes;
            sqlcons+= "' ORDER BY fecha DESC , IdEgresos DESC";
            sqlcons += " LIMIT ";
            sqlcons += inicio;
            sqlcons += ",";
            sqlcons += fin;

            Console.WriteLine(sqlcons);
            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseEgreso objEgreso = new ClaseEgreso();
                    objEgreso.IdEgreso1 = int.Parse(redear.GetString("IdEgresos"));
                    objEgreso.Fecha =  redear.GetString("Fecha");
                    objEgreso.Categoria = redear.GetString("Categoria");
                    objEgreso.SubCategoria = redear.GetString("SubCategoria");
                    objEgreso.Descripcion = redear.GetString("Descripcion");
                    objEgreso.Cuenta = redear.GetString("Cuenta");
                    objEgreso.Total = double.Parse(redear.GetString("Total"));

                    listaCompras.Add(objEgreso);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            return listaCompras;
        }

        public int inserta(ClaseEgreso egreso)
        {
            int salida = 0;

            try
            {
                sqlcons = "";
                   sqlcons = " INSERT INTO egresos(Fecha, Categoria, SubCategoria, Descripcion, Cuenta, Total) ";
                sqlcons += " VALUES(  @Fecha, @Categoria, @SubCategoria, @Descripcion, @Cuenta, @Total)";
                egreso.Descripcion = ""; egreso.Cuenta = "EF";
                 MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);

                comando.Parameters.AddWithValue("@Fecha", egreso.Fecha);
                comando.Parameters.AddWithValue("@Categoria", egreso.Categoria);
                comando.Parameters.AddWithValue("@SubCategoria", egreso.SubCategoria);
                comando.Parameters.AddWithValue("@Descripcion", egreso.Descripcion);
                comando.Parameters.AddWithValue("@Cuenta", egreso.Cuenta);
                comando.Parameters.AddWithValue("@Total", egreso.Total);
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
