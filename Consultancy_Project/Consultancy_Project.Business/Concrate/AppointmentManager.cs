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
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentManager(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task CreateAsync(Appointment appointment)
        {
            await _appointmentRepository.CreateAsync(appointment);
        }

        public void Delete(Appointment appointment)
        {
             _appointmentRepository.Delete(appointment);
        }

        public async Task<List<Appointment>> GetAllAsync()
        {
           return await _appointmentRepository.GetAllAsync();
        }

        public async Task<List<Appointment>> GetAllDataByConsultantIdAsync(int consultantId)
        {
            return await _appointmentRepository.GetAllDataByConsultantIdAsync(consultantId);
        }

        public async Task<List<Appointment>> GetAllDataByCustomerIdAsync(int customerId)
        {
            return await _appointmentRepository.GetAllDataByCustomerIdAsync(customerId);
        }

        public async Task<List<Appointment>> GetAllDataByUserIdAsync(string userId, string userRole)
        {
            return await _appointmentRepository.GetAllDataByUserIdAsync(userId, userRole);
        }

        public async Task<List<Appointment>> GetAllFullDataAsync()
        {
            return await _appointmentRepository.GetAllFullDataAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _appointmentRepository.GetByIdAsync(id);
        }

        public void Update(Appointment appointment)
        {
           _appointmentRepository.Update(appointment);
        }
    }
}
