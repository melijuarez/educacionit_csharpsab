using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWebDePruebas.Sumador
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtServidor.Text = "Cargado desde el servidor";

            //if(IsPostBack==false)
            if (!IsPostBack)
            {
                txtNumeroUno.Text = "0";
                txtNumeroDos.Text = "0";
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int nUno = Convert.ToInt32(txtNumeroUno.Text);
            int nDos = Convert.ToInt32(txtNumeroDos.Text);
            int resultado = nUno + nDos;
            lblResultado.Text = "Suma:" + resultado;
        }
    }
}