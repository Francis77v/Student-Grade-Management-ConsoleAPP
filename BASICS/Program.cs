using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects;
            int subject_count;
            string message;
            List<string> student_grade = new List<string>();

            subjects = new string[] {
                "Mathematics",
                "English",
                "Science",
                "ESP",
                "AP",
                "Filipino",
                "TLE"
            };

            
            subject_count = subjects.Length;

            //Console.WriteLine(subject_count);

            message = "Enter grade for ";
            

            //insert data

            for (int i = 0; i < subject_count; i++)
            {
                
                Console.Write(message + subjects[i] + ": ");
                string grade = Console.ReadLine();
                //double result = double.Parse(grade);

                student_grade.Add(grade);



            }
            // array for grades instead of variable because each loop it will reassign another value and cant take previous value

            foreach (string grade in student_grade)
            {
                Console.WriteLine(grade);
            }

            //next would be ask for student name, compute average, validation, submit to csv or json, turn it into associative array,and apply oop
        }
    }
}
