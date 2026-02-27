namespace Console_Student_Class_01
{
    internal class Program
    {

        public static Student RegisterStudents()
        {

            Console.WriteLine("Enter student Id:");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter student surname:");
            string studentSurname = Console.ReadLine();

            Console.WriteLine("Enter student email:");
            string studentEmail = Console.ReadLine();

            Student student = new Student();

            student.StudentID = studentId;
            student.StudentName = studentName;
            student.StudentSurname = studentSurname;
            student.StudentEmail = studentEmail;

            return student;

        }
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

            courseList.Add(course);
            courseList.Add(course1);
            courseList.Add(course2);

            Console.WriteLine("Course count: " + (courseList.Count() > 0 ? courseList.Count() : "0"));
            // Console.WriteLine($"Course count: {courseList?.Count ?? 0}");

            //foreach (var item in courseList)
            //{
            //    Console.WriteLine($"Course ID = {item.CourseID} Course Name = {item.CourseName} Course Code = {item.CourseCode} Course Credit = {item.CourseCredit}");
            //}

            //Student student = RegisterStudents();

            //studentList.Add(student);

            //student = RegisterStudents();

            //studentList.Add(student);

            //foreach (var item in studentList)
            //{
            //    Console.WriteLine($"Student ID = {item.StudentID} Student Name = {item.StudentName} Student Surname = {item.StudentSurname} Student Email = {item.StudentEmail}");
            //}

            Student student = RegisterStudents();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Student Registration System");
                Console.WriteLine("1 - Do you want to add a new student");
                Console.WriteLine("2 - Lists students");
                Console.WriteLine("3 - Exit");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    student = RegisterStudents();
                    studentList.Add(student);
                } else if (answer == "2")
                {
                    Console.WriteLine("Student List");
                    foreach (var item in studentList)
                    {
                        Console.WriteLine($"Student ID = {item.StudentID} Student Name = {item.StudentName} Student Surname = {item.StudentSurname} Student Email = {item.StudentEmail}");
                    }
                }
                else if (answer == "3")
                {
                    exit = true;
                }
                else                 {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }

            Console.ReadLine();
        }
    }
}
