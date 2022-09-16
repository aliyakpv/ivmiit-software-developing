using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задача 1. число E ");
            double x = Math.E;
            Console.WriteLine(Math.Round(x, 1));

            Console.WriteLine("задача 2. числа 50 и 10 одно под др ");
            int a = 50;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("задача 3. программа вывода столбиком 4 любых чисел");
            Console.WriteLine("Введите числа 4 числа: ");
            string numbers = Console.ReadLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("задача 4. Вывести число больше заданного на 10");
            int number = Convert.ToInt32(Console.ReadLine()) + 10;
            Console.WriteLine(number);

            Console.WriteLine("задача 5. Найти периметр квадрата");
            int edge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(edge * 4);

            Console.WriteLine("задача 6. Найти длину окружности и площадь круга");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Длина окружности: {0}", radius * 2 * Math.PI);
            Console.WriteLine("Площадь окружности: {0}", Math.Pow(radius, 2) * Math.PI);

            Console.WriteLine("задача 7. Найти cos(x)");
            int degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Cos(degree));

            Console.WriteLine("задача 8. Найти периметр трапеции");
            int x1 = Convert.ToInt32(Console.ReadLine()); // основание нижнее
            int x2 = Convert.ToInt32(Console.ReadLine()); // основание верхнее
            int x3 = Convert.ToInt32(Console.ReadLine()); // высота
            double x4 = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow((x1 - x2) / 2, 2));
            Console.WriteLine("Периметр: {0}", x1 + x2 + x3 + x4);

            Console.WriteLine("задача 9. Найти стоимость всей покупки");
            Console.WriteLine("Введите цену яблока:");
            int cost_apple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену печенья:");
            int cost_cake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цену конфет:");
            int cost_candy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес яблока:");
            double weight_apple = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес печенья:");
            double weight_cake = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес конфет:");
            double weight_candy = Convert.ToDouble(Console.ReadLine());
            if ((weight_apple + weight_cake + weight_candy) != 1)
            {
                Console.WriteLine("Сумма весов должна быть равна 1 кг");
            }
            else
            {
                double result = cost_apple * weight_apple + cost_cake * weight_cake + cost_candy * weight_candy;
                Console.WriteLine("В итоге:");
                Console.WriteLine(result);
            }

            Console.WriteLine("задача 10. Вывести три строки");
            string[] words = new string[3];
            words[0] = "Мир";
            words[1] = "Труд";
            words[2] = "Май";
            Console.WriteLine(string.Join(" ", words));
            Console.WriteLine(words[0]);
            Console.WriteLine("     " + words[1]);
            Console.WriteLine("           " + words[2]);



            Console.WriteLine("задача 11. Найти стоимость всей покупки");
            string num1 = Console.ReadLine().Replace(".",",");
            string num2 = Console.ReadLine().Replace(".", ",");

            double new_num1;
            double new_num2;
            if (!double.TryParse(num1, out new_num1) | !double.TryParse(num2, out new_num2))
            {
                Console.WriteLine("Некорректно");
            } else
            {
                double mm1 = new_num1;
                new_num1 = new_num2;
                new_num2 = mm1;
                Console.WriteLine("Число {0}, Число {1}", new_num1, new_num2);
            }

            Console.WriteLine("задача 12. Найти стоимость всей покупки");
            string[] figures = {"Треугольник", "Четырехугольник", "Круг"};
            Console.WriteLine("Выберите фигуру из списка (Треугольник,Четырехугольник, Круг)");
            string fig = Console.ReadLine();
            Console.WriteLine("Выберите из списка (Площадь, Периметр)");
            string type = Console.ReadLine();
            if (type == "Площадь")
            {
                if (fig == "Треугольник")
                {
                    double xx = Convert.ToDouble(Console.ReadLine());
                    double yy = Convert.ToDouble(Console.ReadLine());
                    double result = (xx * yy) / 2;
                }
            }

            Console.WriteLine("задача 13. Вывод на экран числа");
            Console.WriteLine("Введите число:");
            double xy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", xy);

            Console.WriteLine("задача 14. Вывести на экран информацию");
            string aa = "2 кг";
            string bb = "13 17";
            Console.WriteLine(aa);
            Console.WriteLine(aa + " " + bb);

            Console.WriteLine("задача 15. Вывести на экран случайные 4 числа столбиком");
            Random random_number = new Random();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(random_number.Next());
            }

            Console.WriteLine("задача 16. Найти корни квадратного уравнения");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            double c3 = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(b2, 2) - 4 * a1 * c3;
            if (d > 0 || d == 0)
            {
                double xx1 = (-b2 + Math.Sqrt(d)) / (2 * a1);
                double xx2 = (-b2 - Math.Sqrt(d)) / (2 * a1);
                Console.WriteLine("x1= {0}, x2= {1}", xx1, xx2);

            }
            else
            {
                Console.WriteLine("корни отсутствуют");
            }

            Console.WriteLine("задача 17. Найти среднее арифметическое и геометрическое");
            Console.WriteLine("Введите число: ");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число: ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Среднее арифметическое: ");
            Console.WriteLine((q + w) / 2);
            Console.WriteLine("Среднее геометрическое: ");
            Console.WriteLine(Math.Pow(q*w, 1/2));

            Console.WriteLine("задача 18. Найти расстояние между двумя координатами");
            int[] coord1 = { 4, 3 };
            int[] coord2 = { 1, 2 };
            Console.WriteLine("Расстояние {0}", Math.Sqrt(Math.Pow(coord2[0] - coord1[0], 2) + Math.Pow(coord2[1] - coord1[1], 2)));

            Console.WriteLine("задача 19. Присвоение значений");
            int aaaa = 1;
            int bbbb = 2;
            int c = 3;
            int t = 1;
            Console.WriteLine($"a = {a}  b = {b}  c = {c}");
            t = b;
            b = c;
            c = a;
            a = t;
            Console.WriteLine($"пункт А: a = {a}  b = {b}  c = {c}");
            a = 1;
            b = 2;
            c = 3;
            t = 1;
            t = b;
            b = a;
            a = c;
            c = t;
            Console.WriteLine($"пункт Б: a = {a}  b = {b}  c = {c}");

            Console.WriteLine("задача 20");
            Console.WriteLine("Введите число секунд");
            int sec = int.Parse(Console.ReadLine());
            Console.WriteLine("прошло часов: " + sec / (60 * 60));
            Console.WriteLine("прошло полных минуt с начала очередного часа: " + ((sec / 60) - ((sec / 60) / 60) * 60));
            Console.WriteLine("прошло секунд с начала последней минуты: " + sec % 60);

            Console.WriteLine("задача 21.");
            Console.WriteLine("Можно вырезать " + (543 / 130) + " квадратов");

            Console.WriteLine("задача 22.");
            Console.WriteLine("введите трёхначное число");
            int np = int.Parse(Console.ReadLine());
            Console.WriteLine($"{np % 10}{np / 10}");

            Console.WriteLine("задача 23.");
            Console.WriteLine("введите число > 999");
            int np1 = int.Parse(Console.ReadLine());
            Console.WriteLine("a) число сотен: " + (np1 / 100) % 10);
            Console.WriteLine("b) число тысяч: " + (np1 / 1000));

            Console.WriteLine("задача 24.");
            Console.WriteLine("введите число > 999");
            string np2 = Console.ReadLine();
            string tpt2 = "";
            for (int tt = np2.Length - 1; tt >= 0; tt--)
            {
                tpt2 += np2[t];
            }
            Console.WriteLine("a) " + tpt2);
            if ((int.Parse(np2) / 100) % 10 == 0)
            {
                Console.WriteLine("b) " + np2[0] + np2[2] + np2[3]);
            }
            else
            {
                Console.WriteLine("b) " + np2[1] + np2[0] + np2[2] + np2[3]);
            }
            Console.WriteLine("c) " + np2[0] + np2[2] + np2[1] + np2[3]);
            if ((int.Parse(np2) / 10) % 10 == 0)
            {
                Console.WriteLine("d) " + np2[3] + np2[0] + np2[1]);
            }
            else
            {
                Console.WriteLine("d) " + np2[2] + np2[3] + np2[0] + np2[1]);
            }
            Console.WriteLine("задача 25.");
            Console.WriteLine("введите число 100 <= n =< 999");
            string np3 = Console.ReadLine();
            if ((int.Parse(np3) / 10) % 10 == 0)
            {
                Console.WriteLine("введите другое число");
            }
            else
            {
                Console.WriteLine("x = " + np3[1] + np3[2] + np3[0]);
            }
            Console.WriteLine("задача 26.");
            Console.WriteLine("Введите время: часы, минуты, секунды");
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            if (hour > 11)
            {
                hour -= 12;
            }
            Console.WriteLine("cейчас угол между положением стрелки на началr дня и временем ввреденным вами равен: " + ((360 / 12) * hour + (0.5 * minutes) + (0.0083 * seconds)));

            Console.WriteLine("задача 27.");
            DateTime now = DateTime.Now;
            double m = now.Minute + now.Second / 60;
            double ugol = m / 5 * 30;
            Console.WriteLine("{0} час {1} минут", now.Minute, now.Second);
            Console.WriteLine("{0} угол", ugol);


            Console.WriteLine("задача 28.");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int[] abs2 = { Math.Abs(abs[0]), Math.Abs(abs[1]), Math.Abs(abs[2]) };
            Console.WriteLine("меньшее из трёх: " + abs2.Min());

            Console.WriteLine("задача 29.");
            Console.WriteLine("введите 3 числа через пробел");
            int[] abs3 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            Console.WriteLine("сумма наибольшего и наименьшего : " + (abs3.Min() + abs3.Max()));

            Console.WriteLine("задача 30.");
            Console.WriteLine("Введите целое число");
            int count = 0;
            int val;
            if (Int32.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Делители числа" + val);
                for (int m1 = 1; m1 <= val; m1++)
                    if (val % m1 == 0)
                    {
                        count++;
                    }
                Console.WriteLine("Количество делителей числа " + val + " : " + count);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("введите число!!");

            }
            Console.WriteLine("задача 31.");
            Console.WriteLine("введите коэффициенты уравнения (a,b,c,d)");
            int[] coef = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            for (int otr = -100; otr <= 100; otr++)
            {
                double result = coef[0] * Math.Pow(otr, 3) + coef[1] * otr * otr + coef[2] * otr + coef[3];
                if (result == 0)
                {
                    Console.WriteLine("X = " + otr);
                }
            }

            Console.WriteLine("задача 32");
            Console.WriteLine("Введите первый элемент последовательности");
            double seq1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности");
            double seq2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности, который желаете найти");
            double NumOfSeq = double.Parse(Console.ReadLine());
            double elemen = seq1 + ((seq2 - seq1) * (NumOfSeq - 1));
            Console.WriteLine($"Элемент последовательности с номером {NumOfSeq} равен {elemen}");

            Console.WriteLine("задача 33. кредит в банке");
            Console.WriteLine("Дайте ответы на вопросы");
            Console.WriteLine("Являетесь ли вы пенсионером? (1 - да / 0 - нет)");
            int pensioners = int.Parse(Console.ReadLine());
            Console.WriteLine("Являетесь ли вы студентом? (1 - да / 0 - нет)");
            int student = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы тродоустроены? (1 - да / 0 - нет)");
            int yn = int.Parse(Console.ReadLine());
            if (((pensioners == 1 && yn == 0) || (student == 1 && yn == 0)) && (pensioners == 0 || student == 0))
            {
                Console.WriteLine("Поздравляю вам одобрен кредит)");
            }
            else
            {
                Console.WriteLine("Кредит не одобрен, сожалею(");
            }
            Console.WriteLine("задача 34.");
            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            Console.WriteLine($"a) {name}");
            Console.WriteLine("введите имя");
            string name2 = Console.ReadLine();
            Console.WriteLine($"б) Привет, {name2}!");

            Console.WriteLine("задача 35.");
            Random color = new Random();
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name3 = Console.ReadLine();
            Console.WriteLine($"Пивет, {name3}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            int color1 = color.Next(1, 15);
            if (color1 == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
            if (color1 == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            if (color1 == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            if (color1 == 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            if (color1 == 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            if (color1 == 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            }
            if (color1 == 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (color1 == 7)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            if (color1 == 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            if (color1 == 9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            if (color1 == 10)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (color1 == 11)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            if (color1 == 12)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (color1 == 13)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            if (color1 == 14)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (color1 == 15)
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            
        }
    }
}

          