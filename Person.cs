using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Person
    {
        public string Type { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string City { get; set; }
        protected int Age { get; set; }
        protected List<Course> Courses { get; set; } = new List<Course>();

        public Person(string firstName, string lastName, int age, string city, string type)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
            Type = type;
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

        public string GetName() => $"{FirstName} {LastName}";

        public List<Course> GetMyCourses () => Courses;

        public override string ToString()
        {
            string courseData = Courses.Aggregate("", (a, c) => a.Length > 0 ? $"{a}, {c.CourseName}" : c.CourseName);
            return $"{Type} {this.GetName()}; my courses are {courseData}";
        }
    }
}
