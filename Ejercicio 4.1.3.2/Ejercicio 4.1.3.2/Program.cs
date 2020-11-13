using System;

namespace Ejercicio_4._1._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos numeros enteros va a introducir?");
            int numeros = Convert.ToInt32(Console.ReadLine());
            int[] guardados = new int[numeros];
            int media = 0;
            for(int b=0;b<numeros;b++)
            {
                Console.WriteLine("introduce el numero");
                guardados[b] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ha escrito {0}", guardados[b]);
            }
            for (int b = 0; b < numeros; b++)
            {

                media += guardados[b];
                Console.WriteLine("media:{0}",media);
            }

        }
    }
}
