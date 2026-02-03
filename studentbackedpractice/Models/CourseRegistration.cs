using System.ComponentModel.DataAnnotations;

namespace studentbackedpractice.Models
{
    public class CourseRegistration
    {
        [Key]
        public int RegistrationID { get; set; }
        [Required]

        public string Name{get;set;}=" ";
        [Required]
        [Range(1,8)]
        public int Semester{get;set;}
        [Required]
        [Range(1,30)]
        public int Credits{get;set;}
    }

}