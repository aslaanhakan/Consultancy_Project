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
    public class AvailableManager : IAvailableService
    {
       private readonly IAvailableRepository _availaleRepository;

        public AvailableManager(IAvailableRepository availaleRepository)
        {
            _availaleRepository = availaleRepository;
        }

        public Task CreateAsync(Available entity)
        {
            throw new NotImplementedException();
        }

        public void CreateAvailableOfDate(int consultantId, int[] selectedHours, DateOnly date)
        {
            _availaleRepository.CreateAvailableOfDate(consultantId,selectedHours,date);
        }

        public void Delete(Available entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Available>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Available>> GetAllAvailablesOfDateAsync(DateOnly date, int id)
        {
            return await _availaleRepository.GetAllAvailablesOfDateAsync(date,id);
        }

        public async Task<List<WorkingHours>> GetAllWorkingHours()
        {
            return await _availaleRepository.GetAllWorkingHours();
        }

        public async Task<List<DateOnly>> GetAvailablesGroupByDateAsync(int id)
        {
            return await _availaleRepository.GetAvailablesGroupByDateAsync(id);
        }

        public Task<Available> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Available entity)
        {
            throw new NotImplementedException();
        }
    }
}
