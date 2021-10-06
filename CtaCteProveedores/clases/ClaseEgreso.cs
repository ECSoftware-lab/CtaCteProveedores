using CtaCteProveedores.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.clases
{
    public class ClaseEgreso : IEgresoIngreso
    {
        private int IdEgreso;
        private string fecha;
        private string categoria;
        private string subCategoria;
        private string descripcion;
        private string cuenta;
        private double total;
        public string Fecha { get => fecha; set => fecha = value; }
        //public string Descripcion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cuenta { get => cuenta; set => cuenta=value; }
        public double Total { get => total; set => total=value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string SubCategoria { get => subCategoria; set => subCategoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdEgreso1 { get => IdEgreso; set => IdEgreso = value; }

        public void mostrar()
        {
            throw new NotImplementedException();
        }
    }
}
