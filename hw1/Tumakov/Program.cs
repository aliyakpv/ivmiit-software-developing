using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков 2.1 приветствие");
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.ReadKey();
            Console.WriteLine();


            Console.WriteLine("Тумаков 2.2 деление");
            Console.WriteLine("Введите делимое: ");
            int chislo_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите делитель: ");
            int chislo_2 = int.Parse(Console.ReadLine());
            if (chislo_2 == 0)
            {
                Console.WriteLine("Ошибка, на 0 делить нельзя");
            }
            else
            {
                double div = chislo_1 / chislo_2;
                Console.WriteLine($"Результат деления чисел: {div}");
            }
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Тумаков 2.1дз вывод следующей буквы");
            Console.WriteLine("Введите букву латинского алфавита: ");
            Console.WriteLine("Следующая за этой буква латинского алфавита: " + Convert.ToChar(Convert.ToInt32(Convert.ToChar(Console.ReadLine())) + 1));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Тумаков 2.2дз решение квадратного уравнения");
            Console.WriteLine("Введите коэффициенты a,b,c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Корни уравнения: ");
            if (D > 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a));
                Console.WriteLine("x1= " + ((-b) - Math.Sqrt(D) / 2 * a));
            }
            if (D == 0)
            {
                Console.WriteLine("x1= " + ((-b) + Math.Sqrt(D) / 2 * a));
            }
            if (D < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}