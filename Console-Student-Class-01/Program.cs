namespace Console_Student_Class_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.CourseID = 1;
            course.CourseName = "Mathematics";
            course.CourseCode = "MATH101";
            course.CourseCredit = 3;

            Course course1 = new Course();
            course1.CourseID = 2;
            course1.CourseName = "Physics";
            course1.CourseCode = "PHYS101";
            course1.CourseCredit = 4;

            Course course2 = new Course();
            course2.CourseID = 3;
            course2.CourseName = "Chemistry";
            course2.CourseCode = "CHEM101";
            course2.CourseCredit = 3;

            List<Course> courseList = new List<Course>();
            List<Student> studentList = new List<Student>();

            Console.WriteLine("Course count: " + (courseList.Count() > 0 ? courseList.Count() : "0"));
            // Console.WriteLine($"Course count: {courseList?.Count ?? 0}");
            Console.ReadLine();
        }
    }
}
