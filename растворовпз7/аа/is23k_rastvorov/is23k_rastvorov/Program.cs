using System;

class Program
{
    static void Main()
    {
        string text = "Я скоро поеду на научную конференцию в Курск";
        int index = text.IndexOf("Курск");
        Console.WriteLine($"Индекс слова 'Курск': {index}");

        text = text.Replace("в Курск", "");
        text = text.Replace("научную конференцию", "соревнование");

        text = text.ToUpper();
        Console.WriteLine(text);
    }
}