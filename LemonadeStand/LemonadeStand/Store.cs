using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables (HAS A)
        public double PricePerLemon;
        public double PricePerSugarCube;
        public double PricePerIceCube;
        public double PricePerCup;
        public string input;

        //constructor
        public Store()
        {
            PricePerCup = 0.025;
            PricePerSugarCube = 0.03;
            PricePerIceCube = .05;
            PricePerLemon = 0.10;
        }
        
        public void WelcomeToStore(Player player, Store store)
        {
            Console.WriteLine(Environment.NewLine + "Welcome to the store! Below are the prices of the items.");
            DisplayStoreInventory(player, store);
        }
        public void DisplayStoreInventory(Player player, Store store)
        { 
            Console.WriteLine("Sugar cubes: $" + PricePerSugarCube);
            Console.WriteLine("Ice cubes: $" + PricePerIceCube);
            Console.WriteLine("Cups: $" + PricePerCup);
            Console.WriteLine("Lemons: $" + PricePerLemon);
            Console.WriteLine("Would you like to buy some items or go to the main menu? Type items or main menu");
            input = Console.ReadLine();
            if(input == "items")
            {
                BuyItems(player, store);
            }
            if(input == "main menu")
            {
                player.GoTo(player, store);
            }
        }

        public void BuyItems(Player player, Store store)
        {
            Console.WriteLine(Environment.NewLine + "Do you want to buy lemons, cups, ice cubes, sugar cubes or return to main menu?");
            input = Console.ReadLine();
            if(input == "lemons")
            {
                player.inventory.AddLemon(player, store);
            }
            if(input == "ice cubes")
            {
                player.inventory.AddIceCube(player, store);
            }
            if(input == "cups")
            {
                player.inventory.AddCup(player, store);
            }
            if(input == "sugar cubes")
            {
                player.inventory.AddSugarCube(player, store);
            }
            if(input == "main menu")
            {
                player.GoTo(player, store);
            }
        }


        
        

    }
}
