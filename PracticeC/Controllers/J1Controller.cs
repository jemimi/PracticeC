using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeC.Controllers
{/// <summary>
/// Assignment2:J1 Counting calories 
/// STEPS:
/// 1. Used If/else statement for burger menu as a diagnostic test to see 
/// if input of number at "api/Ji/Menu/3" returns 420. It works! Move to the next step
/// 2. Add each of the menu items with if/else statements and then test if it works by running the server
/// If it does, move on to the next menu item. 
///  <example>GET api/J1/Menu/4/4/4/4/ -> "Your total calorie count is 0" </example>
///  <example>GET api/J1/Menu/1/2/3/4/ -> "Your total calorie count is 691"</example>
/// <param name="burger">burger choice to # of calories </param>
/// <param name="drink">drink choice to # of calories </param>
/// <param name="side">side choice to # of calories </param>
/// <param name="dessert">side choice to # of calories </param>
///
/// </summary>
/// 
    public class J1Controller : ApiController
    {
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert )
        {

         int calorie;

         //Burger calories
            if (burger == 1)
                {
                    calorie = 461;
                }
            else if (burger == 2)
                {
                    calorie = 431;
                }
            else if (burger == 3)
                {
                    calorie = 420;
                }
            else
                {
                    calorie = 0;
                }
              
         //drink choices  = calories
            if (drink == 1)
                {
                    calorie = calorie +  130;
                }
            else if (drink == 2)
                {
                    calorie = calorie + 160;
                }
            else if (drink == 3)
                {
                    calorie = calorie + 118;
                }
            else
                {
                    calorie = 0;
                }

            
           //side choices  = calories
           if (side == 1)
                {
                    calorie = calorie + 100;
                }
           else if (side == 2)
                {
                    calorie = calorie + 57;
                }
           else if (side == 3)
                {
                    calorie = calorie + 70;
                }
           else
                {
                    calorie = 0;
                }

            //dessert choices  = calories
            if (dessert == 1)
                {
                    calorie = calorie + 167;
                }
            else if (dessert == 2)
                {
                    calorie = calorie + 266;
                }
            else if (dessert == 3)
                {
                    calorie = calorie + 75;
                }
            else
                {
                    calorie = 0;
                }

            //total number of calories from 4 menu items of burgers, drink, side, dessert
            return "Your total calorie count is " + calorie;







        }


    }
}
