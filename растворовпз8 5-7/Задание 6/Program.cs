using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");

        int operationNumber = Convert.ToInt32(Console.ReadLine());

        switch (operationNumber)
        {
            case 1:
                Console.WriteLine("Операция: Сложение");
                break;
            case 2:
                Console.WriteLine("Операция: Вычитание");
                break;
            case 3:
                Console.WriteLine("Операция: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}