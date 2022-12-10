using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tumakov
{
    class Program
    {
        public static double MaxChislo(double x, double y)
        {
            return Math.Max(x, y);
        }
        public static void PermutationRef(ref double ch1, ref double ch2)
        {
            double temp = ch1;
            ch1 = ch2;
            ch2 = temp;
        }

        public static bool FactorialRef(ref int num)
        {
            int nomer = num;
            num = 1;
            for (int i = 1; i <= nomer; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }
                }
                catch
                {
                    return false;
                }
            return true;
        }

        static int Factorial_recurs(int f)
        {
            int rez = 1;
            do
            {
                if (f < 0)
                {
                    Console.WriteLine("Введенное вами число некорректно");
                }
                else if (f == 0)
                {
                    rez = 1;
                }
                else
                {
                    rez = f * rez;
                    f = f - 1;
                }

            } while (f > 0);
            Console.WriteLine($"Факториал введенного вами числа равен {rez}");
            return rez;
        }

        public static int NOD(int val1, int val2)
        {
            while ((val1 != 0) && (val2 != 0))
            {
                if (val1 > val2)
                {
                    val1 -= val2;
                }
                else
                    val2 -= val1;
            }

            return Math.Max(val1, val2);
        }

        public static int NOD_(int a, int b, int c)
        {
            int Nod = Math.Min(a, Math.Min(a, b));
            for (; Nod > 1; Nod--)
            {
                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                    break;
            }
            return Nod;
        }

        static int Fibonachi_recurs(int num)
        {
            int a1 = 0;
            int a2 = 1;
            if (num <= 1) return 0;
            for (int i = 2; i < num; i++)
            {
                int temp = a1;
                a1 = a2;
                a2 = a2 + temp;
            }
            return a2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков задание 5.1, метод, возвращающий наибольшее число");
            Console.Write($"Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write($"Введите второе число : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Максимальное из этих чисел: {MaxChislo(a, b)}");
            Console.WriteLine();


            Console.WriteLine("Тумаков задание 5.2, метод меняющий местами введенные местами");
            Console.WriteLine("Введите 2 числа: ");
            double ch1 = double.Parse(Console.ReadLine());
            double ch2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Числа до перестановки: {ch1}, {ch2}");
            Console.WriteLine($"Числа после перестановки: {ch2}, {ch1}");
            Console.WriteLine();


            Console.WriteLine("Тумаков задание 5.3, метод вычисления факториала числа");
            Console.Write("Введите число, факториал которого нужно вычислить: ");
            int chislo = int.Parse(Console.ReadLine());
            bool result = FactorialRef(ref chislo);
            Console.WriteLine($"{Convert.ToString(result)}, Факториал введенного вами числа равен {chislo}");
            Console.WriteLine();


            Console.WriteLine("Тумаков задание 5.4, рекурсивный мeтод вычисления факторила");
            Console.Write("Введите число, факториал которого нужно вычислить: ");
            int chisloo = int.Parse(Console.ReadLine());
            Factorial_recurs(chisloo);


            Console.WriteLine("Тумаков домашнее залание 5.1, метод вычисления НОД");
            Console.WriteLine("Введите 2 числа для вычисления НОД ");
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int Nod1 = NOD(a1, b1);
            Console.WriteLine($"Наибольший общий делитель равен {Nod1}");

            Console.WriteLine("Введите 3 числа для вычисления НОД ");
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int Nod2 = NOD_(a2, b2, c2);
            Console.WriteLine($"Наибольший общий делитель равен {Nod2}");
            Console.WriteLine();

            Console.WriteLine("Тумаков задание 5.2, числа Фибоначчи рекурсивным методом");
            Console.Write("Введите номер элемента ряла Фибоначчи: ");
            int nomer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент под номером {nomer} - {Fibonachi_recurs(nomer)}");
        }
    }
}
