using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        
        public Player player;
        public List<Day> days;
        public Random rng;
        public Weather weather;
        public Store store;
        public Customer customer;
        public Day day;
        //int CurrentDay;

        //constructor
        public Game()
        {
            rng = new Random();
            player = new Player();
            days = new List<Day>();
            store = new Store();
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day(rng, player);
                days.Add(day);                
            }
            
        }

        //member methods
        public void RunGame()
        {
            DisplayRules();
            player.ChooseName();
            player.DisplayUserWallet();
            DailyActivities();
            Console.ReadLine();
        }
        public void DailyActivities()
        {
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("Day: " + (i + 1) + " weather: " + days[i].weather.condition);
                Console.WriteLine("Day: " + (i + 1) + " temperature: " + days[i].weather.temperature + Environment.NewLine);
                days[i].RunDay(player, store);
                Console.ReadLine();
            }
        }
        private void DisplayRules()
        {
            Console.WriteLine("Here are the rules." + Environment.NewLine);
        }

       

    }





}

