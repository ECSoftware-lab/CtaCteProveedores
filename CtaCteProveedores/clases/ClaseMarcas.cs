using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtaCteProveedores.clases
{
    class ClaseMarcas
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Mostrar { get; set; }
        
        public string NombreExel { get; set; }
        public int  Orden { get; set; }
        
        public string Bloqueada { get; set; }
        
        public string  archivo { get; set; }
        
        public string ImgenTapa { get; set; }
        
        public string  ImgLogo { get; set; }
        
        public string ActivaEnWeb { get; set; }
    }

    class ClaseMarcasExport
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string dateCreation { get; set; }
        public int owner { get; set; }
        public int active { get; set; }
        public int activeWeb{ get; set; }
}
}
