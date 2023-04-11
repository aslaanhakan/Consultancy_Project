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
    public class SpecializationManager : ISpecializationService
    {
        private readonly ISpecializationRepository _specializationRepository;
        public Task CreateAsync(Specialization specialization)
        {
            throw new NotImplementedException();
        }

        public void Delete(Specialization specialization)
        {
            throw new NotImplementedException();
        }

        public Task<List<Specialization>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Specialization> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Specialization specialization)
        {
            throw new NotImplementedException();
        }
    }
}
