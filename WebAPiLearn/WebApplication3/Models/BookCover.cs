﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class BookCover
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
