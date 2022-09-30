using System;

namespace Task
{

    class Program
    {

        static void Main(string[] args)
        {
            double mean(string seq)
            {
                return seq.Select(x => double.Parse(x.ToString())).Sum() / (seq.Length - 1);
            }

            Console.WriteLine("Input sequence");
            string sequence = Console.ReadLine();

            double result = 0;
            try
            {
                result = mean(sequence);
            }
            catch (Exception ex)
            {
                if (ex is System.DivideByZeroException)
                {
                    Console.WriteLine("Input sequence of length > 1");
                    sequence = Console.ReadLine();
                    result = mean(sequence);
                }
                else if (ex is System.FormatException)
                {
                    Console.WriteLine("Input integer sequence");
                    sequence = Console.ReadLine();
                    result = mean(sequence);
                }
            }
            finally
            {
                Console.WriteLine($"Среднее арифметическое: {result}");
            }
            
            Console.ReadKey();
            Console.Clear();

        }


    }

    

}
