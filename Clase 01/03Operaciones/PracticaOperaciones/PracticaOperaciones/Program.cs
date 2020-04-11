using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 10;
            int numeroDos = 20;
            int numeroTres = 35;

            //Operacion Suma
            int resultadoSuma = numeroUno + numeroDos;
            Console.WriteLine("El resultado de la suma es " + resultadoSuma);

            //Operacion Resta
            int resultadoResta = numeroTres - numeroDos;
            Console.WriteLine("El resultado de la resta es " + resultadoResta);

            int resultadoMultiplicacion = numeroUno * numeroDos;
            Console.WriteLine("El resultado de la multiplicacion es " + resultadoMultiplicacion);

            int resultadoDivision = numeroTres / numeroDos;
            //Console.WriteLine("El resultado de la división es " + resultadoDivision);
            Console.WriteLine("El resultado de {0} es {1}", "la division", resultadoDivision);

            int resultadoModulo = numeroTres % numeroDos;
            Console.WriteLine("El resultado del modulo entre {0} y {1} es {2}", numeroTres, numeroDos, resultadoModulo);


            Console.ReadKey();

        }
    }
}
