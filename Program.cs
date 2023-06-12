namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Perry", "Cox", 45);
            teacher.DescribeYourself();

            Course course = new Course("Math", "Walter Gilman");

            Student student = new Student("John", "Dorian", 29);
            student.AddCourse(course);
            student.Print();

            teacher.AddStudent(student);
            Console.WriteLine(teacher.GetNumberOfStudents());
            teacher.RemoveStudent(student);
            Console.WriteLine(teacher.GetNumberOfStudents());
        }
    }
}