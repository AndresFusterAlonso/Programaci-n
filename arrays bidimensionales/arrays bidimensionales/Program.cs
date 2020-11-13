using System;
using System.ComponentModel;
using System.Globalization;

namespace arrays_bidimensionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 10 numeros en dos bloques");
            int[][] numeros;
            numeros = new int[2][];
            numeros[0] = new int[10];
            numeros[1] = new int[10];
            for (int i = 0; i < numeros.Length ; i++)
            {
                for (int j = 0; j < numeros[i].Length; j++)
                {
                    numeros[i][j] = i + j;
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros[i].Length; j++)
                {
                    numeros[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            if (numeros[0].Length == 10)
                Console.WriteLine("{0}", numeros[0]);
        }
    }
}
