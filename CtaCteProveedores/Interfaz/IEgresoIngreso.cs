using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.Interfaz
{
    public interface IEgresoIngreso
    {
        string Fecha { get; set; }
        string Categoria { get; set; }
        string SubCategoria { get; set; }
        string Descripcion { get; set; }
        string Cuenta { get; set; }
        double Total { get; set; }

        void mostrar();
        
    }
}
