using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntidadesDeNegocio
{
    public class Compra
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string NombreParaLaEntrega { get; set; }

        public string DireccionParaLaEntrega { get; set; }

        public List<DetalleCompra> ProductosComprados { get; set; } = new List<DetalleCompra>();

        public Compra()
        {
        }
    }
}
