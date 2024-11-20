using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the subject name
            Console.WriteLine("Enter the subject name:");
            string subjectName = Console.ReadLine();

            // Ask user for the total marks and marks obtained
            Console.WriteLine("Enter the total marks:");
            double totalMarks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks you obtained:");
            double obtainedMarks = Convert.ToDouble(Console.ReadLine());

            // Calculate the percentage
            double percentage = (obtainedMarks / totalMarks) * 100;

            // Declare a variable to store the grade
            string grade;

            // Determine the grade based on the percentage
            if (percentage >= 90)
            {
                grade = "A";
            }
            else if (percentage >= 80)
            {
                grade = "B";
            }
            else if (percentage >= 70)
            {
                grade = "C";
            }
            else if (percentage >= 60)
            {
                grade = "D";
            }
            else if (percentage >= 40)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }

            // Display the result
            Console.WriteLine("You got Grade {0}.", grade);
        }
    }
}
