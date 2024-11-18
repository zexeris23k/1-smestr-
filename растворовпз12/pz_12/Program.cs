using System;

namespace СреднееЗначениеМинимальныйИМаксимальныйЭлементы
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Численность группы = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Возраст {0}-го человека: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            double m = 0;
            for (int i = 0; i < n; i++)
                m += a[i];
            m /= n;

            int min = a[0];
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }

            Console.WriteLine("Итоги:");
            Console.WriteLine("Всего опрошено {0}", n);
            Console.WriteLine("Средний возраст = {0}", m);
            Console.WriteLine("Минимальный возраст = {0}", min);
            Console.WriteLine("Максимальный возраст = {0}", max);
            Console.ReadKey();
        }
    }
}
