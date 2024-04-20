using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}