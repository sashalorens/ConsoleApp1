using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Student: Person
    {
        private Course[] CoursesAttended { get; set; }

        private int CourseCounter = 0;


        
        public Student(string firstName, string lastName, int age, string city, Course[] coursesAttended)
            : base(firstName, lastName, age, city)
        {
            CoursesAttended = coursesAttended;
        }

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
            if (CourseCounter > 0)
            {
                Console.WriteLine("Courses attended:");
                foreach (Course course in CoursesAttended)
                {
                    if (!(course?.CourseName != null))
                    {
                        continue;
                    }
                    Console.WriteLine(course.CourseName);
                }
            }
        }

        public Course[] Enroll(Course course)
        {
            string name = course.CourseName;
            try
            {
                CoursesAttended[CourseCounter] = course;
                CourseCounter += 1;
                Console.WriteLine($"You've successfully enrolled in a new {name} course!");
            } catch (Exception)
            {
                Console.WriteLine($"Sorry, you can't enroll in {name} course, as you can attend 10 courses at max");
            }
            return CoursesAttended;
        }

        public Course[] Drop(string course)
        {
            Course[] array = new Course[10];
            int lastIndex = 0;

            foreach(Course item in CoursesAttended)
            {
                if (item?.CourseName != null && item.CourseName != course)
                {
                    array[lastIndex] = item;
                    lastIndex++;
                }
            }
            CoursesAttended = array;
            return CoursesAttended;
        }
    }
}
