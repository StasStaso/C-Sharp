using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int d = 1;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            foreach (int j in a)
            {                
                d *= j;
            }

            Console.WriteLine();
            Console.WriteLine($"{d}");

            double g = 0;
            double k = 1 / (double)n;

            if (d > 0)
            {
                g = g + Math.Pow(d,k);
                Console.WriteLine($"Середнє геометричне {g}");
            }
            else 
            {
                Console.WriteLine("Середнього геометричного немає, оскільки добуток від'ємний");
            }


            
        }
    }
}
