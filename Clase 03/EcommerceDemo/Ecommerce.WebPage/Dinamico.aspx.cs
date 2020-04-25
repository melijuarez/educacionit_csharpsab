using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.WebPage
{
    public partial class Dinamico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblHolaMundo.Text = "Esto esta configurado desde el servidor";
        }
    }
}