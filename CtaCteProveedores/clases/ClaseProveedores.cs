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

        public ClaseProveedores(string razonSocial, string cuit, string provincia, string localidad, string domicilio, string telefono, string celular, string email, int respAlta)
        {
            this.RazonSocial = razonSocial;
            this.cuit = cuit;
            this.provincia = provincia;
            this.localidad = localidad;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.celular = celular;
            this.email = email;
            this.RespAlta = respAlta;
        }

        public ClaseProveedores()
        {
        }



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

        internal clases.ClaseCompras ClaseCompras
        {
            get => default;
            set
            {
            }
        }
    }
}
