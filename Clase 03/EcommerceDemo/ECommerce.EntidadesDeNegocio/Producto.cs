using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntidadesDeNegocio
{
    public class Producto : Entidad
    {
        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int Stock { get; set; }

        public bool Discontinuado { get; set; }
    }
}
