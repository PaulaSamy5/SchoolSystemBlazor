using Microsoft.EntityFrameworkCore;
using SchoolProjectSystemV2.Models;

namespace SchoolProjectSystemV2.DBContext
{
    public class SchoolSystemDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=School; Trusted_Connection=true; Encrypt=false;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.CourseId, SC.StudentId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
    }
}
