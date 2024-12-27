using System.ComponentModel.DataAnnotations;

namespace OnlineSchool.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string Duration { get; set; }

        public string Level { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public List<Lesson> Lessons { get; set; }
    }
}
