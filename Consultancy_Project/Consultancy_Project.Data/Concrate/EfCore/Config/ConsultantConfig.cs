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
    public class ConsultantConfig : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x=>x.Promotion).IsRequired();
            builder.Property(x=>x.VisitsPrice).IsRequired();
            builder.Property(x => x.JobTitle).IsRequired();
            
        }
    }
}
