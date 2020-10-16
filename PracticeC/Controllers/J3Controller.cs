using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PracticeC.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        /// J3: Cell phone messaging 
        /// 
        /// Find the time it takes a type a message on a cell phone using number keys which 
        /// have been assigned letters. Typing 1 letter will take 1 second. When there are 
        /// consecutive letters, then a 2 second pause is required. 
        /// 
        /// Key map: 
        ///1 =
        ///2 = abc
        ///3 = def
        ///4 = ghi
        ///5 = jkl
        ///6 = mno
        ///7 = pqrs
        ///8 = tuv
        ///9 = wxyz
        ///0 = -
        /// 
        /// The logic: 
        /// 1: Group the letters that take the same amount of time to type. 
        /// There are either 3 or 4 letter characters assigned to one number key.
        /// Since it takes 1 second to press a key for a letter, we need to identify what 
        /// keys take 1 second, 2 seconds, 3 seconds or 4 seconds to type.
        /// 
        /// The keys that take 1 second to type: “adgjmptw”.
        /// The keys that take 2 seconds to type: “behknqux” 
        /// The keys that take 3 seconds to type: “cfilorvy”
        /// There are two keys that will take 4 seconds to type: “sz”
        /// 
        /// 2. Set conditions for 2 second pause 
        /// If consecutive letters are pressed that are assigned to the same number key, 
        /// then there needs to be a pause between letters. For example, for the word, “www”, 
        /// it would be 9-pause-9-pause-9-pause.A pause is 2 seconds. The total time to type "www" 
        /// is 9 seconds.
        /// 
        /// 
        /// <param name= "word">message input </param>
        /// <param name= "time">time it takes to type a message in seconds </param>
        /// 
        /// <example>api/J3/MobileMessage/dada -> 4 seconds </example>
        /// <example>api/J3/MobileMessage/bob  -> 7 seconds </example>
        /// 
        /// 
        /// 
        ///  
        /// source:  https://cemc.uwaterloo.ca/contests/computing/2006/stage1/juniorEn.pdf
        /// </summary>




        ///*********
        [HttpGet]
        [Route("api/J3/MobileMessage/{word}")]
        public string MobileMessage(string word)

        {
           string message = "";
           int time = 0;
            
            

            for(int i = 1; i <= word.Length; i++)
            {
                
                time = time + 1; 
            }
                        
          

            
            message = "Time is " + time + " seconds";
            return message;

        }

    }

}
                

            

        
        
