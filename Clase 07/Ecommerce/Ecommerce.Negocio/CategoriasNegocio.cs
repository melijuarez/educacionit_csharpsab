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
        private CategoriasDatos categoriasDatos = new CategoriasDatos();

        public List<Categoria> TodasLasCategorias()
        {
            return categoriasDatos.TodasLasCategorias();
        }

        public Categoria ObtenerCategoria(int id)
        {
            return categoriasDatos.ObtenerCategoria(id);
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(categoria.Nombre) || string.IsNullOrWhiteSpace(categoria.Descripcion) || categoria.Id <= 0)
            {
                result = false;
            }
            else
            {
                categoriasDatos.ActualizarCategoria(categoria);
            }

            return result;
        }

        public bool AgregarCategoria(Categoria categoria)
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(categoria.Nombre) || string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                result = false;
            }
            else
            {
                categoriasDatos.GuardarCategoria(categoria);
            }

            return result;
        }

        public int CantidadCategorias()
        {
            return categoriasDatos.CantidadCategorias();
        }
    }
}
