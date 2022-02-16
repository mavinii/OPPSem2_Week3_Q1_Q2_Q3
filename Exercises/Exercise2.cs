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
            
            String[] studentsName = new string[answer]; //Adding the user input in an array
            
            //Asking students name
            for (int i = 0; i < studentsName.Length; i++)
            {
                Console.Write($"Name of the {i} student: ");
                studentsName[i] = Console.ReadLine();
            }
            foreach (string name in studentsName)
            {
                Console.WriteLine("Students name: " + name);
            }

            Console.WriteLine("\n");
            
            //Asking students score
            double[] scores = new double[answer];
            for (int i = 0; i < studentsName.Length; i++)
            {
                Console.Write($"Score of the {i} student: ");
                scores[i] = Convert.ToDouble(Console.ReadLine());
            }
            foreach (double score in scores)
            {
                Console.WriteLine("Students score: " + score);
            }
        }
    }
}
