using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal finalAmount = depositAmount;

        for (int i = 0; i < months; i++)
        {
            decimal interest = finalAmount * 0.07m;
            finalAmount += interest;
        }

        Console.WriteLine($"Конечная сумма вклада: {finalAmount:C}");
    }
}