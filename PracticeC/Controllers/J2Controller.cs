using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace PracticeC.Controllers
{
    /// <summary>
    /// J2: Roll the Dice
    /// 
    /// Write a program which determines how many ways dice can be rolled to add up to 10.
    /// 
    /// Logic: 
    /// 
    /// For loop for Dice 1 sides
    ///     Nested for loop for Dice 2 sides
    ///         If statement to check for the sum of 2 sides equals to 10, if yes, then add 1 way
    ///    
    /// How the loops works 
    /// m =3, n = 3
    /// 
    /// m    n    x    y
    /// 1   1    4    0
    /// 1   2    5    0
    /// 1   3    6    0
    /// 
    /// m    n    x    y
    /// 2    1   4    0
    /// 2    2   5    0
    /// 2    3   6    0
    /// 
    /// m    n    x    y
    /// 3    1    4    0
    /// 3    2    5    0
    /// 3    3    6    0
    /// 
    /// <param name= "m"> Dice 1 has "m" sides </param>
    /// <param name= "n"> Dice 2 has "n" sides </param>
    /// <param name= "k"> The count for "k" sides for Dice 1 </param>
    /// <param name= "j"> The count for "j" sides for Dice 2 </param>
    /// <param name= "x"> The sum of the 2 sides (x= k+j) </param>
    /// <param name= "y"> If x == 10, then there is 1 way and keep adding +1 so long the number of ways 
    /// equals to 10.
    /// <example>api/J2/DiceGame/6/8 -> There are 5 ways to get the sum 10 </example>
    /// <example>api/J2/DiceGame/12/4 -> There are 4 ways to get the sum 10 </example>
    /// <example>api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10 </example>
    /// <example>api/J2/DiceGame/5/5 -> There are 1 ways to get the sum 10 </example>
    /// 
    /// </summary>
    /// 

    public class J2Controller : ApiController
    {
        
       [HttpGet]
       [Route("api/J2/DiceGame/{m}/{n}")]
       public string DiceGame(int m, int n)

       {
           string message = "";
           int k;
           int j;
            int y = 0;
           //int m; //Dice 1 number of sides
           //int n; // Dice 2 number of sides

           for (k = 1; k <= m; k++)   
           {
                for (j = 1; j <= n; j++) 
                {
                    int x = k + j;
                    if (x == 10)
                    {
                        y = y + 1;
                    }

                }
           
           }
            
            message = "There are " + y + " ways to get the sum 10.";
            return message;
        }
        


       
    }
}
