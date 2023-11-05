using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string BookUrl { get; set; }
        public string ISBNNUMBER { get; set; }
        //public DateTime CreatedTime { get; set; } = DateTime.Now();
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile BookFile { get; set; }
        public int BookWriterId { get; set; }
        public BookWriter BookWriter { get; set; }
        public int BookCoverId { get; set; }
        public BookCover BookCover { get; set; }
    }
}
