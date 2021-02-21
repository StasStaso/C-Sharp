using System;

namespace Завдання4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер n-го елемента: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int x1 = 1;
            int x0 = 1;
            int xi = 0;
            
            for (int i = 2; i < n+1; i++)
            {
                xi = x1 + 2 * x0;
                x0 = x1;
                x1 = xi;
            }

            Console.WriteLine($"xn= {xi}");
        }
    }
}
