using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("БэнгБум");
            else if (number % 5 == 0) Console.WriteLine("Бум");
            else if (number % 3 == 0) Console.WriteLine("Бэнг");
            else Console.WriteLine("Мимо");
            Console.ReadKey();
            Console.Clear();

        }
    }
}