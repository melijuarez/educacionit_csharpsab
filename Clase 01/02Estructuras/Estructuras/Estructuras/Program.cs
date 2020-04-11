using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 10;
            int numeroDos = 30;
            int numeroTres = 10;

            //CONDICIONAL

            if (numeroUno != numeroTres)
            {
                Console.WriteLine("Se ejecutó el bloque if");
            }
            /*
             * == igualdad de comparacion
             * > mayor
             * < menor
             * >= mayor o igual
             * <= menor o igual
             * !=distinto
             */

            /*
             * && y logico
             * || o logico
             * ! negacion
             */

            //EJ: numeroUno == numeroTres && numeroDos < numeroTres

            //Iteradores
            //while
            int contador = 0;
            while (contador < 0)
            {
                Console.WriteLine("Contador es " + contador);
                contador++;
            }
            //do while
            int contador2 = 0;
            do
            {
                Console.WriteLine("Contador2 es " + contador2);
                contador2++;
            } while (contador2 < 0);
            //for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bucle for iteración numero " + i);
            }
            //for (A; B; C)
            //A inicializacion de la variable de control
            //B condicion de continuidad
            //C incremento de la variable de control

            Console.ReadKey();

        }
    }
}
