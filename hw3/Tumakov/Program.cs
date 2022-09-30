
namespace Tumakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тумаков классная работа задание 4.1, перевод числа в месяц и день месяца");
            Console.Write("Введите день года в диапозоне 1-365: ");
            DateTime data = Convert.ToDateTime("01.01.2022");
            int num = Convert.ToInt32(Console.ReadLine());
            data = data.AddDays(num - 1);
            Console.WriteLine(data.ToString("Введенный вами день года в формате день-месяц: d MMMM"));



            Console.WriteLine();
            Console.WriteLine("Тумаков классная работа задание 4.2, перевод числа в месяц и день месяца с учетом исключения");
            Console.Write("Введите день года в диапозоне 1-365: ");
            DateTime date = Convert.ToDateTime("01.01.2022");
            int numm = Convert.ToInt32(Console.ReadLine());
            if (numm < 1 || numm > 365)
                Console.WriteLine("Пожалуйста, введите день года в диапозоне 1-365");
            else
            {
                date = date.AddDays(numm - 1);
                Console.WriteLine(date.ToString("Введенный вами день года в формате день-месяц: d MMMM"));
            }
            Console.WriteLine();


            Console.WriteLine("Тумаков домашняя работа задание 4.1, c учетом високосности");
            Console.Write("Введите день года в диапозоне 1-365: ");
            int nuumm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            DateTime datee = Convert.ToDateTime("01.01.2022");
            if (nuumm < 1 || nuumm > 365)
            {
                Console.WriteLine("Пожалуйста, введите день года в диапозоне 1-365");
            }
            else
            {
                datee = datee.AddDays(nuumm - 1);
                Console.WriteLine(datee.ToString("Введенный вами день года в формате день-месяц: d MMMM"));
            }
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year} год-високосный ");
            }
            else
            {
                Console.WriteLine($"{year} год-не високосный ");
            }
            Console.WriteLine();
        }
    }
}