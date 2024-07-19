using System;

namespace princiAbiertoCerrado
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            OnlineCourse onlineCourse = new OnlineCourse { CourseId = 706, Title = "ITLA1" };
            OnsiteCourse onsiteCourse = new OnsiteCourse { CourseId = 365, Title = "ITLA2" };

            HybridCourse hybridCourse = new HybridCourse(onlineCourse, onsiteCourse);

            Student student = new Student
            {
                firstName = "Paula",
                lastName = "Henrsez"
            };

            hybridCourse.Subscribe(student);
        }
    }

}
