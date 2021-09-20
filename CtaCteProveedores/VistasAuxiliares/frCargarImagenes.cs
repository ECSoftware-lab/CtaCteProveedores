using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CtaCteProveedores.VistasAuxiliares
{
    public partial class frCargarImagenes : Form
    {
        private bool permitir;
        public frCargarImagenes()
        {
            permitir = true;
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imagenes | *.jpg; *.png";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Title = "Seleccionar Imagen";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pBoxImagen.Image = Image.FromFile(openFile.FileName);

                System.IO.FileInfo f2 = new System.IO.FileInfo(openFile.FileName);
                permitir = true;
                if (f2.Length > 300000)
                {
                    MessageBox.Show("El Tamaño " + f2.Length + " Para el logo es muy grande ");
                    permitir = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accion = "";

            accion = btAccion.Text;
            if (!permitir)
            {
                MessageBox.Show("Tamaño no permitido ");
                return;
            }


            MemoryStream ms = new MemoryStream();
            pBoxImagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();

            Conexion conn = new Conexion();

            MySqlConnection conexionBD = conn.conexion();
            conexionBD.Open();
            string nombre = "";
            /*tipo se va a usar en futuro */
            string tipo = "nombretabla";

            nombre = txtNombreImg.Text;
            try
            {
                string sql = "";
                if (accion == "Guardar")
                {
                    LIdInterno.Text = "0";
                    sql = "INSERT INTO imagenes(Tipo, Nombre, Imgagen) VALUES('" + tipo + "', '" + nombre + "', @Imgagen)";

                }
                else
                {
                    if (accion == "Actualizar")
                    {
                        sql = " UPDATE  imagenes SET Nombre = '" + nombre + "', Imgagen = @Imgagen WHERE Id = '" + LIdInterno.Text + "'";
                    }
                    else
                    {
                        //error
                    }
                }
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("Imgagen", aByte);
                comando.ExecuteNonQuery();
                MessageBox.Show("Guardado Exitoso");

                if (accion == "Guardar")
                {
                    sql = "SELECT Id FROM imagenes WHERE Nombre='" + nombre + "' AND Tipo='" + tipo + "'";

                    MySqlCommand comando2 = new MySqlCommand(sql, conexionBD);
                    MySqlDataReader reader = comando2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        LIdInterno.Text = reader["Id"].ToString();
                        btAccion.Text = "Actualizar";
                    }
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error en guardar " + ex);
            }


        }

        private void frCargarImagenes_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Id Interno " + LIdInterno.Text);
            int inicioId = 0;
            if (string.IsNullOrEmpty(LIdInterno.Text))
                inicioId = 0;

            int.TryParse(LIdInterno.Text, out inicioId);

            MessageBox.Show("Id TryParse " + inicioId);

            if (inicioId != 0)
            {
                cargarImagen(inicioId);
                btAccion.Text = "Actualizar";
            }
            else
            {
                btAccion.Text = "Guardar";
            }

        }

        private void cargarImagen(int idInicio)
        {

            string sql = "SELECT  Id, Tipo, Nombre, Imgagen FROM imagenes WHERE Id = '" + idInicio + "'";
            Conexion conn = new Conexion();

            MySqlConnection conexionBD = conn.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    MemoryStream memoryStream = new MemoryStream((byte[])reader["Imgagen"]);
                    Bitmap bm = new Bitmap(memoryStream);
                    pBoxImagen.Image = bm;
                    txtNombreImg.Text = reader["Nombre"].ToString();
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error en la lectura " + ex);
            }
        }
    }
}
