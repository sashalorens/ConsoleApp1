using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teacher: Person
    {
        protected List<Student> Students { get; set; } = new List<Student>();
        public Teacher(string firstName, string lastName, int age, string city)
            : base(firstName, lastName, age, city)
        {}

        public Teacher(string firstName, string lastName, int age) : this(firstName, lastName, age, "Unknown city") { }

        public Teacher(string firstName, string lastName) : this(firstName, lastName, 18) { }

        public Teacher(string firstName) : this(firstName, "Unknown") { }

        public Teacher() : this("Unknown") { }

        public override void DescribeYourself()
        {
            base.DescribeYourself();
            Console.WriteLine("I'm a teacher");
        }

        public List<Student> AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }

            return Students;
        }

        public bool RemoveStudent(Student student) => Students.Remove(student);

        public int GetNumberOfStudents() => Students.Count;
    }
}
