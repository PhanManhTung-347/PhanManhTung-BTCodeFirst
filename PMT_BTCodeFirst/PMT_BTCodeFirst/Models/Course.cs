using System.ComponentModel.DataAnnotations;

namespace PMT_BTCodeFirst.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
