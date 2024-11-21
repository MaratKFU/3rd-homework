using System;


namespace Homework__3
{

    internal class Program
    {

        
        static byte[] monthsNumDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, 0};
        static string[] monthsNames =
        {
            "Января",
            "Февраля",
            "Марта",
            "Апреля",
            "Мая",
            "Июня",
            "Июля",
            "Августа",
            "Сентября",
            "Октября",
            "Ноября",
            "Декабря",
            ""
        };


        static bool IsLeap(ulong year)
        {
            return (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
        }

    static void Main(string[] args)
        {
            /*Программа читает с экрана число от 1 до 365 (номер дня в году), 
            переводит этот число в месяц и день месяца.
             */
            Console.Write("Введите год (в случае некорректного ввода ему присвоится значение 0):");
            ulong.TryParse(Console.ReadLine(), out var year);

            Console.Write("Введите номер дня в году(число от 1 до 365(до 366 если год високосный)):");
            ushort.TryParse(Console.ReadLine(), out var day);

            while (day < 1 || (!IsLeap(year) && day > 365) || (IsLeap(year) && day > 366))
            {
                Console.Write("Вы ввели невозможный номер дня в году, попробуйте ещё раз:");
                ushort.TryParse(Console.ReadLine(), out day);
            }

            if (IsLeap(year)) 
            {
                monthsNumDays[1]++;
            }
            
            int i = 0;
            for (i = 0; day - monthsNumDays[i] > 0; i++)
            {
                day -= monthsNumDays[i];
            }

            Console.WriteLine($"Дата вашего дня:{day} {monthsNames[i]}");
        }

    }
}
