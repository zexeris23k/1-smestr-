using System;

namespace ПЗ_8_з1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго.");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго.");
            }
            else
            {
                Console.WriteLine("Оба числа равны.");
            }

            
            Console.ReadKey();
        }
    }
}
