using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud.Helper
{
    public static class ContentTypeHelper
    {
        public static string GetContentType(string fileName)
        {
            switch(Path.GetExtension(fileName).ToLower())
            {
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".gif":
                    return "application/gif";
                default:
                    return "application/octet-stream";
            }
        }
    }
}