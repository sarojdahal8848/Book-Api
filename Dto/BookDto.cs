using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}