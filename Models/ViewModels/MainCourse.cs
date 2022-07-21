using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFood.Models.ViewModels
{
    public class MainCourse

    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Main course")]
        [StringLength(60, ErrorMessage = "the maximum number of characters must not exceed 40 characters")]
        public string MainCourseName { get; set; } //text

        
        [DisplayName("Rating")]
        [Range(0, 5)]
        public int EvaluationRating { get; set; } //number

        [Required]
        [DisplayName("Time to prepare (min)")]
        [Range(0, 500, ErrorMessage = "the maximum number of characters must not exceed 500 characters")]
        public int TimeToPrepare { get; set; } //number

        [Required]
        [DisplayName("Execution level")]
        [StringLength(10)]
        public string ExecutionLevel { get; set; }  //select

        [Required]
        [DisplayName("Ingredients")]
        [StringLength(1000, ErrorMessage = "the maximum number of characters must not exceed 1000 characters")] 
        public string Ingredients { get; set; }  //text

        [DisplayName("Method of execution")]
        [StringLength(1000, ErrorMessage = "the maximum number of characters must not exceed 1000 characters")]
        public string MethodOfExecution { get; set; }

        [ForeignKey("UserId")]
        [StringLength(100)]
        public string UserId { get; set; }
    }
}
