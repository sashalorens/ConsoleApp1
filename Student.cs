using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Student: Person
    {
        
        public Student(string firstName, string lastName, int age, string city, Course[] coursesAttended)
            : base(firstName, lastName, age, city)
        { }

        public Student(string firstName, string lastName, int age, string city) : this(firstName, lastName, age, city, new Course[10])
        { }

        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "Unknown city")
        { }

        public Student(string firstName, string lastName) : this(firstName, lastName, 18)
        { }

        public Student(string firstName) : this(firstName, "Unknown")
        { }

        public Student() : this("Unknown")
        { }

        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine("I'm a student");
        }

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}, {Age} y.o., city: {City}");
            if (Courses.Count > 0)
            {
                Console.WriteLine("Courses attended:");
                foreach (Course course in Courses)
                {
                    if (!(course?.CourseName != null))
                    {
                        continue;
                    }
                    Console.WriteLine(course.CourseName);
                }
            }
        }
    }
}
