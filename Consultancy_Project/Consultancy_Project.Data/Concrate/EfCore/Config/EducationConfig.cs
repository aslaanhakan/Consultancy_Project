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
    public class EducationConfig : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.SchoolName).IsRequired();
            builder.Property(x => x.FacultyName).IsRequired();
            builder.Property(x => x.DepartmentName).IsRequired();            
            builder.Property(x => x.DegreeofGraduation).IsRequired();
            builder.Property(x => x.StartYear).IsRequired()
                                             .HasMaxLength(4);
            builder.Property(x => x.GraduationYear).IsRequired()
                                             .HasMaxLength(4);

           
        }
    }
}
