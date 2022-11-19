using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Net;
using System.Collections;

namespace HomeWork
{
    struct Student
    {
        public string name;
        public string surname;
        public short year;
        public string exam;
        public short balls;
    }
    class Program
    {
        static void СomparisonArray(byte[] array1, byte[] array2)
        {
            int count1 = 0; int count2 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 5)
                {
                    count1++;
                }
            }
            for (int j = 0; j < array2.Length; j++)
            {
                if (array2[j] == 5)
                {
                    count2++;
                }
            }
            if (count1 == count2)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        static void Graph()
        {
            Random rand = new Random();
            Queue<int> NomersVersh = new Queue<int>();
            Console.Write("Введите количество вершин: ");
            int CountVersh = int.Parse(Console.ReadLine()) - 1;
            if (CountVersh >= 3)
            {
                bool[] UsedVersh = new bool[CountVersh + 1];
                int[][] SmezhVersh = new int[CountVersh + 1][];

                for (int i = 0; i < CountVersh + 1; i++)
                {
                    SmezhVersh[i] = new int[CountVersh + 1];
                    Console.Write($"\n{i + 1} вершина - [");
                    for (int j = 0; j < CountVersh + 1; j++)
                    {
                        SmezhVersh[i][j] = rand.Next(0, 2);
                    }
                    SmezhVersh[i][i] = 0;
                    foreach (var item in SmezhVersh[i])
                    {
                        Console.Write($" {item}");
                    }
                    Console.Write("]\n");
                }
                UsedVersh[CountVersh] = true;     //информация о том, посещали мы вершину или нет
                NomersVersh.Enqueue(CountVersh);
                Console.WriteLine("Начинаем обход с {0} вершины", CountVersh + 1);
                while (NomersVersh.Count != 0)
                {
                    CountVersh = NomersVersh.Peek();
                    NomersVersh.Dequeue();
                    Console.WriteLine("Перешли к узлу {0}", CountVersh + 1);

                    for (int i = 0; i < SmezhVersh.Length; i++)
                    {
                        if (Convert.ToBoolean(SmezhVersh[CountVersh][i]))
                        {
                            int v = i;
                            if (!UsedVersh[v])
                            {
                                UsedVersh[v] = true;
                                NomersVersh.Enqueue(v);
                                Console.WriteLine("Добавили в очередь узел {0}", v + 1);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Количество вершин некорректно");
            }
        }
        public class Villager
        {
            public string name;
            public short numberOfpasport;
            public string problem;
            public int scandalousness;
            public bool isSmart;

            public Villager(string name, short numberOfpasport, string problem, int scandalousness, bool isSmart)
            {
                this.name = name;
                this.numberOfpasport = numberOfpasport;
                this.problem = problem;
                this.scandalousness = scandalousness;
                this.isSmart = isSmart;
            }

        }
        public class Check
        {
            public bool UserInutWithCheckInteger(out int userNumber)
            {
                Console.WriteLine("Введите число:");
                while (!int.TryParse(Console.ReadLine(), out userNumber))
                {
                    Console.WriteLine("Ошибка, введите число");
                }
                return true;
            }
        }
        public class Window
        {
            Check check = new Check();
            public string problem;
            public List<Villager> notSortedQueueVilagers = new List<Villager>();
            public Queue<Villager> queueVilagers;
            public void PrintAllVillagers()
            {
                for (int i = 0; i < notSortedQueueVilagers.Count; i++)
                {
                    Console.WriteLine(i + ": " + notSortedQueueVilagers[i].name);
                }
            }
            public void SortVillagers()
            {
                Console.WriteLine("Окно " + problem);
                PrintAllVillagers();
                for (int i = 0; i < notSortedQueueVilagers.Count; i++)
                {
                    if (notSortedQueueVilagers[i].scandalousness >= 5)
                    {
                        int userChoose;
                        Console.Write(notSortedQueueVilagers[i].name + " очень наглый/ая. Скольких он обгонит? ");
                        check.UserInutWithCheckInteger(out userChoose);
                        if (i - userChoose > 0)
                        {
                            Villager rotate = notSortedQueueVilagers[i - userChoose];
                            notSortedQueueVilagers[i - userChoose] = notSortedQueueVilagers[i];
                            notSortedQueueVilagers[i] = rotate;
                        }
                    }
                }
                queueVilagers = new Queue<Villager>(notSortedQueueVilagers);
            }
            public void WorkWithVillager()
            {
                while (queueVilagers.Count > 0)
                {
                    Villager villager = queueVilagers.Dequeue();
                    Console.WriteLine(villager.numberOfpasport + ": " + villager.name);
                }
            }
        }
        public class Zina
        {
            Window[] allWindows;
            public Stack<Villager> stackVilagers = new Stack<Villager>();
            public void InsertAllStack()
            {
                stackVilagers.Push(new Villager("Карина", 9217, "Подключение", 10, true));
                stackVilagers.Push(new Villager("Александра", 3467, "Другое", 2, false));
                stackVilagers.Push(new Villager("Мария", 4738, "Оплата", 3, true));
                stackVilagers.Push(new Villager("Аделя", 2111, "Оплата", 6, true));
                stackVilagers.Push(new Villager("Дарья", 3478, "Другое", 1, true));
                stackVilagers.Push(new Villager("Алия", 3462, "Подключение", 9, true));
                stackVilagers.Push(new Villager("Алсу", 3427, "Оплата", 5, false));
                stackVilagers.Push(new Villager("Диана", 9245, "Другое", 5, true));
                stackVilagers.Push(new Villager("Полина", 3426, "Подключение", 9, false));
                stackVilagers.Push(new Villager("Элина", 2309, "Оплата", 0, true));

            }
            public Zina(Window[] allWindows)
            {
                this.allWindows = allWindows;
                InsertAllStack();
            }
            public void Distribution()
            {
                while (stackVilagers.Count > 0)
                {
                    Villager villager = stackVilagers.Pop();
                    if (villager.isSmart)
                    {
                        for (int i = 0; i < allWindows.Length; i++)
                        {
                            if (villager.problem == allWindows[i].problem)
                            {
                                allWindows[i].notSortedQueueVilagers.Add(villager);
                            }
                        }
                    }
                    else
                    {
                        Random random = new Random();
                        int villageChoose = random.Next(0, allWindows.Length);
                        allWindows[villageChoose].notSortedQueueVilagers.Add(villager);
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1, меню со студентами");
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            Student person1 = new()
            { name = "Гильфанова", surname = "Аделя", year = 2004, exam = "информатика", balls = 300 };
            Student person2 = new()
            { name = "Якупова", surname = "Алия", year = 2004, exam = "информатика", balls = 300 };
            Student person3 = new()
            { name = "Мошкина", surname = "Мария", year = 2004, exam = "информатика", balls = 300 };
            Student person4 = new()
            { name = "Хамидуллина", surname = "Диана", year = 2004, exam = "английский", balls = 300 };
            Student person5 = new()
            { name = "Хузина", surname = "Карина", year = 2004, exam = "английский", balls = 300 };
            Student person6 = new()
            { name = "Братухин", surname = "Илья", year = 2004, exam = "физика", balls = 300 };
            Student person7 = new()
            { name = "Галимова", surname = "Элина", year = 2004, exam = "информатика", balls = 300 };
            Student person8 = new()
            { name = "Калашников", surname = "Андрей", year = 2004, exam = "информатика", balls = 300 };
            Student person9 = new()
            { name = "Зиганшин", surname = "Халиль", year = 2004, exam = "информатика", balls = 300 };
            Student person10 = new()
            { name = "Залялетдинов", surname = "Азат", year = 2004, exam = "информатика", balls = 300 };
            students.Add(person1.name, person1);
            students.Add(person2.name, person2);
            students.Add(person3.name, person3);
            students.Add(person4.name, person4);
            students.Add(person5.name, person5);
            students.Add(person6.name, person6);
            students.Add(person7.name, person7);
            students.Add(person8.name, person8);
            students.Add(person9.name, person9);
            students.Add(person10.name, person10);
            Console.WriteLine("Введите слово: \nНовый студент-если, хотите добавить кого-то в лист \nУдалить-если хотите удалить кого-то с листа" +
                "\nСортировать - если хотите выполнить сортировку по баллам");
            string operation = Console.ReadLine();
            try
            {
                if (operation == "Новый студент" || operation == "новый студент" || operation == "Новыйстудент" || operation == "новыйстудент")
                {
                    Student new_student = new();
                    Console.Write("Введите фамилию: ");
                    new_student.name = Console.ReadLine();
                    Console.Write("Введите имя: ");
                    new_student.surname = Console.ReadLine();
                    Console.Write("Введите год рождения: ");
                    new_student.year = short.Parse(Console.ReadLine());
                    Console.Write("Введите экзамен по выбору: ");
                    new_student.exam = Console.ReadLine();
                    Console.Write("Введите баллы: ");
                    new_student.balls = Convert.ToByte(Console.ReadLine());
                    students.Add(new_student.name, new_student);
                    Console.WriteLine("Обновленный список:");
                    foreach (var s in students)
                    {
                        Console.WriteLine(s.Value.name);
                    }
                }
                else if (operation == "Удалить" || operation == "удалить")
                {
                    Console.WriteLine("Введите через фамилию человека, которого вы хотите удалить из списка");
                    string surname_delete = Console.ReadLine();
                    students.Remove(surname_delete);
                    Console.WriteLine("Обновленный список: ");
                    foreach (var s in students)
                    {
                        Console.WriteLine(s.Value.name);
                    }
                }
                else if (operation == "Сортировать" || operation == "сортировать")
                {
                    Console.WriteLine("Отсортированный список");
                    var sorted = students.OrderBy(x => x.Value.balls);
                    foreach (var student in sorted)
                    {
                        Console.WriteLine($"{student.Value.name}, {student.Value.surname}, {student.Value.year}, {student.Value.exam}, {student.Value.balls}");
                    }
                }
                else
                {
                    Console.WriteLine("Такой опции в меню не существует");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ваш запрос некорректен");
            }
            Console.WriteLine();


            Console.WriteLine("Задание 2, получат ли викинги пиво?");
            Console.WriteLine("Сколько оценок у Bavarian Beer Bears?");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько оценок у Scandinavian Schöllers?");
            int b = int.Parse(Console.ReadLine());
            byte[] first_comand = new byte[a];
            byte[] second_comand = new byte[b];
            byte value1 = 0; byte value2 = 0;
            Console.WriteLine("Введите оценки первой и второй команд:");
            for (int i = 0; i < a; i++)
            {
                if (value1 >= 0 && value1 <= 9)
                {
                    Console.Write($"{i + 1} оценка первой команды:");
                    value1 = byte.Parse(Console.ReadLine());
                    first_comand[i] = value1;
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine();
            for (int j = 0; j < b; j++)
            {
                if (value2 >= 0 && value2 <= 9)
                {
                    Console.Write($"{j + 1} оценка второй команды:");
                    value2 = byte.Parse(Console.ReadLine());
                    second_comand[j] = value2;
                }
                else
                {
                    return;
                }
            }
            СomparisonArray(first_comand, second_comand);
            Console.WriteLine();


            Console.WriteLine("Задание 3, история о жэке");
            string[] problems = { "Подключение", "Оплата", "Другое" };
            Window[] allWindows = new Window[3];
            for (int i = 0; i < 3; i++)
            {
                allWindows[i] = new Window();
                allWindows[i].problem = problems[i];
            }
            Zina zina = new Zina(allWindows);
            zina.Distribution();
            for (int i = 0; i < allWindows.Length; i++)
            {
                allWindows[i].SortVillagers();
                allWindows[i].WorkWithVillager();
            }
            Console.WriteLine();

            Console.WriteLine("Задание 4, обход графа в ширину");
            Graph();
        }
    }
}