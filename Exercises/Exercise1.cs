using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 22931 - Marcos Oliveira

//Write a program for a package delivery service. The program contains an array that holds the 
//ten zip codes to which the company delivers packages. Prompt a user to enter a zip code and 
//display a message indicating whether the zip code is one to which the company delivers.

namespace OPP_Sem2_Week3_Q1_Q2_Q3.Exercises
{
    public class Exercise1
    {
        public void deliveryService()
        {
            Console.Write("Check your zip code, example (A0): ");
            String userZipCode = Console.ReadLine();

            // Validator
            bool c = false;

            // Array which stores the Zip Codes
            string[,] zipCodeCompany =  {
                { "A1", "A2", "A3", "A4", "A5" }, 
                { "B6", "B7", "B8", "B9", "B10" }
             };

            // Foreach for running the array
            foreach (String temp in zipCodeCompany)
            {
                c = userZipCode.Equals(temp);
                if (c)
                    break;
            }

            if (c)
            {
                Console.WriteLine($"Yes, {userZipCode} is valid to delivey.");
            }
            else
            {
                Console.WriteLine($"Sorry, {userZipCode} is not valid for delivery yet.\n");
            }
        }
    }
}
