using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Concrate
{
    public class ConsultantManager : IConsultantService
    {
        private readonly IConsultantRepository _consultantRepository;

        public ConsultantManager(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;
        }

        public Task CreateAsync(Consultant consultant)
        {
            throw new NotImplementedException();
        }

        public void Delete(Consultant consultant)
        {
            _consultantRepository.Delete(consultant);
        }

        public void DeleteUser(User user)
        {
           _consultantRepository.DeleteUser(user);
        }

        public Task<List<Consultant>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Consultant> GetByIdAsync(int id)
        {
            return await _consultantRepository.GetByIdAsync(id);
        }

        public async Task<Consultant> GetConsultantFullDataByIdAsync(int id)
        {
            return await _consultantRepository.GetConsultantFullDataByIdAsync(id);
        }

        public void Update(Consultant consultant)
        {
            throw new NotImplementedException();
        }

        public void UpdateConsultantData(Consultant consultant)
        {
            _consultantRepository.UpdateConsultantData(consultant);
        }
    }
}
