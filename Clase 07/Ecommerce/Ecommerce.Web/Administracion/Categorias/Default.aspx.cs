﻿using Ecommerce.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.Administracion.Categorias
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
                listViewCategorias.DataSource = categoriasNegocio.TodasLasCategorias();
                listViewCategorias.DataBind();
                int cantidad = categoriasNegocio.CantidadCategorias();
                lblCantidadCategorias.Text = cantidad.ToString();

            }
        }
    }
}