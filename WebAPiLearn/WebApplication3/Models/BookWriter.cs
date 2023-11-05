using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class BookWriter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gended { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile MyProperty { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<BookCover> BookCovers { get; set; }
    }
}
