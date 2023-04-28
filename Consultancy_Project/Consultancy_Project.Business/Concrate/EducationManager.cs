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
    public class EducationManager : IEducationService
    {
        private readonly IEducationRepository _educationRepository;

        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
        }

        public async Task CreateAsync(Education education)
        {
            await _educationRepository.CreateAsync(education);
        }

        public void Delete(Education education)
        {
            _educationRepository.Delete(education);
        }

        public Task<List<Education>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Education> GetByIdAsync(int id)
        {
            return await _educationRepository.GetByIdAsync(id);
        }

        public void Update(Education education)
        {
            throw new NotImplementedException();
        }
    }
}
