using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Data.Concrate.EfCore.Context;
using Consultancy_Project.Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore
{
    public class EFCoreAvailableRepository : EfCoreGenericRepository<Available>, IAvailableRepository
    {
        public EFCoreAvailableRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public Task<List<Available>> GetAllAvailablesOfDateAsync(DateOnly date, int id)
        {
            return AppContext
                    .Availables
                    .Where(x => x.Date == date && x.ConsultantId == id)
                    .ToListAsync();

        }

        public async Task<List<WorkingHours>> GetAllWorkingHours()
        {
            return await AppContext.WorkingHours.ToListAsync();
        }

        public async Task<List<DateOnly>> GetAvailablesGroupByDateAsync(int id)
        {
            var result = await AppContext
                        .Availables
                        .Where(a => a.ConsultantId == id)
                        .Select(x => x.Date)
                        .Distinct()
                        .ToListAsync();
            return result;

        }
    }
}
