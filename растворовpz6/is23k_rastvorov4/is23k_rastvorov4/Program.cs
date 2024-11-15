using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваш номер телефона: ");
        long number = long.Parse(Console.ReadLine());

        string result = String.Format("{0:+# (###) ###-##-##}", number);
        Console.WriteLine(result);
    }
}