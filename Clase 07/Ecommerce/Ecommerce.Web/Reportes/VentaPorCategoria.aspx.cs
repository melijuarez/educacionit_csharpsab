using Ecommerce.EntidadesDeNegocio;
using Ecommerce.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce.Web.Reportes
{
    public partial class VentaPorCategoria : System.Web.UI.Page
    {
        private ReportesNegocio reportesNegocio = new ReportesNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<ItemVentaPorCategoria> resultado = reportesNegocio.ReporteVentaPorCategoria(txtCategoria.Text, txtAnio.Text);
        }
    }
}