using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Abstract
{
    public interface IConsultantRepository:IGenericRepository<Consultant>
    {
        Task<Consultant> GetConsultantFullDataByIdAsync(int id);
        void ConsultantsEducationAdd(Education education);
        void ConsultantsCertificateAdd(Certificate certificate);


    }
}
