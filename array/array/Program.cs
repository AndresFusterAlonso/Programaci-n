using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double [4];
            Console.WriteLine("numero 1:");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 2:");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 3:");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("numero 4:");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            double media = (numeros[0] + numeros[1] + numeros[2] + numeros[3])/4.0;
            Console.WriteLine("Su media aritmética de {0}, {1}, {2}, {3} es {4}", numeros[0], numeros[1], numeros[2], numeros[3], media);


        }
    }
}
