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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository _customerService;
        public Task CreateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
