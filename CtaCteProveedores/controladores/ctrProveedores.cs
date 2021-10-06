using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CtaCteProveedores.Proveedores
{
    class ctrProveedores : Conexion
    {
        private string sqlcons = "";

        public List<Object> consulta(string dato)
        {
            MySqlDataReader redear;
            List<Object> listaProveedor = new List<object>();
            string consulta = "";

            if (dato == null)
            {

                consulta = "SELECT * FROM proveedores ORDER BY RazonSocial DESC LIMIT 50; ";
            }
            else
            {
                consulta = "SELECT * FROM proveedores WHERE RazonSocial LIKE '%" + dato + "%' OR Cuit LIKE '%" + dato + "%' ORDER BY RazonSocial DESC LIMIT 50; ";
            }

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                redear = comando.ExecuteReader();
                while (redear.Read())
                {
                    ClaseProveedores objProveedor = new ClaseProveedores();
                    objProveedor.Idproveedor = int.Parse(redear.GetString("idproveedor"));
                    objProveedor.RazonSocial1 = redear.GetString("RazonSocial");
                    objProveedor.Cuit = redear.GetString("Cuit");
                    objProveedor.Provincia = redear.GetString("Provincia");
                    objProveedor.Localidad = redear.GetString("Localidad");
                    objProveedor.Domicilio = redear.GetString("domicilio");
                    objProveedor.Telefono = redear.GetString("telefono");
                    objProveedor.Celular = redear.GetString("celular");
                    objProveedor.Email = redear.GetString("Email");
                    objProveedor.FechaAlta1 = redear.GetString("FechaAlta");
                    objProveedor.RespAlta1 = int.Parse(redear.GetString("RespAlta"));
                    objProveedor.Activo = redear.GetString("Activo");
                    listaProveedor.Add(objProveedor);
                }
            }
            catch (MySqlException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            return listaProveedor;
        }

        //Devolver Id desde Cuit
        public int DevolverId(string cuit)
        {
            int salida = 0;
            MySqlDataReader redear;
            if (String.IsNullOrEmpty(cuit))
            {//error no paso ningun cuit
                MessageBox.Show("No ingreso cuit  ");
                return -1;
            }
            sqlcons = "SELECT idproveedor FROM proveedores WHERE Cuit='" + cuit + "'  LIMIT 1; ";

            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                if (redear.HasRows)
                {

                    redear.Read();
                    salida = int.Parse(redear.GetString("idproveedor"));
                    MessageBox.Show("salida " + salida);

                }
                else
                {

                    salida = 0;
                }

            }
            catch (MySqlException ex)
            {

                salida = -2;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
            return salida;
        }

        //Devolver Id desde Cuit
        public string DevolverRazonSoc(int _Id)
        {
            string salida = "";
            MySqlDataReader redear;

            sqlcons = "SELECT RazonSocial FROM proveedores WHERE idproveedor='" + _Id + "'  LIMIT 1; ";

            MySqlConnection conexionBD = base.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                redear = comando.ExecuteReader();
                if (redear.HasRows)
                {

                    redear.Read();
                    salida = redear.GetString("RazonSocial");

                }
                else
                {

                    salida = "";
                }

            }
            catch (MySqlException ex)
            {

                salida = "";
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
            return salida;
        }

        public int inserta(ClaseProveedores prov)
        {
            int salida = 0;

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand("ProveedorInsert", conexionBD);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@_RazonSocial", prov.RazonSocial1);
                comando.Parameters["@_RazonSocial"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Cuit", prov.Cuit);
                comando.Parameters["@_Cuit"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Provincia", prov.Provincia);
                comando.Parameters["@_Provincia"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Localidad", prov.Localidad);
                comando.Parameters["@_Localidad"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Domicilio", prov.Domicilio);
                comando.Parameters["@_Domicilio"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Telefono", prov.Telefono);
                comando.Parameters["@_Telefono"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Celular", prov.Celular);
                comando.Parameters["@_Celular"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_Email", prov.Email);
                comando.Parameters["@_Email"].Direction = System.Data.ParameterDirection.Input;

                comando.Parameters.AddWithValue("@_RespAlta", prov.RespAlta1);
                comando.Parameters["@_RespAlta"].Direction = System.Data.ParameterDirection.Input;


                comando.ExecuteNonQuery();
                salida = DevolverId(prov.Cuit);
            }
            catch (MySqlException ex)
            {

                salida = 0;
                Console.WriteLine(ex.Message.ToString());
            }
            return salida;
        }

        public bool update(ClaseProveedores prov)
        {
            bool salida = false;
            sqlcons = "UPDATE proveedores SET RazonSocial = '" + prov.RazonSocial1 + "', Cuit = '" + prov.Cuit + "', Provincia = '" + prov.Provincia
                + "', Localidad = '" + prov.Localidad + "', domicilio = '" + prov.Domicilio + "', telefono = '" + prov.Telefono
                + "', celular = '" + prov.Celular + "', Email = '" + prov.Email + "' , Activo = '" + prov.Activo + "' ";
            sqlcons += " WHERE idproveedor = '";
            sqlcons += prov.Idproveedor;
            sqlcons += "'";




            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                comando.ExecuteNonQuery();
                salida = true;
            }
            catch (MySqlException ex)
            {

                salida = false;
                Console.WriteLine(ex.Message.ToString());
            }
            return salida;
        }

        public bool delete(int idprov)
        {
            bool salida = false;
            sqlcons = "DELETE  FROM proveedores ";
            sqlcons += " WHERE idproveedor = '";
            sqlcons += idprov;
            sqlcons += "'";




            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(sqlcons, conexionBD);
                comando.ExecuteNonQuery();
                salida = true;
            }
            catch (MySqlException ex)
            {

                salida = false;
                Console.WriteLine(ex.Message.ToString());
            }
            return salida;
        }

        public int DevolverDatos(ref ClaseProveedores prov, int idProveedor)
        {
            MySqlDataReader redear;
            int salida = 0;
            string consulta = "";

            consulta = "SELECT idproveedor, RazonSocial, NombreFantacia, Cuit, Provincia, Localidad, ";
            consulta += " domicilio, telefono, celular, Email, date(FechaAlta) as FechaAlta , RespAlta, Activo ";
            consulta += " FROM proveedores WHERE idproveedor = '" + idProveedor + "'  Limit 1";

            try
            {
                MySqlConnection conexionBD = base.conexion();
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                redear = comando.ExecuteReader();
                if (redear.HasRows)
                {

                    redear.Read();
                    salida = int.Parse(redear.GetString("idproveedor"));
                    prov.RazonSocial1 = redear.GetString("RazonSocial");
                    prov.Cuit = redear.GetString("Cuit");
                    prov.Provincia = redear.GetString("Provincia");
                    prov.Localidad = redear.GetString("Localidad");
                    prov.Domicilio = redear.GetString("domicilio");
                    prov.Telefono = redear.GetString("telefono");
                    prov.Celular = redear.GetString("celular");
                    prov.Email = redear.GetString("Email");
                    prov.FechaAlta1 = redear.GetString("FechaAlta");
                    prov.RespAlta1 = int.Parse(redear.GetString("RespAlta"));
                    prov.Activo = redear.GetString("Activo");

                }

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
