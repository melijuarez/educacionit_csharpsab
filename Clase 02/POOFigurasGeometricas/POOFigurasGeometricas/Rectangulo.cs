using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    /*
     * internal (o nada) la clase es visible en el mismo "proyecto" (O ensamblado)
     * private, solo es visible por la misma clase
     * public, la clase es visible para todos
     */
    public class Rectangulo: FiguraGeometrica
    {
        /*
         * protected (o nada) interna al objeto de la clase o a hijos de la clase
         * private, es visible solo por el propio objeto de la clase
         * public, es visible para todos
         */
        private double _base;

        public double Base
        {
            get
            {
                return _base;
            }
            set
            {
                if (value > 0)
                {
                    _base = value;
                }
                else
                {
                    _base = 0;
                }
            }
        }

        private double _altura;
        public double Altura
        {
            get
            {
                return _altura;
            }
            set
            {
                if(value > 0)
                {
                    _altura = value;
                }
                else
                {
                    _altura = 0;
                }
            }
        }

        public double Perimetro => 2 * Altura + 2 * Base;

        /*
         * Equivalente a:
         public double Perimetro{
            get{
                return 2 * Altura + 2 * Base;
            }
         }
        */

        public double ObtenerArea()
        {
            double area = Base * Altura;
            return area;
        }

        public override double ObtenerPerimetro()
        {
            return Perimetro;
        }
    }
}