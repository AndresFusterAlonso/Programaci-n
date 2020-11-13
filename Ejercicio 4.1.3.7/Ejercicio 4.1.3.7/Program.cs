using System;

namespace Ejercicio_4._1._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres= new string[100];
            string nombre = "";
            int i = 0;
            Console.WriteLine("Introduce un nombre (vacio para salir")
            nombre = Console.ReadLine();
            while (nombre != "" && (i < 100)) 
            {
                nombres[i] = nombre;
                i++;
                Console.Write("Introduce un nombre (vacio para salir):");
                nombre = Console.ReadLine();

            }
            for (int j = 0; j < i; j++)
            Console.WriteLine(nombres[j]);
        }
    }
}
