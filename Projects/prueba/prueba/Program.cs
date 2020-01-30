using System;

namespace prueba
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            /* 
             Console.WriteLine("Introduce un número: ");
             float n = float.Parse(Console.ReadLine());

             for (int i = 1; i <= v.Length; i++)
             {
                 Console.WriteLine(i + "*" + n + "=" + n * i + "\t\t" + i + "/" + n + "=" + (i/n) + "\t\t" + i + "+" + n + "=" + (i + n) + "\t\t" + i + "-" + n + "=" + (i - n));
             }
             */
            Console.WriteLine("Introduce el tamaño del vector");
            int tam = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el minimo");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el maximo");
            int max = int.Parse(Console.ReadLine());

            int[] v = new int[tam];
            Console.WriteLine("Normal:");
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = (int)((r.NextDouble()*(max-min)) + min);
                Console.Write(v[i] + " ");
            }
            Array.Sort(v);
            Console.WriteLine("\nOrdenado:");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

    }
}