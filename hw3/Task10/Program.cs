using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 423, 11, 50, 234, 649, 720, 20, 9 };
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int m = 0; m < arr.Length; m++)
                Console.WriteLine(arr[m]);

            Console.ReadKey();
            Console.Clear();

        }
    }
}