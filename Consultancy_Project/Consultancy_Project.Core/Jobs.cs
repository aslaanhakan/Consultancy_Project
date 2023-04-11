using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Core
{
    public class Jobs
    {
        public static string UploadImage(IFormFile image)
        {
            var extension = Path.GetExtension(image.FileName);
            var randomName = $"{Guid.NewGuid()}{extension}";
            //Şimdi de resmi sunucuya yüklüyoruz
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                image.CopyTo(stream);
            }

            return randomName;
        }
    }
}
