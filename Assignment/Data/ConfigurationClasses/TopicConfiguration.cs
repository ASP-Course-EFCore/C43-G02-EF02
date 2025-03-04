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
    class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> topic)
        {
            topic.ToTable("Topics", "Sales")
                .HasKey(t => t.Top_id);

            topic.Property(t => t.Name)
                .HasColumnName("Topic_Name")
                .HasColumnType("varchar")
                .HasMaxLength(20);

        }
    }
}
