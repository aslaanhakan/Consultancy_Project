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

        public CustomerManager(ICustomerRepository customerService)
        {
            _customerService = customerService;
        }

        public async Task CreateAsync(Customer customer)
        {
            await _customerService.CreateAsync(customer);
        }

        public  void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }

        public Task<List<Customer>> GetAllAsync()
        {
            return _customerService.GetAllAsync();
        }

        public Task<Customer> GetByIdAsync(int id)
        {
           return _customerService.GetByIdAsync(id);
        }

        public void Update(Customer customer)
        {
            _customerService.Update(customer);
        }
    }
}
