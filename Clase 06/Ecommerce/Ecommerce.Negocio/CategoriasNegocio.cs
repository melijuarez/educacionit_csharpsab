using Ecommerce.Datos;
using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Negocio
{
    public class CategoriasNegocio
    {
        public List<Categoria> TodasLasCategorias()
        {
            CategoriasDatos categoriasDatos = new CategoriasDatos();
            return categoriasDatos.TodasLasCategorias();
        }
    }
}
