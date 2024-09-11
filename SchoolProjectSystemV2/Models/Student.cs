using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SchoolProjectSystemV2.Models
{
    public class Student
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        [Required]
		public string NationalID {get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName {  get; set; }
		[Required]
		[MaxLength(30)]
		public string MiddleName {  get; set; }
		[Required]
		[MaxLength(30)]
		public string LastName {  get; set; }
		[Required]
		public DateTime BirthDate { get; set; } = DateTime.Now;
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [MaxLength(11)]
        public string PhoneNumber {  get; set; }
        public string Emaill {  get; set; }
        public HashSet<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
        public int CalcAge()
        {
            DateTime now = DateTime.Now;
            this.Age = now.Year - BirthDate.Year;

            // If the birthday hasn't occurred yet this year, subtract one from the age.
            if (now < BirthDate.AddYears(this.Age))
            {
                this.Age--;
            }
            return this.Age;
        }
    }
}
