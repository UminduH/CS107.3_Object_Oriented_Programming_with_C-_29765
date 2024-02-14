using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            public string CourseName
            {
                get { return courseName; }
            }

            public double Grade
            {
                get { return grade; }
            }

            public void SetInstructorName(string nameOfInstructor)
            {
                if (string.IsNullOrEmpty(nameOfInstructor))
                {
                    throw new ArgumentException("Instructor name cannot be empty !");
                }

                instructorName = nameOfInstructor;
            }

            private string CalculateLetterGrade()
            {
                if (grade >= 75)
                {
                    return "A";
                }
                else if (grade >= 60)
                {
                    return "B";
                }
                else if (grade >= 50)
                {
                    return "C";
                }
                else if (grade >= 40)
                {
                    return "D";
                }    
                else
                {
                    return "F";
                }    
            }

            public void PrintCourseInfo()
            {
                Console.WriteLine($"\nCourse Name: {courseName}");
                Console.WriteLine($"Instructor Name: {instructorName}");
                Console.WriteLine($"Grade: {CalculateLetterGrade()}");
            }

            public Course(string courseName, string instructorName, double grade)
            {
                if (string.IsNullOrEmpty(courseName))
                {
                    throw new ArgumentException("Course name cannot be empty !");
                }

                this.courseName = courseName;

                SetInstructorName(instructorName);

                if (grade < 0 || grade > 100)
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 0 and 100 !");
                }

                this.grade = grade;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Course Name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("\nEnter Instructor Name: ");
            string instructorName = Console.ReadLine();

            Console.WriteLine("\nEnter Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            Course myCourse = new Course(courseName, instructorName, marks);
            myCourse.PrintCourseInfo();

            Console.ReadLine();
        }
    }
}
