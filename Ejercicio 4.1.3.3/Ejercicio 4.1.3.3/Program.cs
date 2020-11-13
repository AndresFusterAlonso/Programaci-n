using System;

namespace Ejercicio_4._1._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int dias;
            int mes;
            int numeroDias = 0;
            Console.WriteLine("mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dia:");
            dias = Convert.ToInt32(Console.ReadLine());
            mes--;
            for (int i=0;i<mes;i++)
            {
                numeroDias += meses[i];
            }
            numeroDias += dias;
            Console.WriteLine("Han transcurrido {0} dias.", numeroDias);
        }
    }
}
