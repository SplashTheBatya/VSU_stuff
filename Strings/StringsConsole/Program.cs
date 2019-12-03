using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StringAnalyticsConsole stringAnalytics = new StringAnalyticsConsole(@"C:\Users\User\Desktop\text.txt");
            int iter = 0;
            do
            {
                Console.WriteLine("Введите одно из следующих значение: \n1 - Показать текст \n2 - Проанализировать текст,найти колличество и список слов, удовлетворяющих условию \n3 - Выйти ");
                iter = int.Parse(Console.ReadLine());
                switch (iter)
                {
                    case 1:
                        Console.WriteLine(stringAnalytics.ShowText());
                        break;
                    case 2:
                        Console.WriteLine("Колличество слов,удовлетворяющих условию: " + stringAnalytics.SpecialWordCounter());
                        var list = stringAnalytics.SpecialWordShow();
                        Console.WriteLine("Слова, удовлетворяющие словию: ");
                        foreach (var i in list)
                        {
                            Console.WriteLine(" " + i);
                        }
                        break;
                }

            } while (iter != 3);
        }
    }
}
