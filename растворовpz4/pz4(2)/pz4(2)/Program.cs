using System;
namespace Programm_2
{
    class Programm
    {
        static void Main()
        {
            //1 способ
            float floatValue = 10.32f;
            byte byteValue = Convert.ToByte(floatValue);
            long longValue = Convert.ToInt64(floatValue);
            int intValue = Convert.ToInt32(floatValue);
            double doubleValue = floatValue;
            Console.WriteLine($"Переменная типа int = {intValue}");
            Console.WriteLine($"Переменная типа byte = {byteValue}");
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}");
            Console.WriteLine($"Переменная типа double = {doubleValue}");
            //2 способ
            float floatValue2 = 10.32f;
            byte byteValue2 = (byte)floatValue2;
            long longValue2 = (long)floatValue2;
            int intValue2 = (int)floatValue2;
            double doubleValue2 = floatValue2;
            Console.WriteLine($"Переменная типа int = {intValue2}");
            Console.WriteLine($"Переменная типа byte = {byteValue2}");
            Console.WriteLine($"Переменная типа long = {longValue2}");
            Console.WriteLine($"Переменная типа float = {floatValue2}");
            Console.WriteLine($"Переменная типа double = {doubleValue2}");
        }
    }
}