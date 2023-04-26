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

        public SpecializationManager(ISpecializationRepository specializationRepository)
        {
            _specializationRepository = specializationRepository;
        }

        public Task CreateAsync(Specialization specialization)
        {
            throw new NotImplementedException();
        }

        public void Delete(Specialization specialization)
        {
            throw new NotImplementedException();
        }

        public void EditSpecializationsConsultantAsync(int[] IdsToAddSpecialization, int[] IdsToRemoveSpecialization, int ConsultantId)
        {
             _specializationRepository.EditSpecializationsConsultantAsync(IdsToAddSpecialization, IdsToRemoveSpecialization, ConsultantId);
        }

        public async Task<List<Specialization>> GetAllAsync()
        {
            return await _specializationRepository.GetAllAsync();
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
