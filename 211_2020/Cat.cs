using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _211_2020
{
    class Cat
    {
        byte _hungryStatus;
        public Cat(string name, DateTime berthday)
        {

            Name = name;
            BerthDay = berthday;
            Task.Run(LifeCircle);


        }

        public string Name
        {
            get;

            set;
        }
        public void MakeNoise()
        {

            Console.WriteLine($"{Name} мяукает");
        }
        public DateTime BerthDay
        {
            get;

            set;

        }
        public int GetAge()
        {
            return (DateTime.Today - BerthDay).Days / 365;

        }
        public byte HungryStatus
        {
            get { return HungryStatus; }
            set
            {
                if (value < 0)
                {
                    HungryStatus = 0;
                }
                else if (value > 100)
                {
                    HungryStatus = 100;
                }
                else
                    HungryStatus = value;
            }
        }
        public void Getstatus()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Возраст:{GetAge()}");
            if (HungryStatus <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Кошка умерает от голода:(");
            }
            else if (HungryStatus > 10 && HungryStatus <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Кошка очень голодна:");
            }
            else if (HungryStatus > 40 && HungryStatus <= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Кошка хочет кушать :");
            }
            else if (HungryStatus > 70 && HungryStatus <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Кошка не против перекусить:");
            }
            else if (HungryStatus > 90)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Кошка недавно поела :(");
            }
            Console.ResetColor();

        }
        async Task LifeCircle()
        {
            await Task.Delay(1000);
            HungryStatus -= 10;
            Getstatus();
            if (HungryStatus == 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Кошка умерла:(");
            }
            else
                await LifeCircle();
        }
    }
}
    
