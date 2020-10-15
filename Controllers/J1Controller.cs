using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace A2.Controllers
{
    public class J1Controller : ApiController
    {
        [HttpGet]
        //Routing
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //Run int burger through 1 - 4 menu selections
            if (burger == 1)
            {
                burger = 461;
            } else if (burger == 2)
            {
                burger = 431;
            } else if (burger == 3)
            {
                burger = 420;
            } else if (burger == 4)
            {
                burger = 0;
            }

            //Run int drink through 1 - 4 menu selections
            if (drink == 1)
            {
                drink = 130;
            } else if (drink == 2)
            {
                drink = 160;
            } else if (drink == 3)
            {
                drink = 118;
            } else if (drink == 4)
            {
                drink = 0;
            }

            //Run int side through 1 - 4 menu selections
            if (side == 1)
            {
                side = 100;
            } else if (side == 2)
            {
                side = 57;
            } else if (side == 3)
            {
                side = 70;
            } else if (side == 4)
            {
                side = 0;
            }

            //Run int dessert through 1 - 4 menu selections
            if (dessert == 1)
            {
                dessert = 167;
            } else if (dessert == 2)
            {
                dessert = 266;
            } else if (dessert == 3)
            {
                dessert = 75;
            } else if (dessert == 4)
            {
                dessert = 0;
            }

            //Final calculation for total amount of calories
            int calories = burger + drink + side + dessert;
            //Final prompt
            return "Your total calories is " + calories;
        }
    }
}
