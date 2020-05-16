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
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            string idQuery = Request.QueryString["id"];

            if (string.IsNullOrWhiteSpace(idQuery))
            {
                Response.Redirect("Default.aspx");
                Response.End();
            }


        }
    }
}