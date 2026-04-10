using System.ComponentModel.DataAnnotations;
namespace PMT_BTCodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [Required]
        public string GradeName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
