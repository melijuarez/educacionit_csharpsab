using Ecommerce.EntidadesDeNegocio;
using Ecommerce.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web
{
    public partial class Default : System.Web.UI.Page
    {
        //private List<Categoria> ListaDeCategorias { get; set; }

        public Default()
        {
            //ListaDeCategorias = new List<Categoria>()
            //{
            //    new Categoria() {Id=1, Nombre="Electronica", Descripcion="Articulos de electronica super electronicos"},
            //    new Categoria() {Id=2, Nombre="Juguetes", Descripcion="Para que tus hijos se diviertan en cuartena y te dejen hacer ejercicios de csharp"},
            //    new Categoria() {Id=3,  Nombre="Art. Hogar", Descripcion="Para mantener la casa limpia"}
            //};
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Tienda tienda = (Tienda)Application["Tienda"];
            lblNombreYSlogan.Text = tienda.Nombre + " - " + tienda.Slogan;

            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            listViewCategorias.DataSource = categoriasNegocio.TodasLasCategorias();
            listViewCategorias.DataBind();
        }
    }
}