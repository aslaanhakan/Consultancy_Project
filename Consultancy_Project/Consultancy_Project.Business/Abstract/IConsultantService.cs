﻿using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface IConsultantService
    {
        Task CreateAsync(Consultant consultant);
        Task<Consultant> GetByIdAsync(int id);
        Task<List<Consultant>> GetAllAsync();
        void Update(Consultant consultant);
        void Delete(Consultant consultant);
    }   
}