using System;
using System.Collections.Generic;
namespace Homework__4
{

    public enum GrouchinessLvl
    {
        s, a, b, c, d, e, f
    }
    public struct Ded
    {
        public string name;
        public string[] swearingPhrases;
        public byte sinyaki0;
        public GrouchinessLvl g;
        public byte SinyakiOtBabki(Ded ded ,params string[] phrases)
        {
            byte sinyaki = ded.sinyaki0;
            string[] phrases0 = ded.swearingPhrases;
            foreach (string s0 in phrases0) 
            {
                foreach (string s in phrases)
                {
                    if (s0 == s)
                    {
                        sinyaki++;
                    }
                }
            }
            return sinyaki;
        }
    }
    internal class Program
    {
        static double MasArythms(ref double multiply, out double masAverage, params double[] numbers)
        {
            double sum = 0;
            
            foreach (var number in numbers)
            {
                multiply *= number;
            }

            foreach (var number in numbers)
            {
                sum += number;
            }

            masAverage = sum/numbers.Length;

            return sum;
        }
        static void Main(string[] args)
        {
            //1
            
            Console.WriteLine("1 Упражнение");

            int[] arr = new int[20];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100000, 100000);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Введите числа, которые хотите поменять местами:");

            int.TryParse(Console.ReadLine(), out var a);
            int.TryParse(Console.ReadLine(), out var b);
            
            bool flag1 = false, flag2 = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (a == arr[i])
                {
                    a = i;
                    flag1 = true;
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (b == arr[i])
                {
                    b = i;
                    flag2 = true;
                    break;
                }
            }
            if (flag1 && flag2)
            {
                int c = arr[a];
                arr[a] = arr[b];
                arr[b] = c;
                
                Console.WriteLine("Вот массив с поменявшимися местами указанными элементами ");
                
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Указанного(ых) элемента(ов) нет в данном массиве");
            }

            Console.WriteLine();

            //2
            Console.WriteLine("2 Упражнение");
            double multiply = 1;
            double masAverage = 0;
            
            List<double> mas = new List<double>();
            
            Console.Write("Введите количество элементов массива:");
            uint.TryParse(Console.ReadLine(), out var len);

            Console.WriteLine("Введите элементы массива построчно:");
            for (int i = 0; i < len; i++) 
            {
                double.TryParse(Console.ReadLine(), out var m);
                mas.Add(m);
            }
            
            double[] mas1 = mas.ToArray();

            Console.WriteLine($"Сумма элементов массива равна: {MasArythms(ref multiply, out masAverage, mas1)}");
            Console.WriteLine($"Произведение элементов массива равно:{multiply}");
            Console.WriteLine($"Среднее арифметическое элементов массива равно:{masAverage}");

            Console.WriteLine();

            //3
            Console.WriteLine("3 Упражнение");
            Console.WriteLine("Введите целое число от 0 до 9");

            int digit = Convert.ToInt32(Console.ReadLine());
            switch (digit)
            {
                case 0:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 1:
                    Console.WriteLine("  #");
                    Console.WriteLine(" ##");
                    Console.WriteLine("# #");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    break;
                case 2:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    break;
                case 3:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                case 4:
                    Console.WriteLine("# #");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("  #");
                    break;
                case 5:
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                case 6:
                    Console.WriteLine("###");
                    Console.WriteLine("#  ");
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 7:
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine(" # ");
                    Console.WriteLine("#  ");
                    Console.WriteLine("# ");
                    break;
                case 8:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    break;
                case 9:
                    Console.WriteLine("###");
                    Console.WriteLine("# #");
                    Console.WriteLine("###");
                    Console.WriteLine("  #");
                    Console.WriteLine("###");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.WriteLine("### # # # #   # ##### #  #   #   #");
                    Console.WriteLine("# # # # # #  ## #     # #   # #  #");
                    Console.WriteLine("# # # # # # # # ##### ##   #   # #");
                    Console.WriteLine("# # # # # ##  # #   # # #  ##### ");
                    Console.Write    ("### ##### #   # ##### #  # #   # #");
                    
                    System.Threading.Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Введите 'закрыть' или 'exit' если хотите закрыть консоль");
            string exit = Console.ReadLine();
            if (exit == "exit" || exit == "закрыть")
            {
                Environment.Exit(0);
            }
            
            Console.WriteLine();

            //4
            Console.WriteLine("4 Упражнение");

            Console.WriteLine();

            string[] babkasWords = { "Дураки", "Мрази", "Ироды", "Погань", "Остолопы" };
            
            Ded ded1 = new Ded();
            ded1.name = "Иван";
            ded1.g = GrouchinessLvl.e;
            string[] swearingPh1 = {"Дураки", "Гады", "Негодяи"};
            ded1.swearingPhrases = swearingPh1;
            ded1.sinyaki0 = 1;
            
            Console.WriteLine($"Дед {ded1.name}");
            Console.WriteLine($"Количество синяков до бабки: {ded1.sinyaki0}");
            Console.WriteLine($"Количество синяков после бабки:{ded1.SinyakiOtBabki(ded1, babkasWords)}");

            Console.WriteLine();

            Ded ded2 = new Ded();
            ded2.name = "Степан";
            ded2.g = GrouchinessLvl.b;
            string[] swearingPh2 = { "Дураки", "Гады", "Ироды", "Лиходеи", "Скотины" };
            ded2.swearingPhrases = swearingPh2;
            ded2.sinyaki0 = 2;

            Console.WriteLine($"Дед {ded2.name}");
            Console.WriteLine($"Количество синяков до бабки: {ded2.sinyaki0}");
            Console.WriteLine($"Количество синяков после бабки:{ded2.SinyakiOtBabki(ded2, babkasWords)}");

            Console.WriteLine();

            Ded ded3 = new Ded();
            ded3.name = "Виталий";
            ded3.g = GrouchinessLvl.c;
            string[] swearingPh3 = {"Дармоеды", "Гады", "Дураки", "Погань", "Негодяи" };
            ded3.swearingPhrases = swearingPh3;

            Console.WriteLine($"Дед {ded3.name}");
            Console.WriteLine($"Количество синяков до бабки: {ded3.sinyaki0}");
            Console.WriteLine($"Количество синяков после бабки:{ded3.SinyakiOtBabki(ded3, babkasWords)}");

            Console.WriteLine();

            Ded ded4 = new Ded();
            ded4.name = "Анатолий";
            ded4.g = GrouchinessLvl.d;
            string[] swearingPh4 = { "Дураки", "Ироды", "Лиходеи", "Остолопы" };
            ded4.swearingPhrases = swearingPh4;
            ded4.sinyaki0 = 2;

            Console.WriteLine($"Дед {ded4.name}");
            Console.WriteLine($"Количество синяков до бабки: {ded4.sinyaki0}");
            Console.WriteLine($"Количество синяков после бабки:{ded4.SinyakiOtBabki(ded4, babkasWords)}");

            Console.WriteLine();

            Ded ded5 = new Ded();
            ded5.name = "Митрофан";
            ded5.g = GrouchinessLvl.s;
            string[] swearingPh5 = { "Дураки", "Ироды", "Лиходеи", "Остолопы", "Погань", "Дармоеды", "Гады", "Негодяи", "Скотины", "Мрази"};
            ded5.swearingPhrases = swearingPh5;
            ded5.sinyaki0 = 15;

            Console.WriteLine($"Дед {ded5.name}");
            Console.WriteLine($"Количество синяков до бабки: {ded5.sinyaki0}");
            Console.WriteLine($"Количество синяков после бабки:{ded5.SinyakiOtBabki(ded5, babkasWords)}");

        }
    }
}
