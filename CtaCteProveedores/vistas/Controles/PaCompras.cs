using CtaCteProveedores.clases;
using CtaCteProveedores.controladores;
using CtaCteProveedores.Proveedores;
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
    public partial class PaCompras : UserControl
    {
        const int CUANTOS = 10;
        private int incremento = 0;
        private int totalRegistros = 0;
        ctrProveedores objPrveedor;
        ctrCompras objComrpas;
        private bool editar;

        public PaCompras()
        {
            InitializeComponent();
            editar = false;
            LIdCompra.Text = "";
            lComMens.Visible = false;
            //dtGrCompras.Columns[1].DefaultCellStyle.Format = "d"; // Short date
            dtGrCompras.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdProveedor.Text = "";
            frBuscarPersona form2 = new frBuscarPersona();
            form2.LTabla.Text = "PROVEEDORES";
            form2.ShowDialog();

            int aux = 0;
            int.TryParse(form2.LRespuesta.Text, out aux);
            if (aux != 0)
            {
                txtIdProveedor.Text = aux.ToString();
                //MessageBox.Show("idrespuesta " + aux);
            }
        }

        private void frCtrCompras_Load(object sender, EventArgs e)
        {
            objPrveedor = new ctrProveedores();
            objComrpas = new ctrCompras();
        }

        private void txtIdProveedor_TextChanged(object sender, EventArgs e)
        {
            LRazonSocial.Text = "";
            if (!string.IsNullOrEmpty(txtIdProveedor.Text)) {

                LRazonSocial.Text = objPrveedor.DevolverRazonSoc(int.Parse(txtIdProveedor.Text));
                    
                }
            if (!string.IsNullOrEmpty(LRazonSocial.Text))
            {
                //consultar las ultimas compras de este proveedor
                consultar(txtIdProveedor.Text, incremento, CUANTOS);
            }
        }
     

        private void btAnterior_Click(object sender, EventArgs e)
        {
            incremento = incremento + CUANTOS;

            LPosicion.Text = "Posición " + incremento;
            consultar(txtIdProveedor.Text,incremento,CUANTOS);
        }

        private void btSigiente_Click(object sender, EventArgs e)
        {

            incremento = incremento - CUANTOS;
            if (incremento < 0)
                incremento = 0;

            LPosicion.Text = "Posición " + incremento;
            consultar(txtIdProveedor.Text, incremento, CUANTOS);
        }

        private void consultar(string text, int incremento, int cuantos)
        {
            if (!string.IsNullOrEmpty(LRazonSocial.Text))
            {
                dtGrCompras.DataSource = objComrpas.consultaPaginada(text, incremento, cuantos, "NO");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dtGrCompras.Rows.Count == 0)
                return;
            

            LIdCompra.Text =dtGrCompras.CurrentRow.Cells["idCompra"].Value.ToString();

            txtIdProveedor.Text = dtGrCompras.CurrentRow.Cells["IdProveedor1"].Value.ToString();
            txNumero.Text = dtGrCompras.CurrentRow.Cells["numero1"].Value.ToString();
             dFecha.Text = dtGrCompras.CurrentRow.Cells["Fecha1"].Value.ToString();
            label4.Text= dtGrCompras.CurrentRow.Cells["Fecha1"].Value.ToString();
            CbTipo.Text = dtGrCompras.CurrentRow.Cells["Tipo1"].Value.ToString();
            txTotal.Text = dtGrCompras.CurrentRow.Cells["Total1"].Value.ToString();
            double acuenta = double.Parse(dtGrCompras.CurrentRow.Cells["Acuenta1"].Value.ToString());
            if (acuenta != 0)
            {
                MessageBox.Show("Esta compra ya tiene un pago total o parcial \n solo la puede eliminar y volver a cargar ");
                return;
            }
            
            lComMens.Visible = true;
            editar = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LRazonSocial.Text))
            {
                MessageBox.Show("No selecciono un proveedor");
                txtIdProveedor.Focus();
                return;
            }
            int NCompraOtro = 0;
            ClaseCompras compra = new ClaseCompras
            {
                IdProveedor1 = int.Parse(txtIdProveedor.Text),
                Numero1 = txNumero.Text,
                IdUsuario1 = 0,
                Fecha1 = dFecha.Value.ToString("yyyy/MM/dd"),
                Tipo1 =  CbTipo.Text,
                Total1 =double.Parse( txTotal.Text),
                Iva1=0,
                IngBruto1=0,
                ImpuInterno1=0,
                Acuenta1=0,
                Saldo1=0   
            };
      
            ctrCompras objComrpa = new ctrCompras();
            if(editar == false) {
                NCompraOtro = objComrpa.ExisteCompra(compra.IdProveedor1, compra.Tipo1, compra.Numero1);
                if(NCompraOtro!=0)
                {
                    MessageBox.Show(this,"Ya existe este Tipo y Numero Para este Proveedor","Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (objComrpa.inserta(compra)==1)
                    MessageBox.Show("Se inserto la compra");
                else
                    MessageBox.Show(this, "No se pudo insertar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


               // MessageBox.Show("Se inserto la compra", MessageBoxIcon.Error);
            }
            else
            {
                int NCompra = 0;
                if (int.TryParse(LIdCompra.Text, out NCompra))
                {
                    NCompraOtro = objComrpa.ExisteCompra(compra.IdProveedor1, compra.Tipo1, compra.Numero1);
                    MessageBox.Show(" " + NCompra + " " + NCompraOtro);
                    if (NCompra == NCompraOtro)
                        { objComrpa.modificar(compra, NCompra); }
                    else {
                        if(NCompraOtro == 0)
                            objComrpa.modificar(compra, NCompra);
                        else
                        MessageBox.Show(this, "Ya existe este Tipo y Numero Para este Proveedor.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo modificar".ToLower(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            editar = false;
            LIdCompra.Text = "";
            lComMens.Visible = false;
            consultar(txtIdProveedor.Text, 0, CUANTOS);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

            if (dtGrCompras.Rows.Count == 0)
                return;
            LIdCompra.Text = dtGrCompras.CurrentRow.Cells["idCompra"].Value.ToString();
            string message ="Esta Seguro/a de Eliminar la Compra N: " + LIdCompra.Text ;
            const string caption = "Eliminar Compra";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);

            // If the no button was pressed ...  
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("SI");
            }
            else
            {
                MessageBox.Show("no");
            }


            

        }

        private void dtGrCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Cell");
        }
    }
}
