using System;

namespace Tumakov
{
    internal class Program
    {
        static long Max1(long a, long b)
        {
            if (a > b) 
            {
                return a;
            }
            return b;
        }

        
        static void SwapValues(ref string a, ref string b)
        {
            string c = a; a = b; b = c;
        }
        static ulong RecFactorial(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }
            return RecFactorial(n-1) * n;
        }

        static bool TryFactorial(ulong n)
        {
            ulong res = 1;

            try
            {
                checked
                {
                    for (ulong i = 1; i <= n; i++)
                    {
                        res *= i;
                    }
                }
                return true;
            }
            catch (OverflowException) 
            {
                return false;
            }
        }

        static ulong GCD(ulong a, ulong b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            if (a > b)
            {
                return GCD(a % b, b);

            }
            return GCD(a, b % a);
        }

        static ulong GCD(ulong a, ulong b, ulong c)
        {
            return GCD(a, GCD(b, c));
        }


        static ulong Fibonacci(byte n)
        {
            ulong a = 1;
            ulong b = 1;
            for (byte i = 2;i < n; i++)
            {
                if (i % 2 == 0)
                {
                    a += b;
                }
                else
                {
                    b += a;
                }
            }
            return Math.Max(a, b);
        }
        
        static void Main(string[] args)
        {
            //1 Упражнение
            
            Console.WriteLine("Упражнение 5.1");

            Console.WriteLine("Введите два целых числа:");
            
            long.TryParse(Console.ReadLine(), out var a);
            long.TryParse(Console.ReadLine(), out var b);
            
            Console.WriteLine($"Наибольшее из них равняется {Max1(a, b)}");
            
            Console.WriteLine();
            
            
            
            //2 Упражнение
            
            Console.WriteLine("Упражнение 5.2");
            
            Console.WriteLine("Введите два значения:");
            
            string param1 = Console.ReadLine();
            string param2 = Console.ReadLine();
            
            SwapValues(ref param1, ref param2);
            Console.WriteLine($"Вот ваши значения, но поменявшиеся местами:{param1} {param2}");
            
            Console.WriteLine();
            
            
            
            //3 Упражнение

            Console.WriteLine("Упражнение 5.3");
            
            Console.Write("Введите значение числа n для проверки на переполнение значений типа ulong для числа n!:");
            
            ulong.TryParse(Console.ReadLine(), out var n1);
            
            if (TryFactorial(n1))
            {
                Console.WriteLine($"Вычисление числа {n1}! не вызвало переполнения значений типа ulong");
            }

            else
            {
                Console.WriteLine($"Вычисление числа {n1}! вызвало переполнение значений типа ulong");
            }
            
            Console.WriteLine();
            
            
            
            //4 Упражнение
            
            Console.WriteLine("Упражнение 5.4");
            
            Console.Write("Введите значение числа n для вычисления n!:");
            
            ulong.TryParse(Console.ReadLine(), out var n2);
            Console.WriteLine($"{n2}! = {RecFactorial(n2)}");

            Console.WriteLine();
            

            
            //1 ДЗ
            
            Console.WriteLine("Домашнее задание 5.1");
            
            Console.WriteLine("Эта программа находит НОД двух или трёх чисел");
            Console.WriteLine("Введите количество чисел, для которых хотите вычислить НОД:");
            
            byte.TryParse(Console.ReadLine(), out var n);
            
            switch (n){
                case 2:
                    Console.WriteLine("Введите эти два числа построчно:");

                    ulong.TryParse(Console.ReadLine(), out var a1);
                    ulong.TryParse(Console.ReadLine(), out var b1);

                    Console.WriteLine(GCD(a1, b1));
                    break;
                
                case 3:
                    Console.WriteLine("Введите эти три числа построчно:");
                    
                    ulong.TryParse(Console.ReadLine(), out a1);
                    ulong.TryParse(Console.ReadLine(), out b1);
                    ulong.TryParse(Console.ReadLine(), out var c1);
                    
                    Console.WriteLine(GCD(a1, b1, c1));
                    break;
            
                default:
                    Console.WriteLine($"Данная программа не умеет вычислять НОД для {n} чисел");
                    break;

            }
            
            
            
            //2 ДЗ
            
            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Введите число n для вычисления n-ного числа Фибоначчи");
            
            byte.TryParse(Console.ReadLine(), out var i);
            
            if (i == 0)
            {
                Console.WriteLine("Не существует числа с таким порядковым номером");
            }
            else 
            {
                Console.WriteLine($"Число Фибоначчи с порядковым номером {i} равно {Fibonacci(i)}");
            }
        }
    }
}
