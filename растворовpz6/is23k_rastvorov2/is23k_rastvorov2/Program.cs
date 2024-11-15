using System;
class Program
{
    static void Main()
    {
        string lastName = "растворов";
        string birthDate = "13.11.2007";
        string birthPlace = "курск";
        int age = 17;
        Console.WriteLine($"Фамилия: {lastName}");
        Console.WriteLine($"Дата рождения: {birthDate}");
        Console.WriteLine($"Место рождения: {birthPlace}");
        Console.WriteLine($"Возраст: {age} лет");
    }
}