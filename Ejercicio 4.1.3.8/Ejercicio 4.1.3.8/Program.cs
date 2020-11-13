using System;
using System.Numerics;

namespace Ejercicio_4._1._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[3];
            double modulo = 0;
            for (int i = 0; i<3;i++)
            {

                Console.Write("componente {0}:",i+1);
                vector[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < 3; i++)
            {

                modulo += Math.Pow(vector[i], 2);
                Console.WriteLine("El módulo es {0}", modulo);
            }
        }
    }
}
