﻿using Consultancy_Project.Data.Abstract;
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
    public class EfCoreCustomerRepository : EfCoreGenericRepository<Customer>, ICustomerRepository
    {
        public EfCoreCustomerRepository(ConsultancyProjectContext _appContext) : base(_appContext)
        {
        }
        ConsultancyProjectContext AppContext
        {
            get { return _dbContext as ConsultancyProjectContext; }
        }

        public async Task<Customer> GetByUserIdAsync(string userId)
        {
            return await AppContext.Customers.Where(x=>x.UserId==userId).FirstOrDefaultAsync();
        }
    }
}
