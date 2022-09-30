using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int num = Convert.ToInt32(Console.ReadLine());

            string pattern = "";
            for(int i = 1; i <= num; i++)
            {
                pattern += $"{i} овца... ";
            }
            Console.WriteLine(pattern);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
