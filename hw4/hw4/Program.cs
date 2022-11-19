using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork
{
    enum Grumbling_Level
    {
        Good_natured = 1, Little_grumpy = 2, Grumbler = 3, Evil = 4, Greybeard_Killer = 5
    }
    struct Ded
    {
        public string name;
        public byte vorch;
        public string[] phrases;
        public byte blows;


        public Ded(string Name, byte Vorch, string[] Phrases, byte Blows)
        {
            this.name = Name;
            this.vorch = Vorch;
            this.phrases = Phrases;
            this.blows = Blows;
        }
    }

    class Program
    {
        public static void ReshYravn(double a, double b, double c)
        {
            double D = (a * a + 4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                double x2 = (-b - Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"Первый корень равен {x1}, второй корень равен {x2}");
            }
            else if (D == 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"Единственный корень равен {x1}");

            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }


        public static void Arr(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        public static void SotrArray(double[] mas)
        {
            for (int I = 0; I < mas.Length - 1; I++)
            {
                for (int j = I + 1; j < mas.Length; j++)
                {
                    if (mas[I] > mas[j])
                    {
                        double temp = mas[I];
                        mas[I] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
        }

        public static double OperetionsArray(double sum, ref double mult, out double sr_arif, double[] array)
        {
            sum = 0;
            mult = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                mult *= array[i];
            }
            sr_arif = sum / array.Length;
            return sum;
        }

        public static void NumberOperation()
        {
            bool run = true;
            do
            {
                try
                {
                    Console.WriteLine("Введите число в диапозоне 0-9");
                    int chislo = int.Parse(Console.ReadLine());
                    string[] PictureNumber = new string[10];
                    PictureNumber[0] = "###" + "\n" + "# #" + "\n" + "# #" + "\n" + "# #" + "\n" + "###";
                    PictureNumber[1] = " # " + "\n" + "## " + "\n" + " # " + "\n" + " # " + "\n" + "###";
                    PictureNumber[2] = " # " + "\n" + "# #" + "\n" + "  #" + "\n" + " # " + "\n" + "###";
                    PictureNumber[3] = "## " + "\n" + "  #" + "\n" + " # " + "\n" + "  #" + "\n" + "## ";
                    PictureNumber[4] = "# #" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "  #";
                    PictureNumber[5] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "  #" + "\n" + "### ";
                    PictureNumber[6] = "###" + "\n" + "#  " + "\n" + "###" + "\n" + "# #" + "\n" + "###";
                    PictureNumber[7] = "####" + "\n" + "  #" + "\n" + " ###" + "\n" + " # " + "\n" + " # ";
                    PictureNumber[8] = "###" + "\n" + "# #" + "\n" + " # " + "\n" + "# #" + "\n" + "###";
                    PictureNumber[9] = "###" + "\n" + "# #" + "\n" + "###" + "\n" + "  #" + "\n" + "###";

                    if (chislo >= 0 && chislo <= 9)
                    {
                        Console.WriteLine(PictureNumber[chislo]);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                        Console.WriteLine("Ошибка");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введенное вами число некорректно ");
                }
                Console.WriteLine("Хотите продолжижть?(если нет - exit/закрыть)");
                string ans = Console.ReadLine();
                if (ans == "exit" || ans == "закрыть")
                {
                    run = false;
                }
            } while (run == true);
        }

        public static int FingalsDed(string[] words, params string[] mats)
        {
            int fingals = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < mats.Length; j++)
                {
                    if (mats[j] == words[i])
                    {
                        fingals++;
                    }
                }
            }
            return fingals;
        }

        public static void SpeedSorting(double[] arr, int minIndex, int maxIndex)
        {
            double pivot = arr[(maxIndex - minIndex) / 2 + minIndex];
            int i = minIndex, j = maxIndex;
            while (i <= j)
            {
                while (arr[i] < pivot && i <= maxIndex)
                {
                    ++i;
                }
                while (arr[j] > pivot && j >= minIndex)
                {
                    --j;
                }
                if (i <= j)
                {
                    double temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > minIndex)
            {
                SpeedSorting(arr, minIndex, j);
            }
            if (i < maxIndex)
            {
                SpeedSorting(arr, i, maxIndex);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1, решение квадратного уравнения");
            Console.WriteLine("Введите коэффиценты a,b,c для решения квадратного уравнения");
            double koef1 = double.Parse(Console.ReadLine());
            double koef2 = double.Parse(Console.ReadLine());
            double koef3 = double.Parse(Console.ReadLine());
            ReshYravn(koef1, koef2, koef3);
            Console.WriteLine();

            Console.WriteLine("Задание 2, поменять местами числа из рандомного массива");
            Console.Write(" Исходный массив: ");
            Random rnd = new Random();
            int[] array = new int[20];
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                array[y] = rand.Next(-100, 100);
            }
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine("\n Введите 2 числа из массива, которые нужно поменять местами");
            int elem1 = Array.IndexOf(array, int.Parse(Console.ReadLine()));
            int elem2 = Array.IndexOf(array, int.Parse(Console.ReadLine()));
            Arr(array, elem1, elem2);
            Console.Write("Массив после перестановки двух элементов: ");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();


            Console.WriteLine("Задание 3, сортировка массива методом пузырька");
            Console.WriteLine("Введите массив из 10 чисел");
            double[] arrayy = new double[10];
            for (int i = 0; i < 10; i++)
                arrayy[i] = double.Parse(Console.ReadLine());
            Console.Write("Исходный массив: ");
            foreach (int i in arrayy)
            {
                Console.Write(i + " ");
            }
            SotrArray(arrayy);
            Console.WriteLine("\nОтсортированный массив");
            foreach (int i in arrayy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Задание 4, сумма, произведение, среднее арифметическое элементов массива");
            Console.WriteLine("Введите массив из 10 чисел");
            double sum = 0;
            double mult = 1;
            double sr_arif = 0;
            double[] array_ = new double[10];
            for (int i = 0; i < 10; i++)
                array_[i] = double.Parse(Console.ReadLine());
            OperetionsArray(sum, ref mult, out sr_arif, array_);
            Console.Write($"Сумма элементов массива: {OperetionsArray(sum, ref mult, out sr_arif, array_)}");
            Console.WriteLine();
            Console.Write($"Произведение элементов массива: {mult}\nСреднее арифметическое элементов массива: {sr_arif}");
            Console.WriteLine();


            Console.WriteLine("Задание 5, нарисовать изображение цифры");
            NumberOperation();


            Console.WriteLine("Задание 6, создать структура деда");
            string[] mats1 = { "проституки!", "гады", "чертоп#здел" };
            Ded ded1 = new Ded("Аркадий Саныч", 4, mats1, 0);
            string[] mats2 = { "проститутки!", "дaрьмоеды", "прохиндеи!", "тетеря" };
            Ded ded2 = new Ded("Тимергази Нурсалимович", 5, mats2, 0);
            string[] mats3 = { "сектен!!", "проституткалар!", "гады", "пеньтюх", "шаромыжник", "пресноплюй" };
            Ded ded3 = new Ded("Михаил Петрович", 3, mats3, 0);
            string[] mats4 = { "проституки!", "мудень", "шпынь голова", "добратабенебудь" };
            Ded ded4 = new Ded("Андрей Николаевич", 2, mats4, 0);
            string[] mats5 = { "проституки!", "безсоромна", "педераст" };
            Ded ded5 = new Ded("Генадий Аркадьич", 1, mats5, 0);
            string[] slova = { "проституки!", "гады", "обворовали Россию", "сектен!!", "шаромыжник", "шпынь голова", "педераст", "хорошо что мы живем в России, а не в Америке", "а в наше время...",
                "все скоммуниздили..", "много что было, и по мне стреляли, и я упал в лужу...","пеньтюх", "тетеря", "вот умру, никто стакан воды мне не принесет!!!", "когда внуки?" };
            Console.WriteLine("Количество финаглов первого деда от бабки: " + FingalsDed(slova, mats1));
            Console.WriteLine("Количество  финаглов второго деда от бабки: " + FingalsDed(slova, mats2));
            Console.WriteLine("Количество  финаглов третьего деда от бабки: " + FingalsDed(slova, mats3));
            Console.WriteLine("Количество  финаглов четвертого деда от бабки: " + FingalsDed(slova, mats4));
            Console.WriteLine("Количество  финаглов пятого деда от бабки: " + FingalsDed(slova, mats5));
            Console.WriteLine();


            Console.WriteLine("7 задание, метод быстрой сортировки");
            Console.Write("Исходный массив: ");
            Random rnd_ = new Random();
            double[] arr = new double[20];
            Random rand_ = new Random();
            for (int y = 0; y < 20; y++)
            {
                arr[y] = rand.Next(-100, 100);
            }
            foreach (int y in arr)
                Console.Write(y + " ");
            SpeedSorting(arr, 0, arr.Length - 1);
            Console.Write("\nМассив после сортировки: ");
            foreach (int y in arr)
                Console.Write(y + " ");
        }
    }
}