using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.MasterPage
{
    public partial class Ecommerce : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Tienda miTienda = (Tienda)Application["Tienda"];

            VinculoDeTitulo.Text = miTienda.Nombre;
            miTienda.CantidadVisitas++;
        }
    }
}