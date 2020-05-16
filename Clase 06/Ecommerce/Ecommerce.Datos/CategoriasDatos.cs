using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos
{
    public class CategoriasDatos
    {
        public List<Categoria> TodasLasCategorias()
        {
            List<Categoria> ListaDeCategorias;

            ListaDeCategorias = new List<Categoria>()
            {
                new Categoria() {Id=1, Nombre="Electronica", Descripcion="Articulos de electronica super electronicos"},
                new Categoria() {Id=2, Nombre="Juguetes", Descripcion="Para que tus hijos se diviertan en cuartena y te dejen hacer ejercicios de csharp"},
                new Categoria() {Id=3,  Nombre="Art. Hogar", Descripcion="Para mantener la casa limpia"}
            };

            return ListaDeCategorias;
        }
    }
}
