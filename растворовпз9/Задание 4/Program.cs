using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число от 0 до 10:");
            if (!int.TryParse(Console.ReadLine(), out int num1) || num1 < 0 || num1 > 10)
            {
                Console.WriteLine("Некорректное первое число. Введите число от 0 до 10.");
                continue;
            }

            Console.WriteLine("Введите второе число от 0 до 10:");
            if (!int.TryParse(Console.ReadLine(), out int num2) || num2 < 0 || num2 > 10)
            {
                Console.WriteLine("Некорректное второе число. Введите число от 0 до 10.");
                continue;
            }

            Console.WriteLine($"Результат умножения: {num1 * num2}");
            break;
        }
    }
}