using System;

namespace Ejercicio_4._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 6 cadenas de texto en cada uno de los dos bloques");
            string[][] cadenas;
            cadenas = new string[2][];
            cadenas[0] = new string[6];
            cadenas[1] = new string[6];
            for (int i = 0; i < cadenas.Length; i++)
            {
                for (int j = 0; j < cadenas[i].Length; j++)

            }
            for (int i = 0; i < cadenas.Length; i++)
            {
                for (int j = 0; j < cadenas[i].Length; j++)
                {
                    cadenas[i][j] = Convert.ToString(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}
