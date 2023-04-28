using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface IEducationService
    {
        Task CreateAsync(Education education);
        Task<Education> GetByIdAsync(int id);
        Task<List<Education>> GetAllAsync();
        void Update(Education education);
        void Delete(Education education);
    }
}
