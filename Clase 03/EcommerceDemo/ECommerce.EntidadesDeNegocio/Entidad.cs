using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.EntidadesDeNegocio
{
    public abstract class Entidad: IEntidadDeNegocio
    {
        public int Id { get; set; }

        public bool EstaGuardado()
        {
            return Id > 0;
        }
    }
}
