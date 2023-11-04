using Antlr.Runtime;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChipsFastFood.Controllers
{
    public class PlayingMachineController : ApiController
    {
        /// <summary>
        /// This program, uses a while loop to simulate the number of turns a player can play after inserting
        /// a certain number of coins and counts the number of plays before the coins = 0. 
        /// and then subtracts the payouts when the specified number of turns is reached for each machine.
        /// </summary>
        /// <param name="id">the input is an integer</param>
        /// <returns>
        /// GET ../api/J3/SlotMachine/50 ---> there are 13 number of turns played before 50 reaches 0 
        /// GET ../api/J3/SlotMachine/70 ---> there are 13 number of turns played before 70 reaches 0 
        /// GET ../api/J3/SlotMachine/80 ---> there are 13 number of turns played before 80 reaches 0 
        /// </returns>
        
        [HttpGet]
        [Route("api/J3/SlotMachine/x")]
        public string SlotMachines(int x)
        {
            
            int turns = 0; 

            int machineATurns = 35;
            int machineBTurns = 100;
            int machineCTurns = 10;

            int machineAPayout = 30;
            int machineBPayout = 60;
            int machineCPayout = 9;

            while (x > 0)
            {
                turns++;

                if (turns % machineATurns == 0)
                {
                    x -= machineAPayout;
                }

                if (turns % machineBTurns == 0)
                {
                    x -= machineBPayout;
                }

                if (turns % machineCTurns == 0)
                {
                    x -= machineCPayout;
                }

                if (x <= 0)
                {
                    break;
                }
            }

            return "There are " + turns + "Number of turns played before" + x + "= 0: ";
        }

    }
}
