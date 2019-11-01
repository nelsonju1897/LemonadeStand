using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables

        public string condition;
        public int conditionCount;
        public int tempCount;
        public int temperature;
        private List<string> weatherConditions = new List<string>() {"Sunny", "Sunny", "Sunny", "Sunny", "Sunny", "Rainy", "Rainy", "Rainy" };
        private List<int> tempChoice = new List<int>() { 50, 55, 65, 75, 75, 75, 90, 90, 90, 90 };

        //constructor
        public Weather(Random rng)
        {
            conditionCount = weatherConditions.Count;
            tempCount = tempChoice.Count;
            DailyWeatherCondition(rng);
            DailyTempCondition(rng);
        }

        //member methods

        public void DailyWeatherCondition(Random rng)
        {
            int WeatherChoice = rng.Next(conditionCount);
            condition = weatherConditions[WeatherChoice];
        }

        public void DailyTempCondition(Random rng)
        {
            int TempChoice = rng.Next(tempCount);
            temperature = tempChoice[TempChoice];
        }





    }
}
