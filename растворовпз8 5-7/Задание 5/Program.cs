using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        double interestRate;

        if (depositAmount < 100)
        {
            interestRate = 0.05;
        }
        else if (depositAmount >= 100 && depositAmount <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double interest = depositAmount * interestRate;
        double bonus = 15;
        double finalAmount = depositAmount + interest + bonus;

        Console.WriteLine($"Сумма вклада с начисленными процентами и бонусом: {finalAmount:C}");
    }
}