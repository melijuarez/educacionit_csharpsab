using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo una lista de 10 nombres
            string[] nombres = new string[10];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese un nombre: ");
                string nombreingresado = Console.ReadLine();
                nombres[i] = nombreingresado;
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            //Pedir 10 numeros
            int[] numeros = new int[10];
            for(int i =0; i< numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                string numeroIngresado = Console.ReadLine();
                int numero = Convert.ToInt32(numeroIngresado);
                numeros[i] = numero;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            int mayor = numeros[0];

            for(int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            Console.WriteLine("El numero mayor es el " + mayor);

            Console.ReadKey();
        }
    }
}
