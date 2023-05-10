using Consultancy_Project.Entity.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultancy_Project.Data.Concrate.EfCore.Config
{
    public class AppointmentConfig : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedTime).IsRequired();
            builder.Property(x => x.UpdatedTime).IsRequired();
            builder.Property(x => x.AppointmentDate).IsRequired();
            builder.Property(x => x.ConsultantId).IsRequired();
            builder.Property(x => x.CustomerId).IsRequired();
            builder.Property(x => x.AppointmentTime).IsRequired();
            builder.Property(x => x.AppointmentTime).IsRequired();
            builder.Property(x => x.Price).IsRequired();


        }
    }
}
