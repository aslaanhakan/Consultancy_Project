using Consultancy_Project.Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Abstract
{
    public interface IAppointmentRepository:IGenericRepository<Appointment>
    {
        Task<List<Appointment>> GetAllFullDataAsync();
    }
}
