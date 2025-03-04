using Assignment.Data.ConfigurationClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{

    class ITIDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI; Trusted_Connection = true; Encrypt = True; TrustServerCertificate = True");//Trust App To connect on sql server service throw Windows authentication.
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(D =>
            {
                D.ToTable("Depts", "Sales");
                D.HasKey(D => D.DepartmentId);
                D.Property(D => D.DepartmentId)
                 .UseIdentityColumn(10, 10);

                D.Property(D => D.DepartmentName)
                 .HasColumnType("varchar")
                 .HasMaxLength(20)
                 .IsRequired(false);

                D.Property(D => D.HiringDate)
                 .HasDefaultValueSql("GetDate()")
                 .HasAnnotation("DateType", "Date");
            });

            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());
        }
    }
}
