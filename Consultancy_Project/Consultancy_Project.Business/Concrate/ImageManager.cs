using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Concrate
{
    public class ImageManager : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageManager(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task CreateAsync(Image image)
        {
            await _imageRepository.CreateAsync(image);

        }

        public void Delete(Image image)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Image> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
