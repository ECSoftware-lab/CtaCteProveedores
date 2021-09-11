using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.Proveedores
{
    public class ClaseProveedores
    {
        private int idproveedor;
        private string RazonSocial;
        private string cuit;
        private string provincia;
        private string localidad;
        private string domicilio;
        private string telefono;
        private string celular;
        private string email;
        private string FechaAlta;
        private int RespAlta;
        private string activo;

        public int Idproveedor { get => idproveedor; set => idproveedor = value; }
        public string RazonSocial1 { get => RazonSocial; set => RazonSocial = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public string FechaAlta1 { get => FechaAlta; set => FechaAlta = value; }
        public int RespAlta1 { get => RespAlta; set => RespAlta = value; }
        public string Activo { get => activo; set => activo = value; }
    }
}
