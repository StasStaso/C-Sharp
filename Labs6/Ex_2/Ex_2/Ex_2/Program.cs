using System;
using System.Threading;

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int d = 0;

            foreach (int j in a)
            {
                
            }
        }
               
    }   
}

