using System;

namespace Завдання1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть дійсне число а (a!=0): ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть натуральне число n:");
            int n = Convert.ToInt32(Console.ReadLine());

            double symm = 0;

            while (n>=1) 
            {
                symm = symm + Math.Log(Math.Pow(a,n));
                n--;
            }

            Console.WriteLine($"Сума= {symm}");
        }
    }
}
