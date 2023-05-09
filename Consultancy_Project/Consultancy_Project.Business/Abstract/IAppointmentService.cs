using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Business.Abstract
{
    public interface IAppointmentService
    {
        Task CreateAsync(Appointment appointment);
        Task<Appointment> GetByIdAsync(int id);
        Task<List<Appointment>> GetAllAsync();
        void Update(Appointment appointment);
        void Delete(Appointment appointment);
        Task<List<Appointment>> GetAllFullDataAsync();

    }
}
