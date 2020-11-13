using System;
using System.Diagnostics;
using System.Globalization;

namespace Ejercicio2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, primos;
            int i;
            numero = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= numero; i++);
            while (i % numero == 0)
            {
             Console.WriteLine("{0}", i);
                
            }
        }
    }
}
