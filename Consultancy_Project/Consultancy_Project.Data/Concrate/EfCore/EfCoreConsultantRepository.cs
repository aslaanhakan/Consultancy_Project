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

        public async Task<List<Consultant>> GetConsultantsFullDataAsync()
        {
            var result = await AppContext
                        .Consultants
                        .Include(c => c.Certificates)
                        .Include(c => c.Educations)
                        .Include(c => c.ConsultantsSpecializations)
                        .ThenInclude(cs => cs.Specialization)
                        .Include(c => c.User)
                        .ThenInclude(x=>x.Image)
                        .ToListAsync();
            return result;
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
                        .Include(c=>c.User)
                        .ThenInclude(c=>c.Image)
                        .Include(c=>c.Availables)
                        .ThenInclude(a=>a.WorkingHours)
                        .FirstOrDefaultAsync();
            return result;
        }

        public async void UpdateConsultantData(Consultant consultant)
        {
            var consultantData = await AppContext.Consultants
                                        .Where(x => x.Id == consultant.Id)
                                        .FirstOrDefaultAsync();
            consultantData.VisitsPrice = consultant.VisitsPrice;
            consultantData.JobTitle=consultant.JobTitle;
            consultantData.Promotion=consultant.Promotion;
            await AppContext.SaveChangesAsync();
            
            

        }

        public async Task<Consultant> GetConsultantAvailablesByUserIdAsync(string userId)
        {
            return await AppContext 
                        .Consultants
                        .Where(x=>x.UserId== userId)
                        .Include(x=>x.Availables)
                        .FirstOrDefaultAsync();
        }
    }
}
