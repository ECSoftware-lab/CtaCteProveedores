using CtaCteProveedores.clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtaCteProveedores.controladores
{
    class ctrCompras : Conexion
    {
        private string sqlcons = "";

        public List<Object> consultaPaginada(string IdProv,int inicio,int fin,string consaldo)
        {
            MySqlDataReader redear;
            List<Object> listaCompras = new List<object>();
            string consulta = "";

            consulta = "SELECT IdproveedoresCompras, DATE_FORMAT(Fecha, '%d/%m/%Y') as Fecha, date(FechaIng) as FechaIng , idProveedor, Estado, Tipo, Total, Acuenta, Saldo, Numero, ";
            consulta += " Iva, IngBruto, ImpuInterno, idUsuario ";
            consulta += " FROM proveedorescompras WHERE idProveedor = '";
            consulta += IdProv;
            consulta += "' ";

            if (consaldo == "SI")
            {
                consulta += " AND Saldo>'0' "; 

                
            }
            consulta += " ORDER BY IdproveedoresCompras DESC LIMIT ";
            consulta += inicio;
            consulta += ",";
            consulta +=fin;

            Console.WriteLine(consulta);
            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseCompras objCompras = new ClaseCompras();
                    objCompras.IdproveedoresCompras1 = int.Parse(redear.GetString("IdproveedoresCompras")); 
                    objCompras.IdProveedor1 = int.Parse(redear.GetString("IdProveedor"));
                    objCompras.IdUsuario1 = int.Parse(redear.GetString("IdUsuario"));
                    objCompras.Fecha1 = redear.GetString("Fecha");
                    objCompras.FechaIng1 = redear.GetString("FechaIng");
                    objCompras.Estado1 = redear.GetString("Estado");
                    objCompras.Tipo1 = redear.GetString("Tipo");
                    objCompras.Numero1 = redear.GetString("Numero");
                    objCompras.Total1 =double.Parse(redear.GetString("Total"));
                    objCompras.Acuenta1 = double.Parse(redear.GetString("Acuenta"));
                    objCompras.Saldo1 = double.Parse(redear.GetString("Saldo"));
                    objCompras.Iva1 = double.Parse(redear.GetString("Iva"));
                    objCompras.IngBruto1 = double.Parse(redear.GetString("IngBruto"));
                    objCompras.ImpuInterno1 = double.Parse(redear.GetString("ImpuInterno"));

                    listaCompras.Add(objCompras);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            return listaCompras;
        }

        public int inserta(ClaseCompras compras)
        {
            int salida = 0;

            try
            {
                string cons = " INSERT INTO proveedorescompras ( Fecha, FechaIng, idProveedor,  ";
                cons += " Tipo, Total, Acuenta, Saldo, Numero, Iva, IngBruto, ImpuInterno, idUsuario ) VALUES (";
                cons += " @Fecha, CURDATE(), @idProveedor, ";
                cons += " @Tipo, @Total, @Acuenta, @Saldo, @Numero, @Iva, @IngBruto, @ImpuInterno, @idUsuario )";

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(cons, conexionBD);
                
                comando.Parameters.AddWithValue("@Fecha", compras.Fecha1);
                comando.Parameters.AddWithValue("@idProveedor", compras.IdProveedor1);
                comando.Parameters.AddWithValue("@Tipo", compras.Tipo1);
                comando.Parameters.AddWithValue("@Total", compras.Total1);
                comando.Parameters.AddWithValue("@Acuenta", 0);
                comando.Parameters.AddWithValue("@Saldo", compras.Total1);
                comando.Parameters.AddWithValue("@Numero", compras.Numero1);
                comando.Parameters.AddWithValue("@Iva", compras.Iva1);
                comando.Parameters.AddWithValue("@IngBruto", compras.IngBruto1);
                comando.Parameters.AddWithValue("@ImpuInterno", compras.ImpuInterno1);
                comando.Parameters.AddWithValue("@idUsuario", compras.IdUsuario1);
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

        public int modificar(ClaseCompras compras,int NCompra)
        {
            int salida = 0;

            try
            {
                string cons = " UPDATE  proveedorescompras SET Fecha =@Fecha , Tipo = @Tipo, Total = @Total,  Saldo = @Saldo ";
                cons += ", Numero = @Numero, Iva = @Iva, IngBruto = @IngBruto, ImpuInterno = @ImpuInterno ";
                cons+= " WHERE IdproveedoresCompras = @IdproveedoresCompras" ;
               

                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(cons, conexionBD);

                comando.Parameters.AddWithValue("@Fecha", compras.Fecha1);
                comando.Parameters.AddWithValue("@Tipo", compras.Tipo1);
                comando.Parameters.AddWithValue("@Total", compras.Total1);
                comando.Parameters.AddWithValue("@Saldo", compras.Total1);
                comando.Parameters.AddWithValue("@Numero", compras.Numero1);
                comando.Parameters.AddWithValue("@Iva", compras.Iva1);
                comando.Parameters.AddWithValue("@IngBruto", compras.IngBruto1);
                comando.Parameters.AddWithValue("@ImpuInterno", compras.ImpuInterno1);
                comando.Parameters.AddWithValue("@IdproveedoresCompras", NCompra);
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

        public int ExisteCompra(int idProveedor,string tipo, string numero)
        {
            int salida = 0;
            MySqlDataReader redear;
            if ((String.IsNullOrEmpty(tipo)) || (String.IsNullOrEmpty(numero)))
            {//error no paso ningun cuit
                MessageBox.Show("Falta algun dato  ");
                return 0;
            }
            sqlcons = "SELECT IdproveedoresCompras FROM proveedorescompras WHERE idProveedor = '"+idProveedor
                +"' AND Tipo = '"+tipo+"' AND Numero = '"+numero+"' ";

            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                if (redear.HasRows)
                {

                    redear.Read();
                    salida = int.Parse(redear.GetString("IdproveedoresCompras"));
                    
                }
                else
                {
                    salida =0;
                }
            }
            catch (MySqlException ex)
            {

                salida = 0;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
            
            return salida;
        }
    }
}
