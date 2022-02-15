using System;

namespace Exercise12
{
    class Program
    {
        /*Write a program that allows a teacher to enter in a N-number of students. For each student 
            ask the teacher to enter in their name and final score for the class. When the teacher is done 
            entering the data, print the highest grade in the class, and the average grade for the class.*/
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you wanna register? ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] name = new string[n];
            double[] score = new double[n];
            double soma = 0;
            double highest = Double.MinValue;
            

            for ( int i =0; i < n; i++)
            {
                Console.WriteLine("What is the student name? ");
                name[i] = Console.ReadLine();
                Console.WriteLine("What is the student score? ");
                score[i] = Convert.ToDouble(Console.ReadLine());

            }
            for (int i = 0; i<score.Length; i++)
            {
                Console.WriteLine("The student name is: " + name[i] + " ");
                Console.WriteLine("Score: " + score[i] + " ");
                soma += score[i];
                if (score[i] > highest)
                {
                    highest = score[i];
                }
            }

            Console.WriteLine("The average is " + soma / n);
            Console.WriteLine("The highest grade is {0}", highest);

        }
    }
}
