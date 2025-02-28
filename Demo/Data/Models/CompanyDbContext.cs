using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }//By Convention => This Will Mapped As Table "Employees" with structure of model "Employee" not mapped as view.

        public CompanyDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = Company; UserId = sa; Password = 123456");//To Connect on sql server service using Sql Server Authentication using userName & password
            //optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog = Company; Integrated Security = true");//To Connect on sql server using Windows Authentication using My Laptop/Server Name.
            //This connection string syntax is legacy, so now they make new meaning full connection string
            // but this still work

            optionsBuilder.UseSqlServer("Server = .; Database = Company; Trusted_Connection = true; Encrypt = True; TrustServerCertificate = True");//Trust App To connect on sql server service throw Windows authentication.
        }

    }
}
