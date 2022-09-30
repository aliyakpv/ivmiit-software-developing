using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, exnum = 0;
            int i;
            Console.WriteLine("input sequence of 10 numbers:");
            i = 0;
            num = int.Parse(Console.ReadLine());
            exnum = num;
            while (i < 9)
            {
                if (exnum > num)
                {
                    break;
                }
                else
                {
                    i++;
                    num = int.Parse(Console.ReadLine());
                }
            }
            if (i == 9)
                Console.WriteLine("sequence is sorted");
            else
            {
                Console.WriteLine("sequence is unsorted");
                Console.WriteLine($"index of incorrect number - {i + 1}");
            }
        }
    }
}