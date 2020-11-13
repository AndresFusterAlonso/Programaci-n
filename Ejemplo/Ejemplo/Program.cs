using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            try
            {
                Console.WriteLine("Introduzca el primer numero");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 / numero2;
                Console.WriteLine("Su división es: {0}", resultado);
            }
            catch (Exception e)
            {
                if (e is FormatException)
                    Console.WriteLine("Error capturado : numero introducido incorrecto");
                else
                    if (e is DivideByZeroException)
                    Console.WriteLine("Error capturado : no se pude dividir entere cero");
                else
                    Console.WriteLine("Error capturado :{0}", e.Message);


            }
        }
    }
}
