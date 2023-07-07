using System.ComponentModel.DataAnnotations;

namespace Co132.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please Enter Course Name")]
        [Display(Name = "Course Name")]
        public string? CourseName { get; set; }
        [Required(ErrorMessage = "Please Enter Course Name")]
        [Display(Name = "Course Description")]
        public string? CourseDescription { get; set; }
        [Required(ErrorMessage = "Please Enter Course Price")]
        [Range(1, 1000, ErrorMessage = "Range between 1 and 1000")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        public string Duration { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Is Published")]
        public bool IsPublished { get; set; }

    }
}
