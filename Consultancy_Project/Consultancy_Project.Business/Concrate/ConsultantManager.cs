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
            throw new NotImplementedException();
        }

        public Task<List<Consultant>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Consultant> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Consultant> GetConsultantFullDataByIdAsync(int id)
        {
           return await _consultantRepository.GetConsultantFullDataByIdAsync(id);
        }

        public void Update(Consultant consultant)
        {
            throw new NotImplementedException();
        }
    }
}
