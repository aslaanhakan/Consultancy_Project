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
    public class CustomersConsultansConfig : IEntityTypeConfiguration<CustomersConsultans>
    {
        public void Configure(EntityTypeBuilder<CustomersConsultans> builder)
        {
            builder.HasKey(cc => new { cc.ConsultantId, cc.CustomerId });
        }
    }
}
