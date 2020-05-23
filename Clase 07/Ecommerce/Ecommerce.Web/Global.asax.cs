using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Ecommerce.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Tienda miTienda = new Tienda()
            {
                Nombre = ConfigurationManager.AppSettings["NombreSitio"] ?? "Tienda Online",
                Direccion = "Calle falsa 123",
                CantidadVisitas = 1,
                Resumen = "Lalala",
                Slogan = "Tu tienda online"
            };

            Application["Tienda"] = miTienda;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}