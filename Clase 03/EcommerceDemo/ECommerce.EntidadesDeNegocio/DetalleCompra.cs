using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntidadesDeNegocio
{
    public sealed class DetalleCompra : Entidad
    {
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }
}
