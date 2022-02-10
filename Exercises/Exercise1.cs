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
            Console.Write("Type your zipe to know info about your delivery: ");
            int userZipCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Test {userZipCode}");



        }
    }
}
