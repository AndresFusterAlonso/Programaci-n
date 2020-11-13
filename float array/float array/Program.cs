using System;

namespace float_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe 5 numeros");
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
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
        }
    }
}
