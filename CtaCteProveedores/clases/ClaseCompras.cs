using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.clases
{
    class ClaseCompras
    {
        private int IdproveedoresCompras;
        private string Fecha;
        private string FechaIng;
        private int IdProveedor;
        private string Estado;
        private string Tipo;
        private double Total;
        private double Acuenta;
        private double Saldo;
        private string Numero;
        private double Iva;
        private double IngBruto;
        private double ImpuInterno;
        private int IdUsuario;

        public ClaseCompras()
        {
        }

        public ClaseCompras(int idProveedor, string tipo, double total, string numero, double iva, double ingBruto, double impuInterno, int idUsuario, string fecha)
        {
            Fecha1 = fecha;
            IdProveedor1 = idProveedor;
            Tipo1 = tipo;
            Total1 = total;
            Numero1 = numero;
            Iva1 = iva;
            IngBruto = ingBruto;
            ImpuInterno1 = impuInterno;
            IdUsuario1 = idUsuario;
        }

        #region get_set
        [Display(Name = "prueba")]
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; } 
        public double ImpuInterno1 { get => ImpuInterno; set => ImpuInterno = value; }
        public double IngBruto1 { get => IngBruto; set => IngBruto = value; }
        public int IdproveedoresCompras1 { get => IdproveedoresCompras; set => IdproveedoresCompras = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string FechaIng1 { get => FechaIng; set => FechaIng = value; }
        public int IdProveedor1 { get => IdProveedor; set => IdProveedor = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public double Total1 { get => Total; set => Total = value; }
        public double Acuenta1 { get => Acuenta; set => Acuenta = value; }
        public double Saldo1 { get => Saldo; set => Saldo = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
        public double Iva1 { get => Iva; set => Iva = value; }

        #endregion
    }
}
