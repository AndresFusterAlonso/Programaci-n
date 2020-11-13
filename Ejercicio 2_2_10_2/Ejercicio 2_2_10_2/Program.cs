using System;

namespace Ejercicio_2_2_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int i;
            int maximo;
            int mcm;
           
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            maximo = (a > b ? a : b );
            for (i = 2; i <= maximo; i++)
                if (a * i == b * i)
                    break;
            mcm = i;
            Console.WriteLine("El mínimo común múltiplo de {0} y {1} es {2}", a, b, mcm);

                


        }
    }
}
