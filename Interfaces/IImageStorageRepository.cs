using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Interfaces
{
    public interface IImageStorageRepository
    {
        public Task<string> SaveImage(IFormFile file);
    }
}