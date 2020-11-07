using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _211_2020
{
    class Cat
    {
        public class Cat

        {

            byte _hungryStatus;

            public event EventHandler HungerStatusChenged;

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

                get; set;

            }

            public int GatAge()

            {

                return (DateTime.Today - BerthDay).Days / 365;

            }

            public byte HungryStatus

            {

                get { return _hungryStatus; }

                set

                {

                    byte status = value;

                    if (status < 0)

                    {

                        status = 0;

                    }

                    else if (status > 100)

                    {

                        status = 100;

                    }

                    if (_hungryStatus != status)

                    {

                        HungerStatusChenged?.Invoke(this, null);

                    }

                    _hungryStatus = status;

                }

            }

            public void Feed(byte needFood)

            {

                HungryStatus += needFood;

            }

            public void GetStatus()

            {

                Console.WriteLine(Name);

                Console.WriteLine($"Возрост: {GatAge()}");

                if (HungryStatus <= 10)

                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Кошка умерает от голода :(");

                }

                else if (HungryStatus > 10 && HungryStatus <= 40)

                {

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Кошка очень голодна");

                }

                else if (HungryStatus > 40 && HungryStatus <= 70)

                {

                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"Кошка хочет кушать");

                }

                else if (HungryStatus > 70 && HungryStatus <= 90)

                {

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"Кошка не против перекусить");

                }

                else if (HungryStatus > 90)

                {

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"Кошка недавно поела");

                }

                Console.ResetColor();

            }

            async Task LifeCircle()

            {

                await Task.Delay(1000);

                HungryStatus -= 10;

                /*if (HungryStatus == 0)

                {

                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine($"Кошка {Name} умерла...");

                }

                else*/

                await LifeCircle();

            }

        }

    }


}
    
