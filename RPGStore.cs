using System;

namespace RPGStore
{
    class Program
    {
        static void Line()
        {
            Console.WriteLine("--------------");
        }

        static void Main(string[] args)
        {
            int choice;
            int newgold;
            //int input;

            Player player = new Player("Faye", 100);

            Console.WriteLine("Welcome to my shop young traveler {0}! What supplies do you seek?", player.Name);

            Line();

            do
            {
                Console.WriteLine("Your Gold: {0}", player.Gold);
                Console.WriteLine("1) Items");
                Console.WriteLine("2) Weapons");
                Console.WriteLine("3) Armour");
                Console.WriteLine("4) Exit");
                Console.Write("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Line();
                        //This was where I was stuck
                        //I had to assign this stupid parameter 
                        //to a new int variable in order
                        //to update my player's gold after shopping
                        newgold = Items.ItemStock(player.Gold);
                        player.SetNewGold(newgold);
                        Line();
                        break;
                }
            } while (choice != 4);

            Console.WriteLine("Thank you, come again!");

            Console.ReadKey();
        }
    }
}
