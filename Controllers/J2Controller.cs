using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace A2.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        //PROBLEM: There are two dice, user gets to indicate how many sides each dice has. 
        //How many ways are there to get to a sum of 10 with dice that have variable sides?
        public string DiceGame(int m, int n) //Die 1 (m), die 2 (n)
        {
            //solution is how many ways both dice added together will equal 10
            int solutions = 0;

       
          //looping for every side on dice 1
          for (int i = 1; i <= m ; i++)
            {
                //looping for every side on dice 2
                for (int v = 1; v <= n; v++)
                {
                    //checking if sum is 10
                    if (i + v == 10)
                    {
                        //if sum is 10, adds +1 to solutions
                        solutions++;
                    }
                }
            }

          //final prompt
            return "There are " + solutions + " ways to get the sum of 10";
            


        }


    }
}
