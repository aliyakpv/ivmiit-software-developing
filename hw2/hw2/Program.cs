using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Homework
{
    struct student
    {
        public string name;
        public string surname;
        public int ident;
        public string bday;
        public string category;
        public double alko;
        public student(string Name, string Surname, int Ident, string Bday, string Category, double Alko) : this()
        {
            this.name = Name;
            this.surname = Surname;
            this.ident = Ident;
            this.bday = Bday;
            this.category = Category;
            this.alko = Alko;
        }
        public double drink()
        {
            return alko;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Идентификатор:{ident},  Дата рождения: {bday}, Cтепень алкоголизма: {category}, Обьем выпитого алкоголя: {alko}");
        }

    }
    struct info
    {
        public string namee;
        public string town;
        public int age;
        public int pin;
        public info(string Name, string Town, int Age, int Pin) : this()
        {
            this.namee = Name;
            this.town = Town;
            this.age = Age;
            this.pin = Pin;
        }
        public void Print()
        {
            Console.WriteLine("Данные о пользователе: " + "\n" + $"Имя: {namee}" + "\n" + $"Город: {town}" + "\n" + $"Возраст: {age}" + "\n" + $"Пин-код: {pin}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1, степень алкоголизма студентов");
            student alko1 = new student("Аделя", "Гильфанова", 1, "26 мая 2004", "с", 1.1);
            alko1.Print();
            student alko2 = new student("Полина", "Толстолуцкая", 2, "7 января 2004", "а", 2.1);
            alko2.Print();
            student alko3 = new student("Мария", "Мошкина", 3, "16 сентября  2004", "с", 1.5);
            alko3.Print();
            student alko4 = new student("Диана", "Хамидуллина", 4, "14 октября 2004", "d", 0);
            alko4.Print();
            student alko5 = new student("Карина", "Хузина", 5, "26 мая 2004", "b", 0.5);
            alko5.Print();
            double vmeste_alko = alko1.drink() + alko2.drink() + alko3.drink() + alko4.drink();
            Console.WriteLine($"Первый студент выпил: {Math.Round(alko1.drink() / vmeste_alko * 100)}%");
            Console.WriteLine($"Второй студент выпил: {Math.Round(alko2.drink() / vmeste_alko * 100)}%");
            Console.WriteLine($"Третий студент выпил: {Math.Round(alko3.drink() / vmeste_alko * 100)}%");
            Console.WriteLine($"Четвертый студент выпил: {Math.Round(alko4.drink() / vmeste_alko * 100)}%");
            Console.WriteLine($"Пятый студент выпил: {Math.Round(alko5.drink() / vmeste_alko * 100)}%");
            Console.WriteLine($"Общий обьем выпитого алкоголя: {vmeste_alko}");
            Console.WriteLine();

            Console.WriteLine("Задание 2, информация о типах данных ");
            Console.WriteLine("Максимальное и минималтное значение типов данных:");
            Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
            $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
            $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
            $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
            $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
            $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
            $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
            $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
            $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
            $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
            "bool: true ... false" + "\n" +
            $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
            "string: Ограничено системной памятью" + "\n" +
            "object: Нельзя определить, так как этот тип данных может указывать на данные любого типа данных");
            Console.WriteLine();

            Console.WriteLine("Задание 3, данные о пользователе");
            Console.WriteLine("Введите свое имя, город, возраст и пин-код");
            info person = new info();
            person.namee = Console.ReadLine();
            person.town = Console.ReadLine();
            person.age = int.Parse(Console.ReadLine());
            person.pin = int.Parse(Console.ReadLine());
            person.Print();
            Console.WriteLine();

            Console.WriteLine("Задание 4, инициалы");
            Console.WriteLine("Введите свои имя и фамилию");
            string str = Console.ReadLine();
            int index = str.IndexOf(' ');
            string str2 = str.Remove(0, index + 1);
            string in1 = str.Remove(1);
            string in2 = str2.Remove(1);
            Console.WriteLine($"Ваши инициалы: {in1}.{in2}");
            Console.WriteLine();

            Console.WriteLine("Задание 5, бутылки виски");
            Console.Write("Введите цену виски: ");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите скидку в DutyFree: ");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость отпуска ");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double sale = salePrice * normPrice / 100;
            double bottles = holidayPrice / sale;
            Console.WriteLine($"Чтобы покрыть расходы на отпуск, вы должны купить {Math.Floor(bottles)} бутылок");
            Console.WriteLine();

            Console.WriteLine("Задание 6, задача про таракана");
            Console.WriteLine("Введите скорость таракана в км/ч:");
            double S = Convert.ToDouble(Console.ReadLine());
            double S_new = Math.Floor(S / 0.036);
            Console.WriteLine($"{S} -> {S_new}");
            Console.WriteLine();

            Console.WriteLine("Задание 7, заглавные->строчные, строчные->загалвные");
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();
            char[] text_new = text.ToCharArray();
            for (int i = 0; i < text_new.Length; i++)
            {
                if (char.IsLower(text_new[i]))
                {
                    text_new[i] = Char.ToUpper(text_new[i]);
                }
                else
                {
                    text_new[i] = Char.ToLower(text_new[i]);
                }
            }
            for (int i = 0; i < text_new.Length; i++)
            {
                Console.Write(text_new[i]);
            }
        }
    }
}