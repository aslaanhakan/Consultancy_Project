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
                        .OrderBy(x=>x.DayOfYear)
                        .ToListAsync();
            return result;

        }

        public async void CreateAvailableOfDate(int consultantId, int[] selectedHours, DateOnly date)
        {
            List<Available> availables = new List<Available>();
            if (selectedHours!=null)
            {
                foreach (var hour in selectedHours)
                {
                    availables.Add(new Available
                    {
                        ConsultantId = consultantId,
                        WorkingHoursId = hour,
                        Date = date,
                        CreatedTime = DateTime.Now,
                        UpdatedTime = DateTime.Now,
                    });

                }
                await AppContext.Availables.AddRangeAsync(availables);
                await AppContext.SaveChangesAsync();
            }

        }
    }
}
