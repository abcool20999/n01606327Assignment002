using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChipsFastFood.Controllers
{


  
    public class chipsFastFoodController : ApiController
    {
        /// <summary>
        /// This program computes the total calories of a meal when a food item is selected by entering a digit choice.
        /// </summary>
        /// <param name="id">the input id is an integer</param>
        /// <returns>
        /// GET ../api/J1/Menu/4/4/4/4 ---> Your total calorie count is 0
        /// GET ../api/J1/Menu/1/2/3/4 ---> Your total calorie count is 691
        /// </returns>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Get(int burger, int drink, int side, int dessert)
        {
            int burgerCalories = 0;
            int drinkCalories  = 0;
            int sideCalories = 0;
            int dessertCalories = 0;

            if (burger == 1)
            {
                burgerCalories = 461;
            }
            else if (burger == 2)
            {
                burgerCalories = 431;
            }
            else if (burger == 3)
            {
                burgerCalories = 420;
            }

            if (drink == 1)
            {
                drinkCalories = 130;
            }
            else if (drink == 2)
            {
                drinkCalories = 160;
            }
            else if (drink == 3)
            {
                drinkCalories = 118;
            }

            if (side == 1)
            {
                sideCalories = 100;
            }
            else if (side == 2)
            {
                sideCalories = 57;
            }
            else if (side == 3)
            {
                sideCalories = 70;
            }

            if (dessert == 1)
            {
                dessertCalories = 167;
            }
            else if (dessert == 2)
            {
                dessertCalories = 266;
            }
            else if (dessert == 3)
            {
                dessertCalories = 75;
            }

            int totalCalories = burgerCalories + drinkCalories + sideCalories + dessertCalories;

            return "Your total calorie count is " + totalCalories.ToString();
        }
    }

}
