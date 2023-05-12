using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface IAvailableService
    {
        Task CreateAsync(Available available);
        Task<Available> GetByIdAsync(int id);
        Task<List<Available>> GetAllAsync();
        void Update(Available available);
        void Delete(Available available);
        Task<List<DateOnly>> GetAvailablesGroupByDateAsync(int id);
        Task<List<WorkingHours>> GetAllWorkingHours();
        Task<List<Available>> GetAllAvailablesOfDateAsync(DateOnly date, int id);


    }
}
