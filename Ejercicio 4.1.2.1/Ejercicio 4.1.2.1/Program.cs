using System;

namespace Ejercicio_4._1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un mes con su respectivo numero y te diremos cuantos días tiene");
            int[] meses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;
            try
            {
                Console.WriteLine("El mes tiene {0} días.", meses[mes]);
            }
            catch(Exception)
            {
                Console.WriteLine("mes desconocido");
            }
            
        }
    }
}
