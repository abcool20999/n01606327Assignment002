using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChipsFastFood.Controllers
{
   
    public class DiceRollController : ApiController
        
    {
        /// <summary>
        /// This program determines how many ways you can roll two dice having m and n sides to get the value of 10.
        /// </summary>
        /// <param name="id">the input is an integer</param>
        /// <returns> 
        /// GET ../api/J2/DiceGame/6/8  ---> There are 5 total ways to get the sum 10.
        /// GET ../api/J2/DiceGame/12/4 ---> There are 4 ways to get the sum 10.
        /// GET ../api/J2/DiceGame/3/3  ---> There are 0 ways to get the sum 10.
        /// GET ../api/J2/Dicegame/5/5  ---> There is 1 way to get the sum 10.
        /// </returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
       

        public string diceRoll(int m, int n)
        { 
            int totalSum = 10; 
            int Counter = 0; 

            
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    
                    if (i + j == totalSum)
                    {
                        Counter++; 
                    }
                }
            }

            return "There are " + Counter + " ways to get to the sum " + totalSum;
        }
    }
}
