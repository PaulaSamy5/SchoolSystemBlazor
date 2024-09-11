using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProjectSystemV2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public double Salary { get; set; }
        [ForeignKey("Course")]
        public int Courseid {  get; set; }
        public Course Course { get; set; }
    }
}
