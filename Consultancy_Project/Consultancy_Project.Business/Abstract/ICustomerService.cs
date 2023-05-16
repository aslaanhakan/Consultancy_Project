using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface ICustomerService
    {
        Task CreateAsync(Customer customer);
        Task<Customer> GetByIdAsync(int id);
        Task<List<Customer>> GetAllAsync();
        void Update(Customer customer);
        void Delete(Customer customer);
        Task<Customer> GetByUserIdAsync(string userId);

    }
}
