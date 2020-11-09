using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _211_2020
{
    class Cat_SmartHouse
    {
        public class CatSmartHouse
        {
            List<Cat> cats = new List<Cat>();
            public CatSmartHouse(int foodResource)
            {
                FoodResource = foodResource;
            }
            public int FoodResource { get; set; }
            public void AddCat(Cat cat)
            {
                cats.Add(cat);
                cat.HungerStatusChenged += Cat_HungerStatusChenged;
            }
            private void Cat_HungerStatusChenged(object sender, EventArgs e)
            {
                var cat = (Cat)sender;
                if (cat.HungryStatus <= 20 && FoodResource > 0)
                {
                    byte needFood = (byte)(100 - cat.HungryStatus);

                    if (FoodResource > needFood)
                        FoodResource -= needFood;
                    else
                    {
                        needFood = (byte)FoodResource;

                        FoodResource = 0;
                    }

                    cat.Feed(needFood);

                    Console.WriteLine($"Покормлена кошка: {cat.Name}\nОстаток еды в вольере: {FoodResource}");
                    //обязательно добавлять английскиую букву n? после \

                }

            }

        }
    }
}
