using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = new Dictionary<string, int>
            {
                ["шестерка"] = 6,
                ["семерка"] = 7,
                ["восьмерка"] = 8,
                ["девятка"] = 9,
                ["десятка"] = 10,
                ["валет"] = 11,
                ["дама"] = 12,
                ["король"] = 13,
                ["туз"] = 14
            };

            Console.WriteLine("Input 6 <= k <= 14");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) | (k < 6 | k > 14)) Console.WriteLine("Input 6 <= k <= 14");

            Console.WriteLine(cards.FirstOrDefault(x => x.Value == k).Key);
            Console.ReadKey();
            Console.Clear();

        }
    }
}