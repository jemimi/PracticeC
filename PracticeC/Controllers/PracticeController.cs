using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Web.Http;

namespace PracticeC.Controllers
{
    public class PracticeController : ApiController
    {/// <summary>
     /// Halves the input number
     /// <example>ET api/practice/GetHalfDown/11 --> 5</example>
     /// </summary>
     /// <param name="id">The Input Number</param>
     /// <returns>Half of the input(rounded down)</returns>
     ///  
        public int GetHalfDown(int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Floor(quotient);
            return (int)(quotient);
        }

        /// <summary>
        /// Calculates the product of 2 integers
        /// </summary>
        /// <param name="factor1">First integer factor</param>
        /// <param name="factor2">Second integer factor</param>
        /// <example>eg. GET api/practice/product/30/2 -> 60</example>
        ///  <example>eg. GET api/practice/product/10/2 -> 10</example>
        /// <returns>Product of the those 2 integer factors</returns>
        /// 
        [Route("api/practice/product/{factor1}/{factor2}")]
        public int GetProduct(int factor1, int factor2)
        {
            return factor1*factor2;
        }

        /// <summary>
        /// Finds the number of characters in a string
        /// </summary>
        /// <param name="message">The input string</param>
        /// <returns>The number of characters din the input string</returns>
        [Route("api/practice/strlen/{message}")]
        public int GetStrLen(string message)
        {
            return message.Length;
        }

        /// <summary>
        /// Finds hypotenuse of the right-angled triangle
        /// </summary>
        /// <param name="sideA">The length of sideA</param>
        ///  <param name="sideB">The length of sideB</param>
        /// <returns>Finds hypotenuse of the triangle</returns>
        /// 
        [HttpGet]
        [Route("api/practice/Pythagorean/{sideA}/{sideB}")]
        public double Pythagorean(double sideA, double sideB)
        {
            //Must have positive number for our actual triangle sides
            if (sideA > 0 && sideB > 0)
            {
                double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
                return hypotenuse;
            }
            else
            { 
                // Not a valid triangle
                return 0;
            }
           
        }
        /// <summary>
        /// practice for loop  
        /// </summary>
        /// <param name="temperature">temperature input in degrees </param>
        ///  <example>api/practice/season/21 -> The season is summer!</example>
        ///  <example>api/practice/season/17 -> The season is fall!</example>
        ///  <example>api/practice/season/10 -> The season is spring!</example>
        /// <returns> season with the temperature</returns>

        [HttpGet]
        [Route("api/practice/season/{temperature}")]
        public string Season(int temperature)
        {
            string season ; 

            if (temperature > 20)
            {
                season = "Summer";
            }
            else if (temperature > 15 && temperature < 20)
            {

                season = "Fall";
            }
            else if (temperature > 10 && temperature < 15)
            {

                season = "Spring";
            }
            else 
            {
                season = "Winter";
             }
            string message = "The season is " + season + "!"; //string concatenation
            return message; 

        }

        

        }
    }

