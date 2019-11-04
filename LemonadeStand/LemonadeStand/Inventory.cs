using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables

        public int lemons;
        public int iceCubes;
        public int cups;
        public int sugarCubes;
        public double storeLemonProfit;
        public double storeIceCubeProfit;
        public double storeSugarCubeProfit;
        public double storeCupProfit;
        public double storeTotalProfit;


        //constructor
        public Inventory()
        {
            lemons = 10;
            iceCubes = 10;
            cups = 10;
            sugarCubes = 10;
            storeLemonProfit = 0;
            storeCupProfit = 0;
            storeSugarCubeProfit = 0;
            storeIceCubeProfit = 0;
            
        }

        //member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Your current inventory is:" + Environment.NewLine);
            Console.WriteLine("Lemons: " + lemons);
            Console.WriteLine("Ice cubes: " + iceCubes);
            Console.WriteLine("Cups: " + cups);
            Console.WriteLine("Sugar cubes: " + sugarCubes);
            Console.ReadLine();
        }

        public void AddLemon(Player player, Store store)
        {
            Console.WriteLine("How many lemons do you want to buy?");
            int input = Int32.Parse(Console.ReadLine());
            if(player.wallet.money >= (input * store.PricePerLemon))
            {
                int numLemons = (input + lemons);
                lemons = numLemons;
                player.wallet.money = (player.wallet.money - (input * store.PricePerLemon));
                storeLemonProfit = storeLemonProfit + (input + store.PricePerLemon);
                player.DisplayUserWallet();
                DisplayInventory();
                store.BuyItems(player, store);
            }
            else if(player.wallet.money < (input * store.PricePerLemon))
            {
                Console.WriteLine("You do not have enough money to purchase that amount.");
                store.BuyItems(player, store);
            }
            
        }
        public void AddIceCube(Player player, Store store)
        {
            Console.WriteLine("How many ice cubes do you want to buy?");
            int input = Int32.Parse(Console.ReadLine());
            if (player.wallet.money >= (input * store.PricePerIceCube))
            {
                int numIceCubes = (input + iceCubes);
                iceCubes = numIceCubes;
                player.wallet.money = (player.wallet.money - (input * store.PricePerIceCube));
                storeIceCubeProfit = storeIceCubeProfit + (input * store.PricePerIceCube);
                player.DisplayUserWallet();
                DisplayInventory();
                store.BuyItems(player, store);
            }
            else if (player.wallet.money < (input * store.PricePerIceCube))
            {
                Console.WriteLine("You do not have enough money to purchase that amount.");
                store.BuyItems(player, store);
            }

        }
        
        public void AddCup(Player player, Store store)
        {
            Console.WriteLine("How many cups do you want to buy?");
            int input = Int32.Parse(Console.ReadLine());
            if (player.wallet.money >= (input * store.PricePerIceCube))
            {
                int numCups = (input + cups);
                cups = numCups;
                player.wallet.money = (player.wallet.money - (input * store.PricePerCup));
                storeCupProfit = storeCupProfit + (input * store.PricePerCup);
                player.DisplayUserWallet();
                DisplayInventory();
                store.BuyItems(player, store);
            }
            else if (player.wallet.money < (input * store.PricePerCup))
            {
                Console.WriteLine("You do not have enough money to purchase that amount.");
                store.BuyItems(player, store);
            }            
        }

        public void SubtractCup(Player player)
        {
            cups = cups - 1;
            player.wallet.money = player.wallet.money + player.recipe.PricePerCup;
            player.wallet.profitMade = (player.wallet.profitMade + player.recipe.PricePerCup) - storeTotalProfit;

        }
        public void AddSugarCube(Player player, Store store)
        {
            Console.WriteLine("How many sugar cubes do you want to buy?");
            int input = Int32.Parse(Console.ReadLine());
            if (player.wallet.money >= (input * store.PricePerIceCube))
            {
                int numSugarCubes = (input + sugarCubes);
                sugarCubes = numSugarCubes;
                player.wallet.money = (player.wallet.money - (input * store.PricePerSugarCube));
                storeSugarCubeProfit = storeSugarCubeProfit + (input * store.PricePerSugarCube);
                player.DisplayUserWallet();
                DisplayInventory();
                store.BuyItems(player, store);
            }
            else if (player.wallet.money < (input * store.PricePerSugarCube))
            {
                Console.WriteLine("You do not have enough money to purchase that amount.");
                store.BuyItems(player, store);
            }

        }
    }
}
