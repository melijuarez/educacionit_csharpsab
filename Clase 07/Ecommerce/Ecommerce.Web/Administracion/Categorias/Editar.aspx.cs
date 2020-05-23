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
    public partial class Editar : System.Web.UI.Page
    {
        private CategoriasNegocio categoriasNegocio = new CategoriasNegocio();

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            string idQuery = Request.QueryString["id"];

            if (string.IsNullOrWhiteSpace(idQuery))
            {
                Response.Redirect("Default.aspx");
                Response.End();
            }

            if (!IsPostBack)
            {
                int id = Convert.ToInt32(idQuery);
                Categoria categoria = categoriasNegocio.ObtenerCategoria(id);
                txtNombreCategoria.Text = categoria.Nombre;
                txtDescripcion.Text = categoria.Descripcion;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string idQuery = Request.QueryString["id"];
            int id = Convert.ToInt32(idQuery);

            Categoria categoria = new Categoria()
            {
                Id = id,
                Nombre = txtNombreCategoria.Text,
                Descripcion = txtDescripcion.Text
            };

            bool resultado = categoriasNegocio.ActualizarCategoria(categoria);

            if (resultado)
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