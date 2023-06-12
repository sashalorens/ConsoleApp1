using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Course
    {
        public string CourseName { get; set; }
        private string InstructorName { get; set; }
        private int Duration { get; set; }
        private int NumberOfStudents { get; set; }

        private List<Student> Students;

        public Course(string name, string instructorName, int duration, int numberOfStudents, List<Student> students)
        {
            CourseName = name;
            InstructorName = instructorName;
            Duration = duration;
            NumberOfStudents = numberOfStudents;
            Students = students;
        }

        public Course(string name, string instructorName, int duration, int numberOfStudents) : this(name, instructorName, duration, numberOfStudents, new List<Student>())
        { }

        public Course(string name, string instructorName, int duration) : this(name, instructorName, duration, 0)
        { }

        public Course(string name, string instructorName) : this(name, instructorName, 100)
        { }

        public Course(string name) : this(name, "Unknown instructor")
        { }

        public Course() : this("Unknown course")
        { }

        public void Print()
        {
            Console.WriteLine($"Course: {CourseName}, your instructor is {InstructorName}, the duration is {Duration} hours, there are {NumberOfStudents} students attending");
        }

        public List<Student> EnrollStudent(Student person)
        {
            if (!Students.Contains(person))
            {
                Students.Add(person);
                NumberOfStudents++;
            }
            return Students;
        }

        public bool RemoveStudent(Student student) => Students.Remove(student);

        public int GetNumberOfStudents() => Students.Count;

    }
}
