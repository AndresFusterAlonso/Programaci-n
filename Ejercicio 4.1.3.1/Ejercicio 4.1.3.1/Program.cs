using System;

namespace Ejercicio_4._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 6 numeros enteros cortos y se los mostraremos en orden inverso");
            int[] numeros = new int[6];
            Console.WriteLine("numero 1");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 2");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 3");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 4");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 5");
            numeros[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 6");
            numeros[5] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", numeros[5], numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
            }   

        }
    }
}
