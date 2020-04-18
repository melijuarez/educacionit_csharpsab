using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    public class Triangulo: FiguraGeometrica
    {
        public double LadoA { get; set; }

        public double LadoB { get; set; }

        public double LadoC { get; set; }

        public override double ObtenerPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
