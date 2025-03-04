using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.ConfigurationClasses
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.Property(c => c.Name)
                  .HasColumnType("varchar(20)");

            course.Property(c => c.ID)
                  .UseIdentityColumn(10, 5)
                  .HasColumnName("CourseID");

            course.Property(c => c.Description)
                  .IsRequired(false)
                  .HasColumnType("varchar(100)");

            course.Property(c => c.Top_Id)
                  .IsRequired(false);
      
        }
    }
}
