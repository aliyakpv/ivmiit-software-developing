using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {i * n}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
