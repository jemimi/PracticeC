using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeC.Controllers
{
    public class LoopsController : ApiController
    {
        //Challenge1
        // Print 1 to 25 counting by 1s
        // GET/api/Loops/C1While

        [HttpGet]
        public string C1While()
        {
            string message = "";
            int i = 1;
            while (i < 25)
            {
                //adding i to the message 
                message = message + i.ToString() + ",";
                //incremeting our iterating variable
                i = i + 1;
            }
            return message;
        }

        //GET / api/Loops/C1For
        //Print 1 to 25 counting by 1s
        [HttpGet]
        public string C1For()
         {
            string message = "";
            for(int i = 1; i<=25; i++)
            {
                message = message + i.ToString() + ",";

            }

            return message;
                
         }

    
           //Challenge 2
           // Print -10 to 10 counting by 1s
           //GET / api/Loops/C2While
           [HttpGet]
           public string C2While()
           {
            string message = "";
            int i = -10;
            while (i <=10)
            {
                //adding i to the message 
                message = message + i.ToString() + ",";
                //incremeting our iterating variable by 1
                i = i + 1; //i++
            }
            return message;
           }

        

         //GET / api/Loops/C2For
         [HttpGet]
         public string C2For()
         {
            string message = "";
            for (int i = -10; i <= 10; i++)
            {
                message = message + i.ToString() + ",";

            }

            return message;
         }

        
         //Challenge 3
         //Print -20 to -10 by 2s

         //GET / api/Loops/C3While
         [HttpGet]
         public string C3While()
         {
            int i = -20;
            string message = "";
            while (i <= -9)
            {
                //adding i to the message 
                message = message + i.ToString() + ",";
                //incremeting our iterating variable
                i = i + 2;  // or i++
             }

            return message;
         }


         //GET / api/Loops/C3For
         [HttpGet]
         public string C3For()
         {
            string message = "";
            for(int i= -20; i <=10; i=i+2)
            {
                message = message + i.ToString() + ",";

            }
             return message;
         }

        
         //Challenge 4
         //Print -30 to 30 counting by 4s

         //GET / api/Loops/C4While
         [HttpGet]
         public string C4While()
         {
            string message = "";
            int i = -30;
            while(i <=30)
            {
                i = i + 4;
                message = message + i.ToString() + ",";
            }
             return message;
         }

        
         //GET / api/Loops/C4For
         [HttpGet]
         public string C4For()
         {
            string message = "";
            for(int i= -30; i<=30; i=i+4 )
            {
                message = message + i.ToString() + ",";

            }
             return message;
         }


         //Challenge 5
         //Create an array of favorite movies, print each one

         //GET / api/Loops/C5While

        //working with ienumerable data types 
         [HttpGet]
         public string C5While()
         {
            string [] movies = { "HarryPotter", "Mulan", "Beetlejuice", "Alice" };
            string message = "";
            int i = 0;
            while (i <= movies.Length-1)
            {
                string delimeter = ",";
                if(i==(movies.Length-1)) //refers to the last item of array
                {
                    delimeter = "."; //tells the delimeter to stop with commas
                }
                message = message + movies[i]+ delimeter;
                i++;
            }

            return message;
            
        }

         //GET / api/Loops/C5For
         [HttpGet]
         public string C5For()
         {
             return "";
         }

            


    }

}
    