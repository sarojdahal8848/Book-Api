using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_crud.Interfaces;

namespace simple_crud.Repository
{
    public class LocalImageStorageRepository : IImageStorageRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LocalImageStorageRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
       public async Task<string> SaveImage(IFormFile file)
        {
            var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
            if(!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

            var filePath = Path.Combine(uploadFolder, uniqueFileName);

            using(var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            var request = _httpContextAccessor.HttpContext.Request;

            var url = $"{request.Scheme}://{request.Host}";

            var fullPath = $"{url}/uploads/{uniqueFileName}";

            return fullPath;
        }
    }
}