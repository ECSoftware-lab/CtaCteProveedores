using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class frConsultaCtaCteProv : Form
    {
        public frConsultaCtaCteProv()
        {
            InitializeComponent();
        }

        private void btExportarPdf_Click(object sender, EventArgs e)
        {
            PdfWriter pdfWrite = new PdfWriter("reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWrite);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60,20,55,20) ;
            var parrafo = new Paragraph("Hola Mundo ");
            documento.Add(parrafo);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Fecha","idcompra", "idPagoProve" , "Debe" , "Haber"};
            float[] tamanios = { 3,2,2,2,2 };

            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            documento.Add(tabla);
            documento.Close();

        }
    }
}
