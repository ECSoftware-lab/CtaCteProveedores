using CtaCteProveedores.controladores;
using CtaCteProveedores.VistasAuxiliares;
using System;
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
    public partial class PaEgresos : UserControl
    {

        const int CUANTOS = 10;
        private int incremento = 0;
        ctrCategorias objCategori;
        ctrEgresos objEgresosConsulta; 
        private string anio = "";
        private string mes = "";
        public PaEgresos()
        {
            InitializeComponent();
        }

        private void CtrUsEgresos_Load(object sender, EventArgs e)
        {
            
            anio = DateTime.Now.Year.ToString();
            mes = DateTime.Now.Month.ToString();
            StringBuilder stBuild = new StringBuilder();
            stBuild.Append(anio);
            stBuild.Append("/");
            stBuild.Append(mes);
            

            LPeriodo.Text = stBuild.ToString(); // anio + "/" + mes;
            objEgresosConsulta = new ctrEgresos();
            consultar(anio, mes, 0, CUANTOS);

            objCategori = new ctrCategorias();
            cbxCategorias.DataSource = null;
            cbxCategorias.Items.Clear();

            cbxCategorias.ValueMember = "id";
            cbxCategorias.DisplayMember = "Categoria";
           cbxCategorias.DataSource = objCategori.listar("");

            llenarSubCategoria();
        }


        private void llenarSubCategoria()
        {
            DataTable dt = new DataTable();
            ctrSubCategorias objSucatego = new ctrSubCategorias();
            MessageBox.Show(" " + cbxCategorias.SelectedIndex);

            objSucatego.listar(ref dt, 0);

            cbxSubCatego.DataSource = null;
            cbxSubCatego.Items.Clear();

            cbxSubCatego.ValueMember = "Subcategoria";
            cbxSubCatego.DisplayMember = "Subcategoria";
            cbxSubCatego.DataSource = dt;


        }
        private void btAnterior_Click(object sender, EventArgs e)
        {
            incremento = incremento + CUANTOS;
            LPosicion.Text = "Posición " + incremento;
            
            
            consultar(anio,mes, incremento, CUANTOS);
        }

        private void consultar(string _anio, string _mes, int _inicio, int _fin)
        {
            dtGEgresos.DataSource = objEgresosConsulta.consultaPaginadaPeriodo(_anio, _mes, _inicio,_fin);
        }

        private void btSigiente_Click(object sender, EventArgs e)
        {
            incremento = incremento - CUANTOS;
            if (incremento < 0)
                incremento = 0;

            LPosicion.Text = "Posición " + incremento;
            consultar(anio, mes, incremento, CUANTOS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frAbmCategoria frAddCat = new frAbmCategoria())
            { 
                frAddCat.ShowDialog();
            }

            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var export = new ctrMarcasUpload();
            export.InsertarMarca();
        }
    }
}
