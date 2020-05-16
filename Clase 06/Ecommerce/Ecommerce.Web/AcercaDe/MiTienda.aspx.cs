using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.AcercaDe
{
    public partial class MiTienda : System.Web.UI.Page
    {
        private int contadorViewState = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                contadorViewState = (int)ViewState["contador"];
            }
            else
            {
                ViewState["contador"] = 0;
                if (Session["contador"] == null)
                {
                    Session["contador"] = 0;
                }
                lblContadorSesion.Text = Session["contador"].ToString();
            }

            Tienda miTienda = (Tienda)Application["Tienda"];
            lblContadorVisitasAplicacion.Text = miTienda.CantidadVisitas.ToString();

            
        }

        protected void btnContadorViewState_Click(object sender, EventArgs e)
        {
            //Primer opcion, leyendo desde el label de la pagina
            //string valorContador = lblContadorViewState.Text;
            //int valor = Convert.ToInt32(valorContador);
            //valor++;
            //lblContadorViewState.Text = valor.ToString();

            contadorViewState++;
            ViewState["contador"] = contadorViewState;
            lblContadorViewState.Text = contadorViewState.ToString();
        }

        protected void btnContadorSesion_Click(object sender, EventArgs e)
        {
            int contador = (int)Session["contador"];
            contador++;
            Session["contador"] = contador;
            lblContadorSesion.Text = contador.ToString();
        }
    }
}