namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Perry", "Cox", 45);
            teacher.DescribeYourself();

            Student student = new Student("John", "Dorian", 29);
            student.DescribeYourself();
        }
    }
}