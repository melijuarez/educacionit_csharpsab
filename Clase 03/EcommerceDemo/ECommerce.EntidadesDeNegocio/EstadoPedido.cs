using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntidadesDeNegocio
{
    public enum EstadoPedido: byte
    {
        PendienteDePago=1,
        Pagado,
        PendienteDeEntrega,
        Entregado,
        Cancelado
    }
}
