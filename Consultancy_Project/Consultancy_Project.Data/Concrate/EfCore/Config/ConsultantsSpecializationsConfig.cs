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
    public class ConsultantsSpecializationsConfig:IEntityTypeConfiguration<ConsultantsSpecializations>
    {
        public void Configure(EntityTypeBuilder<ConsultantsSpecializations> builder)
        {
            builder.HasKey(cs => new { cs.ConsultantId, cs.SpecializationId });
        }
    
    }
}
