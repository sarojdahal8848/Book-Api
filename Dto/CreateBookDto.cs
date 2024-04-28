using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Dto
{
    public class CreateBookDto
    {
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public IFormFile? Image { get; set; }
    }
}