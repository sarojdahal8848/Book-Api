using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public string ImagePath { get; set; } = String.Empty;
        [NotMapped]
        public IFormFile? Image { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}