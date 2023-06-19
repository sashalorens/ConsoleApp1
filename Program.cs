namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // setting up data
            Teacher teacher1 = new Teacher("Perry", "Cox", 45);
            Teacher teacher2 = new Teacher("Robert", "Kelso", 69);
            Teacher teacher3 = new Teacher("Carla", "Espinosa", 31, "NY");

            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2, teacher3 };

            Student student1 = new Student("John", "Dorian", 30, "NY");
            Student student2 = new Student("Elliot", "Reid", 30, "Connecticut");
            Student student3 = new Student("Christopher", "Turk", 31, "NY");
            Student student4 = new Student("Todd", "Quinlan", 31, "Texas");

            List<Student> students = new List<Student> { student1, student2, student3, student4 };

            Course course1 = new Course("Math", teacher1, 90, students);
            Course course2 = new Course("Astronomy", teacher2, 55, students.GetRange(1, 2));
            Course course3 = new Course("World History", teacher3, 85, students.GetRange(1, 3));
            Course course4 = new Course("Physics", teacher2, 100, students);

            List<Course> courses = new List<Course> { course1, course2, course3, course4 };

            // processing data

            var courseData = courses.OrderBy((x) => x.CourseName).Select((item) => item.ToString());
            Console.WriteLine("Courses:");
            DisplayData(courseData);

            var teacherData = teachers.OrderBy((x) => x.GetName()).Select((item) => item.ToString());
            Console.WriteLine("Teachers:");
            DisplayData(teacherData);

            var studentData = students.OrderBy((x) => x.GetName()).Select((item) => item.ToString());
            Console.WriteLine("Students:");
            DisplayData(studentData);
        }

        public static void DisplayData(IEnumerable<string> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}