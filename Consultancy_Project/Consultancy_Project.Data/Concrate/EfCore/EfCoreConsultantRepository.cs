using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Data.Concrate.EfCore.Context;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore
{
    public class EfCoreConsultantRepository : EfCoreGenericRepository<Consultant>, IConsultantRepository
    {
        public EfCoreConsultantRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public async Task<Consultant> GetConsultantFullDataByIdAsync(int id)
        {
            var result = await AppContext
                        .Consultants
                        .Where(c=>c.Id == id)
                        .Include(c => c.Certificates)
                        .Include(c => c.Educations)
                        .Include(c => c.ConsultantsSpecializations)
                        .ThenInclude(cs => cs.Specialization)
                        .FirstOrDefaultAsync();
            return result;
        }
    }
}
