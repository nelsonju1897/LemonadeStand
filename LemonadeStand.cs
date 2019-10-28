using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather w = new Weather();
            //w.DailyWeatherCondition();
            //w.DailyTempCondition();

            Game game = new Game();
            game.RunGame();

        ///////////////////////////////////////////////////////////////////////////////////////

            // Display rules
            // Player inputs name
            // Display forcast
                //Forcast should range from Sunny to Rainy
                //Forcast should range in tempurature from 55 degrees to 95 degrees
            // Display day
            // Display wallet
            // Display Inventory
            // Give option to go to store
                // While at the store
                    // Buy cups
                    // Buy ice cubes
                    // Buy lemons
                    // Buy sugar
                    // return home
            // Display current recipe
                // Give option to change recipe
                    // While changing recipe
                        // Change amount of ice cubes
                        // Change amount of lemons
                        // Change amount of sugar
                        // Return home
            // Give option to start day
                //When day starts
                    //Customers go by and buy lemonade determined by random criteria
                        //Random criteria: Price of lemonade and weather conditions
                    // Amount of lemons, ice, and sugar will decrease per number of pitchers made
                    // Number of cups will decrease per cups of lemonade sold
                    //Pitchers will be determined by number of cups of lemonade can be made out of them



        }
    }
}
