﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatString();
            JoinString();
            CompareStrings();
            FindInString();
            InsertString();
            ReplaceString();
            UpperLowerString();
        }

        static void ConcatString()
        {
            string s1 = "Привет,";
            string s2 = "мир!";
            string s3 = s1 + s2;
            string s4 = string.Concat(s3, "!!!");
            Console.WriteLine(s4);
        }

        static void JoinString()
        {
            string s5 = "каждый";
            string s6 = "охотник";
            string s7 = "желает";
            string s8 = "знать";
            string s9 = "где сидит";
            string s10 = "фазан";
            string[] values = new string[] { s5, s6, s7, s8, s9, s10 };
            string s11 = String.Join(" ", values);
            Console.WriteLine(s11);
        }

        static void CompareStrings()
        {
            string s1 = "Привет,";
            string s2 = "мир!";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 стоит перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
        }

        static void FindInString()
        {
            string s1 = " привет, мир!";
            char ch = 'т';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine($"Индекс символа '{ch}' в строке '{s1}' - {indexOfChar}");

            string subString = "рив";
            int indexOfSubstring = s1.IndexOf(subString);
            Console.WriteLine($"Индекс подстроки '{subString}' в строке '{s1}' - {indexOfSubstring}");
        }

        static void InsertString()
        {
            string text = "Задание выполнено";
            int ind = text.Length - 1;
            text = text.Remove(ind);
            Console.WriteLine(text);
            text = text.Remove(0, 2);
            Console.WriteLine(text);
        }

        static void ReplaceString()
        {
            string text = "Солнечная утро";
            text = text.Replace("Солнечная", "Дождливое");
            Console.WriteLine(text);
        }

        static void UpperLowerString()
        {
            string hello = "Привет, мир!";
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
        }
    }
}