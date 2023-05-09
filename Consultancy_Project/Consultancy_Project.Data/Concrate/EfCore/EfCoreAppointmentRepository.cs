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
    public class EfCoreAppointmentRepository : EfCoreGenericRepository<Appointment>, IAppointmentRepository
    {
        public EfCoreAppointmentRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public async Task<List<Appointment>> GetAllFullDataAsync()
        {
            return await AppContext.Appointments
                    .Include(x => x.Consultant)
                    .ThenInclude(x=>x.User)
                    .Include(x => x.Customer)
                    .ThenInclude(x=>x.User)
                    .ToListAsync();
        }
    }
}
