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
    class CourseInstsConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> courseInst)
        {
            courseInst.ToTable("CoursesInstructors")
                      .HasKey(c => new { c.Inst_ID, c.Course_ID });

        }
    }
}
