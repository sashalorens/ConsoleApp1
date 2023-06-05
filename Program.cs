namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "Doe", 29);
            Course mathCourse = new Course("Math", "Walter Gilman");
            Course astronomyCourse = new Course("Astronomy");

            student.Print();
            student.Enroll(mathCourse);
            student.Enroll(astronomyCourse);
            student.Print();
            student.Drop("Astronomy");
            student.Print();
            Console.WriteLine("\n");

            mathCourse.Print();
            mathCourse.EnrollStudent(student);
            mathCourse.Print();
        }
    }
}