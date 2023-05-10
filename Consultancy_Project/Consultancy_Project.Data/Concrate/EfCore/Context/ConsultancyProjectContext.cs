using Consultancy_Project.Data.Concrate.EfCore.Config;
using Consultancy_Project.Data.Concrate.EfCore.Extensions;
using Consultancy_Project.Entity.Concrate;
using Consultancy_Project.Entity.Concrate.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore.Context
{
    public class ConsultancyProjectContext: IdentityDbContext<User,Role,string>
    {
        public ConsultancyProjectContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Consultant> Consultants{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<CustomersConsultans> CustomersConsultans { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<ConsultantsSpecializations> ConsultantsSpecializations { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Available> Availables{ get; set; }
        public DbSet<WorkingHours> WorkingHours { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppointmentConfig).Assembly);

            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
