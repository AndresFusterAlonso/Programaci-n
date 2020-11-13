using System;
public class Ejemplo_04_03_02a
{
    struct tipoMp3
    {
        int Artista
        public string canción;
        public char titulo;
        public int edad;
        public float nota;
    }
    public static void Main()
    {
        tipoMp3[] Mp3 = new tipoMp3[100];
        Console.WriteLine("Añadir nueva canción");
        Console.WriteLine("Nombre del Artista bb");
        Mp3[0]..Artistas = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Titulo de la canción bb");
        mp3.titulo = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Duración en segundos de la canción bb");
        mp3.duración = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tamaño en KB de la canción bb");
        mp3.tamaño = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("titulo de la canción");
        Mp3[0].titulo = 'J';
        Console.WriteLine("Buscar canción por cierto texto");
        Mp3[0].edad = 20;
        Console.WriteLine("La edad de {0} es {1}",

        Mp3[0].canción, Mp3[0].edad);
        Mp3[1].canción = "Pedro";
        Console.WriteLine("La edad de {0} es {1}",
        Mp3[1].canción, Mp3[1].edad);
    }
}
