using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics.CodeAnalysis;

namespace Homework
{
    class TumakovLaba
    {
        enum months
        {
            январь = 1, февраль = 2, март = 3, апрель = 4, май = 5, июнь = 6, июль = 7, август = 8, сентябрь = 9, октябрь = 10, ноябрь = 11, декабрь = 12
        }

        static int GetCount(char[] text, char[] letter)
        {
            int Count = 0;

            foreach (char i in text)
            {
                foreach (char j in letter)
                {
                    if (i == j)
                        Count++;
                }

            }
            return Count;
        }
        static int GetCountWithList(List<char> list, char[] letter)
        {
            int Count = 0;
            foreach (char i in list)
            {
                foreach (char j in letter)
                {
                    if (i == j)
                        Count++;
                }
            }
            return Count;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MatrixMultiplication(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Данные матрицы нельзя перемножить");
            }
            else
            {
                int[,] r = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.GetLength(0); k++)
                        {
                            r[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
                Console.WriteLine("Произведение матриц: ");
                PrintMatrix(r);
            }
        }
        static void MatrixMultiplication(LinkedList<LinkedList<int>> matrix1, LinkedList<LinkedList<int>> matrix2, ref LinkedList<LinkedList<int>> multi)
        {
            LinkedList<int> m1 = new LinkedList<int>();
            LinkedList<int> m2 = new LinkedList<int>();
            LinkedList<int> mult = new LinkedList<int>();
            m1.AddFirst(1); m1.AddLast(2); m1.AddLast(3); m1.AddLast(4);
            m2.AddFirst(5); m2.AddLast(6); m2.AddLast(7); m2.AddLast(8);
            matrix1.AddFirst(m1);
            matrix2.AddFirst(m2);
            var a1 = m1.First; var a2 = a1.Next; var a3 = a2.Next; var a4 = a3.Next;
            var b1 = m2.First; var b2 = b1.Next; var b3 = b2.Next; var b4 = b3.Next;
            var c0 = a1.Value * b1.Value + a2.Value * b3.Value;
            var c1 = a1.Value * b2.Value + a2.Value * b4.Value;
            var c2 = a3.Value * b1.Value + a4.Value * b3.Value;
            var c3 = a3.Value * b2.Value + a4.Value * b4.Value;
            mult.AddFirst(c0); mult.AddLast(c1); mult.AddLast(c2); mult.AddLast(c3);
            multi.AddFirst(mult);
            var item = mult.First;
            int i = 0;
            Console.WriteLine("Произведение матриц:");
            while (item != null)
            {
                Console.Write(item.Value + " ");
                item = item.Next;
                i++;
                if (i == 2)
                {
                    Console.WriteLine();
                }
            }
        }
        static void AverageTemperature(double[,] temperature)
        {
            double sum = 0;
            double sr_arif = 1;
            double[] averageMas = new double[12];

            for (int i = 0; i < temperature.GetLength(0); i++)
            {

                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    sum += temperature[i, j];
                    sr_arif = Math.Round(sum / 30, 2);
                }
                averageMas[i] = sr_arif;
                Console.WriteLine($"Средняя температура в {i + 1} месяце - {sr_arif}");
            }
            Array.Sort(averageMas);
            Console.WriteLine("Средние значения температур в месяцах по возрастанию: ");
            foreach (double i in averageMas)
                Console.Write(i + " ");
        }
        static int Averagetemper(int[] array, ref int[] sr_znach)
        {
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum = ++array[i];
            }
            Array.Sort(sr_znach);
            return (int)Math.Round(sum / 12);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков, классное 6.1, количество гласных и согласных в файле");
            string readText = File.ReadAllText(@"C:\text.txt");
            char[] array = readText.ToLower().ToCharArray();
            char[] vowels = "АЕЁИОУЫЭЮЯ".ToLower().ToCharArray();
            char[] consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩЬЪ".ToLower().ToCharArray();
            Console.WriteLine($"Гласных в файле: {GetCount(array, vowels)}");
            Console.WriteLine($"Согласных в файле: {GetCount(array, consonants)}");
            Console.WriteLine();


            Console.WriteLine("Тумаков, классное 6.2, умножение двух матриц");
            Random random = new Random();
            byte m = (byte)random.Next(1, 5);
            byte n = (byte)random.Next(1, 5);
            byte q = (byte)random.Next(1, 5);
            int[,] A = new int[n, m];
            int[,] B = new int[q, n];
            Console.WriteLine("Заполните 1 матрицу");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Заполните 2 матрицу");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("B[{0},{1}] = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Первая матрица:");
            PrintMatrix(A);
            Console.WriteLine("Вторая матрица:");
            PrintMatrix(B);
            MatrixMultiplication(A, B);
            Console.WriteLine();

            Console.WriteLine("Тумаков, классное 6.3, средняя температура за год");
            Random rand = new Random();
            double[,] temperature = new double[12, 30];
            for (int j = 0; j < 30; j++)
                for (int i = 0; i < 12; i++)
                    temperature[i, j] = rand.Next(-30, 30);
            AverageTemperature(temperature);
            Console.WriteLine();


            Console.WriteLine("Тумаков, самостоятельное 6.1, упражнение 6.1 выполнить с помощью коллекции List<T>.");
            string sr = File.ReadAllText(@"C:\text.txt");
            char[] file = sr.ToLower().ToCharArray();
            List<char> list = new List<char>();
            for (int i = 0; i < file.Length; i++)
            {
                list.Add(file[i]);
            }
            Console.WriteLine($"Гласных в файле: {GetCountWithList(list, vowels)} \nCогласных в файле: {GetCountWithList(list, consonants)}");
            Console.WriteLine();



            Console.WriteLine("Тумаков, самостоятельное 6.2, упражнение 6.2 выполнить с помощью коллекций LinkedList<LinkedList<T>>");
            LinkedList<LinkedList<int>> matrix1 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> matrix2 = new LinkedList<LinkedList<int>>();
            LinkedList<LinkedList<int>> multimatrix = new LinkedList<LinkedList<int>>();
            MatrixMultiplication(matrix1, matrix2, ref multimatrix);
            Console.WriteLine();


            Console.WriteLine("Тумаков, самостоятельное 6.3, упражнение 6.3, с помощью класса Dictionary<TKey, TValue>");
            Random temp = new Random();
            int[] temper = new int[30];
            int[] AllTemps = new int[12];
            Dictionary<months, int[]> weather = new Dictionary<months, int[]>();
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temper[j] = temp.Next(-30, 30);
                }
                Console.WriteLine($"Средняя температура в месяце {(months)(i + 1)} - {Averagetemper(temper, ref AllTemps)}");
                weather.Add((months)(i + 1), temper);
                AllTemps[i] = Averagetemper(temper, ref AllTemps);
            }
            Console.WriteLine("Отсортированный массив средних температур месяцов: ");
            foreach (int a in AllTemps)
            {
                Console.Write(a + " ");
            }
        }
    }
}