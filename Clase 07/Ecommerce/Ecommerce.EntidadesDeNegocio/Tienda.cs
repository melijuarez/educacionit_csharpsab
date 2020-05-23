using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.EntidadesDeNegocio
{
    public class Tienda
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Slogan { get; set; }

        public string Resumen { get; set; }

        public int CantidadVisitas { get; set; }
    }
}
