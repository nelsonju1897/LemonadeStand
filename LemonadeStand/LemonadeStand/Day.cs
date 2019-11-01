using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;
        public double dailyProfitMade;
        




        //constructor
        public Day(Random rng, Player player)
        {
            weather = new Weather(rng);
            customers = new List<Customer>();
            dailyProfitMade = 0;
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer(weather, rng);
                customers.Add(customer);
            }
         }

        //member methods

        public void RunDay(Player player, Store store)
        {
            
            player.inventory.DisplayInventory();
            player.DisplayUserWallet();
            player.GoTo(player, store);
            foreach (Customer customer in customers)
            {
                bool boughtLemonade = customer.WillBuy(weather, player);
                if(boughtLemonade == true)
                    {
                        ProfitMade(player);
                    }
                player.DisplayUserWallet();
                Console.WriteLine("Overall profit is: " + player.wallet.profitMade);
                Console.WriteLine("Daily Profit was: " + dailyProfitMade);
            }      
        }
        public void ProfitMade(Player player)
        {
            dailyProfitMade = dailyProfitMade + player.recipe.PricePerCup;
        }
        
    }

}
