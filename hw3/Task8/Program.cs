using System;

namespace Task
{
    public enum Day
    {
        monday = 1,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }

    class Program
    {
        static void Main(string[] args)
        {


            int k;
            Console.WriteLine("input k");
            while (!int.TryParse(Console.ReadLine(), out k) | (k > 7 | k < 1)) Console.WriteLine("Input 1 <= k <= 7");

            
            Console.WriteLine((Day)k);
            Console.ReadKey();
            Console.Clear();

        }
    }
}