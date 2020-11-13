using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_4._1._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = { 10, 15, 12 };
            int cantidad = 3;
            int i;
            int b;
            Console.WriteLine("¿Que dato estas buscando?");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Buscamos el dato "b"
            for (i = 0; i < cantidad; i++)
                if (datos[i] == b)
                    Console.WriteLine("{0} encontrado en la posición {1}", b, i + 1);
                else
                    Console.WriteLine("El dato no aperece en {0}", i + 1);
        }
    }
}
