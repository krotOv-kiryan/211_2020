using System;

namespace _211_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
у меня не получилось сделать так,чтобы мы сами в консоли
вводили произвольное имя и день рождения кота,поэтому я
просто его задам - Kot(я не понимаю,как это реализовать) */

            Cat c = new Cat("Kot", new DateTime(2001, 01, 01));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} {c.GetAge()} лет");

            double n = 0;
            Console.WriteLine($"Программа сделана правильно?(1= да, 2= нет");
            double.TryParse(Console.ReadLine(), out n);
            if (n == 1)
            {
                Console.WriteLine($"Спасибо.");
            }
            if (n == 2)
            {
                Console.WriteLine($"Ладно.");
            }
            c.HungryStatus = 150;
            Console.ReadLine();

        }
    }
}
