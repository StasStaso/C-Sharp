using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Array.Sort(a);
            Array.Reverse(a);
        
            Console.WriteLine("Елементи масиву за спаданням");

            foreach (int j in a)
            {
                Console.Write($"{j} ");
            }
        }
    }
}
