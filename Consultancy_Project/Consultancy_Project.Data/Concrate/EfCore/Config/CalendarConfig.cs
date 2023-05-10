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
    public class CalendarConfig : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedTime).IsRequired();
            builder.Property(x => x.UpdatedTime).IsRequired();
            builder.Property(x=>x.ConsultantId).IsRequired();
            builder.Property(x=> x.TimeRange).IsRequired();
            builder.Property(x=> x.Date).IsRequired();
        }
    }
}
