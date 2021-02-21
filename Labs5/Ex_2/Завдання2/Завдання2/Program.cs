using System;

namespace Завдання2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ціле число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int f = 0;

            while (n >= 0) 
            {
                f = n % 10;

                if (f == 0) 
                {
                    count++;
                }
                n = n / 10;
                if (n == 0) 
                {
                    break;
                }
            }


            Console.WriteLine($"Кількість нулів = {count}");
        }
    }
}
