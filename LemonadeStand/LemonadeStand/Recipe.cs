using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables

        public int AmountOfLemons;
        public int AmountOfSugarCubes;
        public int AmountOfIceCubes;
        public double PricePerCup;

        //constructor
        public Recipe()
        {
            AmountOfLemons = 10;
            AmountOfSugarCubes = 10;
            AmountOfIceCubes = 10;
            PricePerCup = .25;
        }

        //member methods

       
        public void DisplayRecipe()
        {
            Console.WriteLine(Environment.NewLine + "Your current recipe is:");
            Console.WriteLine("Lemons: " + AmountOfLemons);
            Console.WriteLine("Sugar Cubes: " + AmountOfSugarCubes);
            Console.WriteLine("Ice Cubes: " + AmountOfIceCubes);
            Console.WriteLine("Price per Cup: " + PricePerCup);
        }

        public void ChangeRecipe(Player player, Store store)
        {
            Console.WriteLine("Would you like to change the amount of lemons, sugar cubes, ice cubes, price per cup or return to the lemonade stand?");
            string input = Console.ReadLine();
            if(input == "lemons")
            {
                Console.WriteLine("How many lemons do you want to put in the recipe?");
                int numLemons = Int32.Parse(Console.ReadLine());
                if(numLemons <= player.inventory.lemons)
                {
                    AmountOfLemons = numLemons;
                    player.inventory.lemons = player.inventory.lemons - numLemons;
                    DisplayRecipe();
                    ChangeRecipe(player, store);
                }
                else if(numLemons > player.inventory.lemons)
                {
                    Console.WriteLine("You do not have enough lemons. Returning to recipe.");
                    ChangeRecipe(player, store);
                }

            }
            if (input == "sugar cubes")
            {
                Console.WriteLine("How many sugar cubes do you want to put in the recipe?");
                int numSugarCubes = Int32.Parse(Console.ReadLine());
                if (numSugarCubes <= player.inventory.sugarCubes)
                {
                    AmountOfSugarCubes = numSugarCubes;
                    player.inventory.sugarCubes = player.inventory.sugarCubes - numSugarCubes;
                    DisplayRecipe();
                    ChangeRecipe(player, store);
                }
                else if (numSugarCubes > player.inventory.sugarCubes)
                {
                    Console.WriteLine("You do not have enough sugar cubes. Returning to recipe.");
                    ChangeRecipe(player, store);
                }
            }
            if (input == "ice cubes")
            {
                Console.WriteLine("How many ice cubes do you want to put in the recipe?");
                int numIceCubes = Int32.Parse(Console.ReadLine());
                if (numIceCubes <= player.inventory.iceCubes)
                {
                    AmountOfIceCubes = numIceCubes;
                    player.inventory.iceCubes = player.inventory.iceCubes - numIceCubes;
                    DisplayRecipe();
                    ChangeRecipe(player, store);
                }
                else if (numIceCubes > player.inventory.iceCubes)
                {
                    Console.WriteLine("You do not have enough ice cubes. Returning to recipe.");
                    ChangeRecipe(player, store);
                }
            }
            if (input == "price")
            {
                Console.WriteLine("Set new price");
                double newPrice = double.Parse(Console.ReadLine());
                PricePerCup = newPrice;
                DisplayRecipe();
                ChangeRecipe(player, store);

            }
            if (input == "lemonade stand")
            {
                player.stand.LemonadeStandOptions(player, store);
            }
        }

    }
}
