using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class StandPrep
    {
        //member variables

        //constructor

        //member methods
        public void LemonadeStandOptions(Player player, Store store)
        {
            Console.WriteLine(Environment.NewLine + "Welcome to your lemonade stand. Would you like to change your recipe, start selling lemonade or return to main menu?");
            Console.WriteLine("Type: recipe");
            Console.WriteLine("Type: sell");
            Console.WriteLine("Type: main menu");
            string input = Console.ReadLine();
            if(input == "recipe")
            {
                GoToRecipe(player, store);
            }
            if (input == "sell")
            {
                //day.SoldLemonade(player);
            }
            if(input == "main menu")
            {
                player.GoTo(player, store);
            }
            
            
        }
        public void GoToRecipe(Player player, Store store)
        {
            player.recipe.DisplayRecipe();
            player.recipe.ChangeRecipe(player, store);
        }
    }
}
