using Ecommerce.Datos;
using Ecommerce.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Negocio
{
    public class ReportesNegocio
    {
        private ReportesDatos reportesDatos = new ReportesDatos();

        public List<ItemVentaPorCategoria> ReporteVentaPorCategoria(string categoria, string anio)
        {
            return reportesDatos.ObtenerVentaPorCategoria(categoria, anio);
        }
    }
}
