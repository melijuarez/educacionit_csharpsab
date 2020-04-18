using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    public abstract class FiguraGeometrica: IColoreable
    {
        public int Identificador { get; set; }
        public int Color { get; set; }

        public string ObtenerCodigoIdentificador()
        {
            return "#" + Identificador;
        }

        public string ObtenerCodigoIdentificador(string prefijo)
        {
            return prefijo + Identificador;
        }

        public virtual double ObtenerPerimetro() {
            return -1;
        }

        public void Pintar(int Color)
        {
            this.Color = Color;
        }
    }
}
