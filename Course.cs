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
        private Teacher Instructor { get; set; }
        private int Duration { get; set; }

        private List<Student> Students { get; set; }

        public Course(string name, Teacher instructor, int duration, List<Student> students)
        {
            CourseName = name;
            Instructor = instructor;
            Duration = duration;
            Students = students;

            instructor.AddCourse(this);
            foreach(Student student in students)
            {
                student.AddCourse(this);
            }
        }

        public Course(string name, Teacher instructor, int duration) : this(name, instructor, duration, new List<Student>())
        { }

        public Course(string name, Teacher instructor) : this(name, instructor, 100)
        { }

        public Course(string name) : this(name, new Teacher())
        { }

        public Course() : this("Unknown course")
        { }

        public void Print()
        {
            Console.WriteLine($"Course: {CourseName}, your instructor is {Instructor.GetName()}, the duration is {Duration} hours, there are {Students.Count} students attending");
        }

        public List<Student> EnrollStudent(Student person)
        {
            Students.Add(person);
            person.AddCourse(this);
            return Students;
        }

        public override string ToString()
        {
            string studentData = Students.Aggregate("", (a, c) => a.Length > 0 ? $"{a}, {c.GetName()}" : c.GetName());
            return $"{CourseName} course; instructor: {Instructor.GetName()}; duration: {Duration}; students: {studentData}; students total: {Students.Count}.";
        }

    }
}
