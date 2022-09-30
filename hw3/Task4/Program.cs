using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text != null && text.ToUpper() == text) Console.WriteLine(true);
            else Console.WriteLine(false);
            Console.ReadKey();  
            Console.Clear();
        }
    }
}