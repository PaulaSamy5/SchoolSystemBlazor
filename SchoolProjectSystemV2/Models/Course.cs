namespace SchoolProjectSystemV2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public HashSet<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public HashSet<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
