using System.ComponentModel.DataAnnotations;

namespace OnlineSchool.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string VideoUrl { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int OrderNumber { get; set; }
    }
}
