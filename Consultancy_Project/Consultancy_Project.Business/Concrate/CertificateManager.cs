using Consultancy_Project.Business.Abstract;
using Consultancy_Project.Data.Abstract;
using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Concrate
{
    public class CertificateManager : ICertificateService
    {
        private readonly ICertificateRepository _certificateRepository;

        public CertificateManager(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        public async Task CreateAsync(Certificate certificate)
        {
           await _certificateRepository.CreateAsync(certificate);
        }

        public void Delete(Certificate certificate)
        {
            _certificateRepository.Delete(certificate);
        }

        public Task<List<Certificate>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Certificate> GetByIdAsync(int id)
        {
           return await _certificateRepository.GetByIdAsync(id);
        }

        public void Update(Certificate certificate)
        {
            throw new NotImplementedException();
        }
    }
}
