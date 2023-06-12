using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string City { get; set; }
        protected int Age { get; set; }
        protected List<Course> Courses { get; set; } = new List<Course>();

        public Person(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public virtual void DescribeYourself()
        {
            Console.WriteLine($"I'm {FirstName} {LastName}, from {City}, {Age} y.o.");
        }

        public List<Course> AddCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
            }

            return Courses;
        }

        public bool RemoveCourse(Course course) => Courses.Remove(course);

        public int GetNumberOfCourses() => Courses.Count;
    }
}
