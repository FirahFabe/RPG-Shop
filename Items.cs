using System;
using System.Collections.Generic;
using System.Text;

namespace RPGStore
{
    public class Items
    {
        private string name;
        private int cost;

        public Items(string itemName, int itemCost)
        {
            name = itemName;
            cost = itemCost;
        }

        //public string Name { get; set; }
        //public int Cost { get; set; }

        public static int ItemStock(int money)
        {
            int PlayerMoney = money;
            int item_choice;

            Items potion = new Items("Potion", 5);
            Items Mpotion = new Items("Magic Potion", 8);
            Items revive = new Items("Revive", 10); 

            do
            {
                Console.WriteLine("1){0} - {1}", potion.name, potion.cost);
                Console.WriteLine("2){0} - {1}", Mpotion.name, Mpotion.cost);
                Console.WriteLine("3){0} - {1}", revive.name, revive.cost);
                Console.WriteLine("4) Cancel");

                Console.Write("Enter choice: ");
                item_choice = Convert.ToInt32(Console.ReadLine());

                switch (item_choice)
                {
                    case 1:
                        if (PlayerMoney <= potion.cost)
                        {
                            Console.WriteLine("Not enough gold!");
                        }
                        else
                        {
                            PlayerMoney = PlayerMoney - potion.cost;
                            Console.WriteLine("{0} purchased.", potion.name);
                        }
                        break;
                    case 2:
                        if (PlayerMoney <= Mpotion.cost)
                        {
                            Console.WriteLine("Not enough gold!");
                        }
                        else
                        {
                            PlayerMoney = PlayerMoney - Mpotion.cost;
                            Console.WriteLine("{0} purchased.", Mpotion.name);
                        }
                        break;
                    case 3:
                        if (PlayerMoney <= revive.cost)
                        {
                            Console.WriteLine("Not enough gold!");
                        }
                        else
                        {
                            PlayerMoney = PlayerMoney - revive.cost;
                            Console.WriteLine("{0} purchased.", revive.name);
                        }
                        break;
                }
                //Console.WriteLine("Current Gold: {0}", PlayerMoney);

            } while (item_choice != 4);
         
            return PlayerMoney;
        }
        /*
        public static int NewGold(int Pmoney)
        {
            int 
        }*/

    }
}
