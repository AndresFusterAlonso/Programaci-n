using System;
using System.Net;

namespace Ejecicio_4._1._3._11
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] numeros = new int[4];
            int mayor = Int32.MinValue;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Numero {0}:", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {

                if (numeros[i] > mayor)
                    mayor = numeros[i];
            }
            Console.WriteLine("El mayor es {0}.", mayor);
        }
            
    }
}