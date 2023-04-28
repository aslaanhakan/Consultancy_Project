using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface ICertificateService
    {
        Task CreateAsync(Certificate certificate);
        Task<Certificate> GetByIdAsync(int id);
        Task<List<Certificate>> GetAllAsync();
        void Update(Certificate certificate);
        void Delete(Certificate certificate);
    }
}
