using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Abstract
{
    public interface IAvailableRepository : IGenericRepository<Available>
    {
        Task<List<DateOnly>> GetAvailablesGroupByDateAsync(int id);
        Task<List<WorkingHours>> GetAllWorkingHours();
    }
}
