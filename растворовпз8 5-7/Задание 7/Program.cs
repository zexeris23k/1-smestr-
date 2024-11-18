using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        int operationNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operationNumber)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            default:
                Console.WriteLine("Операция неопределена.");
                break;
        }

        if (operationNumber >= 1 && operationNumber <= 3)
        {
            Console.WriteLine($"Результат: {result}");
        }
    }
}