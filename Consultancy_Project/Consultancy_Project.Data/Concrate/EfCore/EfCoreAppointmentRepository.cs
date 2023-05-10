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

        public async Task<List<Appointment>> GetAllDataByConsultantIdAsync(int consultantId)
        {
            return await AppContext
                        .Appointments
                        .Include(x => x.Consultant.Id == consultantId)
                        .Include(x => x.Consultant)
                        .ThenInclude(x => x.User)
                        .Include(x => x.Customer)
                        .ThenInclude(x => x.User)
                        .ToListAsync();
        }

        public Task<List<Appointment>> GetAllDataByCustomerIdAsync(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Appointment>> GetAllDataByUserIdAsync(string userId, string userRole)
        {
            var result = AppContext
                            .Appointments
                            .AsQueryable();
            if (userRole == "Consultant")
            {
                result = result.Where(x => x.Consultant.User.Id == userId)
                     .Include(x => x.Consultant)
                         .ThenInclude(x => x.User)
                         .Include(x => x.Customer)
                         .ThenInclude(x => x.User);
                        
            }
            else
            {
                result = result.Where(x => x.Customer.User.Id == userId)
                    .Include(x => x.Consultant)
                        .ThenInclude(x => x.User)
                        .Include(x => x.Customer)
                        .ThenInclude(x => x.User);
            }
            return await result.ToListAsync();



        }

        public async Task<List<Appointment>> GetAllFullDataAsync()
        {
            return await AppContext.Appointments
                    .Include(x => x.Consultant)
                    .ThenInclude(x => x.User)
                    .Include(x => x.Customer)
                    .ThenInclude(x => x.User)
                    .ToListAsync();
        }
    }
}
