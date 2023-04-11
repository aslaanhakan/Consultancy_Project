using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface ISpecializationService
    {
        Task CreateAsync(Specialization specialization);
        Task<Specialization> GetByIdAsync(int id);
        Task<List<Specialization>> GetAllAsync();
        void Update(Specialization specialization);
        void Delete(Specialization specialization);
    }
}
