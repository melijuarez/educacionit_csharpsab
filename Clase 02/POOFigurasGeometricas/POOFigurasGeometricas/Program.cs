using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOFigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo miRectangulo = new Rectangulo();
            miRectangulo.Base = 10.5;
            miRectangulo.Altura = -20;
            miRectangulo.Identificador = 1;
            double areaMiRectangulo = miRectangulo.ObtenerArea();
            Console.WriteLine("El identificador es " + miRectangulo.ObtenerCodigoIdentificador());
            Console.WriteLine("El area del rectangulo es " + areaMiRectangulo);
            Console.WriteLine("El perimetro del area es " + miRectangulo.Perimetro);

            Rectangulo otroRectangulo = new Rectangulo();
            otroRectangulo.Base = -30;
            otroRectangulo.Altura = 10;
            otroRectangulo.Identificador = 2;
            double areaMiOtroRectangulo = otroRectangulo.ObtenerArea();
            Console.WriteLine("El identificador es " + otroRectangulo.ObtenerCodigoIdentificador("$"));
            Console.WriteLine("El area del rectangulo es " + areaMiOtroRectangulo);
            Console.WriteLine("El perimetro del area es " + otroRectangulo.Perimetro);

            FiguraGeometrica[] figuraGeometricas = new FiguraGeometrica[5];
            figuraGeometricas[0] = new Triangulo() { LadoA = 10, LadoB = 20, LadoC = 30 };
            figuraGeometricas[1] = new Rectangulo() { Altura = 100, Base = 1 };
            figuraGeometricas[2] = new Rectangulo() { Altura = 10, Base = 2 };
            figuraGeometricas[3] = new Rectangulo() { Altura = 30, Base = 3 };
            figuraGeometricas[4] = new Triangulo() { LadoA = 5, LadoB = 25, LadoC = 10 };

            for (int i = 0; i < figuraGeometricas.Length; i++)
            {
                Console.WriteLine("Area: " + figuraGeometricas[i].ObtenerPerimetro());
            }

            Mueble m1 = new Mueble();
            Mueble m2 = new Mueble(1);
            Mueble m3 = new Mueble(2, 2);

            Console.ReadKey();
        }
    }
}
