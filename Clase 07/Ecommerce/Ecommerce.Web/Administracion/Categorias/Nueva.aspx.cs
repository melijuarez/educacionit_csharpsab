using Ecommerce.EntidadesDeNegocio;
using Ecommerce.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.Administracion.Categorias
{
    public partial class Nueva : System.Web.UI.Page
    {
        private CategoriasNegocio categoriasNegocio = new CategoriasNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria()
            {
                Nombre = txtNombreCategoria.Text,
                Descripcion = txtDescripcion.Text
            };

            bool resultado = categoriasNegocio.AgregarCategoria(categoria);

            if (resultado == true)
            {
                Response.Redirect("Default.aspx");
                Response.End();
            }
            else
            {
                pnlError.Visible = true;
                lblError.Text = "Ha ocurrido un error. Revise los datos y reintente";
            }
        }
    }
}