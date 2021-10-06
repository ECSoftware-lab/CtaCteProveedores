using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.vistas
{
    public partial class PaHome : UserControl
    {
        public PaHome()
        {
            InitializeComponent();
        }

        private void CtrUsHome_Load(object sender, EventArgs e)
        {
            string sqlcons = "";
            string anio = "2021",mes="08";

            ArrayList Categoria = new ArrayList();
            ArrayList TotalCatego = new ArrayList();

            MySqlDataReader redear;
            Conexion objConexion = new Conexion();

            
            MySqlConnection conexionBD = objConexion.conexion();
            conexionBD.Open();
            try
            {
                sqlcons = "IngresosEstePeriodo ";
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters["@anio"].Direction = System.Data.ParameterDirection.Input;
                comando.Parameters.AddWithValue("@mes", mes);
                comando.Parameters["@mes"].Direction = System.Data.ParameterDirection.Input;

                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    Categoria.Add(redear.GetString(0));
                    TotalCatego.Add(redear.GetString(1));
                }
                chartIngresos.Series[0].Points.DataBindXY(Categoria,TotalCatego);
                redear.Close();


                Categoria.Clear();
                TotalCatego.Clear();
                comando = null;
                sqlcons = "EgresoEstePeriodo ";
                comando = new MySqlCommand(sqlcons, conexionBD);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@anio", anio);
                comando.Parameters["@anio"].Direction = System.Data.ParameterDirection.Input;
                comando.Parameters.AddWithValue("@mes", mes);
                comando.Parameters["@mes"].Direction = System.Data.ParameterDirection.Input;

                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    Categoria.Add(redear.GetString(0));
                    TotalCatego.Add(redear.GetString(1));
                }
                chartEgresos.Series[0].Points.DataBindXY(Categoria, TotalCatego);
                redear.Close();

            }
            catch (MySqlException ex)
            {

                
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
