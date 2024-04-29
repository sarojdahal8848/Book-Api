using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using simple_crud.Helper;
using simple_crud.Interfaces;

namespace simple_crud.Repository
{
    public class AzureImageStorageRepository : IImageStorageRepository
    {
        private readonly BlobServiceClient _blobServiceClient;
        public AzureImageStorageRepository(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }
        public async Task<string> SaveImage(IFormFile file)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient("uploads");
            await containerClient.CreateIfNotExistsAsync();

            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var blobClient = containerClient.GetBlobClient(uniqueFileName);

            var contentType = ContentTypeHelper.GetContentType(file.FileName);
            var blobHttpHeader = new BlobHttpHeaders {ContentType = contentType};

            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, blobHttpHeader);
            }

            return blobClient.Uri.ToString();

        }
    }
}