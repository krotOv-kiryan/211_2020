using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace _211_2020
{
    class Program
    {
        static void Main(string[] args)
        {/*у меня не получилось сделать так,чтобы мы сами в консоли
вводили произвольное имя и день рождения кота,поэтому я
просто его задам - Kot(я не понимаю,как это реализовать) */
            /*
            о боже,у меня мочень много ошибок...как классно исправлять их по одной за 15 минут.
            первое-попробовал добавить к названию класса Cat "_"(Cat_),чтобы из 14 ошибок получилось меньше.
            Всё задуманное сработало.НО появилось ещё 10,
            
             Ошибка	CS0246	Не удалось найти тип или имя пространства имен "Cat"
            (возможно, отсутствует директива using или ссылка на сборку).	
            Меняя имя этого класса я просто сделал кучу ошибок. Не знаю,что делать.10 ошибок так и висит.

            исправляя одну ошибку,я сталкиваюсь с другой такой же ,либо вообще другой по смыслу. 
            */
            Cat c = new Cat("Kot", new DateTime(2001, 01, 01));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} {c.GetAge()} лет");
            Cat ct = new Cat("Stepa", new DateTime(2003, 08, 25));

            CatSmartHouse catSmartH = new CatSmartHouse(1000);

            catSmartH.AddCat(c);

            catSmartH.AddCat(ct);

            Console.ReadLine();

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
