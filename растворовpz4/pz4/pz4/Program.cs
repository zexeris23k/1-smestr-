using System;
namespace Programm_1
{
    class Programm
    {
        static void Main()
        {
            // 1способ
            int intValue = 10;
            byte byteValue = Convert.ToByte(intValue);
            long longValue = intValue;
            float floatValue = intValue;
            double doubleValue = intValue;
            Console.WriteLine($"Переменная типа int = {intValue}");
            Console.WriteLine($"Переменная типа byte = {byteValue}");
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}");
            Console.WriteLine($"Переменная типа double = {doubleValue}");
            // 2 способ
            int intValue2 = 10;
            byte byteValue2 = (byte)intValue2;
            long longValue2 = intValue2;
            float floatValue2 = intValue2;
            double doubleValue2 = intValue2;
            Console.WriteLine($"Переменная типа int = {intValue2}");
            Console.WriteLine($"Переменная типа byte = {byteValue2}");
            Console.WriteLine($"Переменная типа long = {longValue2}");
            Console.WriteLine($"Переменная типа float = {floatValue2}");
            Console.WriteLine($"Переменная типа double = {doubleValue2}");
        }
    }
}