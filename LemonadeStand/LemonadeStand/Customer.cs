using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        public string weatherCondition;
        public int temperatureCondition;
        public int lemonCondition;
        public int ConditionCount;
        public int iceCubeCondition;
        public int sugarCubeCondition;
        public double pricePerCupCondition;
        public List<int> recipeCount = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


        //constructor
        public Customer(Weather weather, Random rng)
        {
            ConditionCount = recipeCount.Count;
            pricePerCupCondition = 0.50;
            AmountOfLemons(rng);
            AmountOfSugarCubes(rng);
            AmountOfIceCubes(rng);
            weather.DailyWeatherCondition(rng);
            weatherCondition = weather.condition;
            weather.DailyTempCondition(rng);
            temperatureCondition = weather.temperature;
        }

        //member methods
        public void AmountOfLemons(Random rng)
        {
            int LemonChoice = rng.Next(ConditionCount);
            lemonCondition = recipeCount[LemonChoice];
        }

        public void AmountOfSugarCubes(Random rng)
        {
            int SugarCubeChoice = rng.Next(ConditionCount);
            sugarCubeCondition = recipeCount[SugarCubeChoice];
        }

        public void AmountOfIceCubes(Random rng)
        {
            int IceCubeChoice = rng.Next(ConditionCount);
            iceCubeCondition = recipeCount[IceCubeChoice];
        }
        public bool WillBuy(Weather weather, Player player)
        {
            if (weatherCondition == weather.condition && 
                temperatureCondition == weather.temperature && 
                lemonCondition <= player.recipe.AmountOfLemons && 
                sugarCubeCondition <= player.recipe.AmountOfSugarCubes && 
                iceCubeCondition <= player.recipe.AmountOfIceCubes && 
                pricePerCupCondition >= player.recipe.PricePerCup)
            {
                Console.WriteLine("it worked.");
                BoughtLemonade(player);
                return true;
            }
            else
            {
                Console.WriteLine("No lemonade for you");
                return false;
            }
        }

        public void BoughtLemonade(Player player)
        {
            player.inventory.SubtractCup(player);
        }
    }
}
