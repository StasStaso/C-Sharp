using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значення вимеров= ");            
            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                a[i] *= k;
            }

            Console.Write("добуток вектора на число = ");
            foreach (int i in a)
            {
                Console.Write($"{i} ");
            }


        }
    }
}
