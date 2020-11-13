using System;//"using system" en vez de "system.console"

namespace Ejercicio1_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            Console.WriteLine("introduce un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca un segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado");
            Console.WriteLine(numero1 / numero2);//Andres Fuster Alonso 17/09/2020

        }
    }
}
