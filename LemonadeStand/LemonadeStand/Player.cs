using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables

        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public StandPrep stand;
        public Day day;

        //constructor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
            stand = new StandPrep();
        }

        //member methods

        public void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine() + Environment.NewLine;
            Console.WriteLine("Player name is: " + name);
        }
        public void DisplayUserWallet()
        {
            Console.WriteLine("Your current cash is: $" + wallet.money + Environment.NewLine);
        }
        
        public void GoTo(Player player, Store store)
        {
            Console.WriteLine("Would you like to go to the store or go to the lemonade stand? Type: store or lemonade stand.");
            string input = Console.ReadLine();
            if (input == "store")
            {
                store.WelcomeToStore(player, store);
            }
            if(input == "lemonade stand")
            {
                stand.LemonadeStandOptions(player, store);
            }
        }
    }
}
