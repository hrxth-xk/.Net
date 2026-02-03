using System.ComponentModel.DataAnnotations;

namespace bookprbprac.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }  
        [Required]
        public string Genre { get; set; }
        [Required]
        [Range(0,10)]
        public int AvailableCopies { get; set; }
    }
}