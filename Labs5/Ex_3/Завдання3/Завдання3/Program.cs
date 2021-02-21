using System;

namespace Завдання3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть змінну х (від -1 до1): ");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("Введіть точність е: ");
            float e = float.Parse(Console.ReadLine());

            double s = 0;
            int a = 1;


            while (Math.Abs((Math.Pow(x,a) / a)) > e) 
            {
                s = s - (Math.Pow(x,a))/a;
                a++;
            }

            Console.WriteLine($"Сума = {s}");


            if ((Math.Log(1 - x) - s )< e)
            {
                Console.WriteLine("Рівність справедлива S=log(1-x)");
            }
            else 
            {
                Console.WriteLine("Рівність не cправедлива");
            }

        }
    }
}
