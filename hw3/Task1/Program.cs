using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, diameter;
            Console.WriteLine("длину форточки");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ширину форточки");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("диаметр головы");
            diameter = Convert.ToInt32(Console.ReadLine());
            
            if ((diameter + 2) < a && (diameter + 2) < b) Console.WriteLine("Вася сможет высунуть голову в форточку");
            else Console.WriteLine("Вася не сможет высунуть голову в форточку");
            Console.ReadKey();
            Console.Clear();
        }
    }

}

