using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CtaCteProveedores
{
    class ConexionSql
    {
      private SqlConnection Conexion = new
           SqlConnection("Server=DESKTOP-U1AK3BK\\SQLEXPRESS;DataBase=ebenezerlenceria;User Id=sa; Password=maxima0707;");
        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }


}
