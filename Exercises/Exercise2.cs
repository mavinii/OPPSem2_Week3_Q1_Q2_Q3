using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 22931 - Marcos Oliveira

//Write a program that allows a teacher to enter in a N-number of students. For each student 
//ask the teacher to enter in their name and final score for the class. When the teacher is done 
//entering the data, print the highest grade in the class, and the average grade for the class.

namespace OPP_Sem2_Week3_Q1_Q2_Q3.Exercises
{
    public class Exercise2
    {
        // This class can be static because there is no get or set 
        public static void ClassMarks()
        {
            Console.Write("Total of students: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            
            String[] studentsName = new string[answer]; // Adding the user input in an array
            double[] scores = new double[answer];       // This arrays saves all the scores
            List<double> Out = new List<double>();      // This list saves all the scores and shows the max and avarege of the array scores 

            // Asking students name
            for (int i = 0; i < studentsName.Length; i++)
            {
                Console.Write($"\nEnter the student name: ");
                studentsName[i] = Console.ReadLine();

                Console.Write("Enter "+ studentsName[i] + "'s score: ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
                Out.Add(scores[i]);
            }

            Console.WriteLine("\n");

            // Showing the student name + they score
            for (int i = 0; i < studentsName.Length; i++) 
            {
                Console.WriteLine("The student " +studentsName[i] + " has: " +scores[i] + ".");
            }

            Console.WriteLine("Highest grade in the class: {0}", Out.Max());
            Console.WriteLine("Average grade of the class: {0}", Out.Average());
        }
    }
}
