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
    public class EfCoreSpecializationRepository : EfCoreGenericRepository<Specialization>, ISpecializationRepository
    {
        public EfCoreSpecializationRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public async void EditSpecializationsConsultantAsync(int[] IdsToAddSpecialization, int[] IdsToRemoveSpecialization, int ConsultantId)
        {
            List<ConsultantsSpecializations> consultantSpecilization = new List<ConsultantsSpecializations>();
            if (IdsToAddSpecialization != null)
            {
                foreach (var specialization in IdsToAddSpecialization)
                {
                    consultantSpecilization.Add(new ConsultantsSpecializations
                    {
                        ConsultantId = ConsultantId,
                        SpecializationId = specialization
                    });
                }
            }
            AppContext.ConsultantsSpecializations.AddRange(consultantSpecilization);
            List<ConsultantsSpecializations> removeConsultantSpecilization = new List<ConsultantsSpecializations>();
            if (IdsToRemoveSpecialization != null)
            {
                foreach (var specialization in IdsToRemoveSpecialization)
                {

                    var result = AppContext.ConsultantsSpecializations.Where(x => x.Consultant.Id == ConsultantId).Where(x => x.SpecializationId == specialization).FirstOrDefault();
                    AppContext.Remove(result);
                }
            }
           
            AppContext.SaveChanges();
        }
    }
}
