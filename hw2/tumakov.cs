using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tumakov
{
    enum Credits
    {
        Текущий,
        Сберегательный
    }
    struct infoschet
    {
        public long nomer;
        public string type;
        public string balance;
        public infoschet(long nomer, string type, string balanse) : this()
        {
            this.nomer = nomer;
            this.type = type;
            this.balance = balanse;
        }
        public void Print()
        {
            Console.WriteLine($"Номер банковкого счета: {nomer}" + "\n" + $"Тип банковского счета: {type}" + "\n" + $"Баланс на банковском счету: {balance}");
        }
    }
    enum VUZ
    {
        KGU = 0,
        KAI = 1,
        KHTI = 2
    }
    struct rabotnik
    {
        public string namee;
        public int vuz;
        public rabotnik(string namee, int vuz) : this()
        {
            this.namee = namee;
            this.vuz = vuz;
        }
        public void Print()
        {
            Console.WriteLine("Информация о работнике: " + "\n" + $"Имя: {namee}" + "\n" + $"ВУЗ: {vuz}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков, Задание 3.1 практическая, текущий и сберегательный кредит");
            foreach (Credits credit in Enum.GetValues(typeof(Credits)))
            {
                Console.WriteLine("Кредит - {0}, Номер - {1}", credit, (int)credit);
            }
            Console.WriteLine();
            Console.WriteLine("Тумаков, Задание 3.2 практическая, информация о банковском счете");
            infoschet information = new infoschet(35476512952, "текущий", "1000000000$");
            information.Print();
            Console.WriteLine();
            Console.WriteLine("Тумаков, Задание 3.1 домашняя, информация о работнике");
            rabotnik Rabotnik1 = new rabotnik("Карчевский Карчесвкий", (int)VUZ.KAI);
            Rabotnik1.Print();
            rabotnik Rabotnik2 = new rabotnik("Першин Першин", (int)VUZ.KGU);
            Rabotnik2.Print();
            rabotnik Rabotnik3 = new rabotnik("Абгарян Абгарян", (int)VUZ.KHTI);
            Rabotnik3.Print();
            Console.WriteLine("Примечание: 0 - КГЭУ; 1 - КАИ; 2 - КХТИ");
        }
    }
}
