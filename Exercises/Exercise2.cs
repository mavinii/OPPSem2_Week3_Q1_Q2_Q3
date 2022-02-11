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
            // Enter the name and students' final score
            Console.Write("Enter the numbers of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            int[] val = new int[numberOfStudents];
            
            string[] students = { };
            int[] score = { };
            
            for (int i = 0; i <= val.Length; i++)
            {
                Console.WriteLine($"Total of student: {val.Length}.\n");

                Console.Write($"Enter the {val[i]} student name: ");
                string studentName = Console.ReadLine();

                Console.Write($"Enter the {studentName}'s score: ");
                int studentScore = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nThe student {studentName} has the score {studentScore}.");

                //val[i]++;
                //students[i] += 1;
                //score[i]++;
            }
        }
    }
}
