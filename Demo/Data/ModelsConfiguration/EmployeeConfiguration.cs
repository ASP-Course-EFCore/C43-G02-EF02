using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.ModelsConfiguration
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> employee)
        {
            employee.HasKey(E => E.Code);
            employee
                //.Property("EmpName");//Will throw Exception when Add-Migration if this parameter not represent name of any property/column inside the model Employee.
                .Property<string>("EmpName");//If Found property in class "Employee" of type string and called "EmpName" will use it
                                                     //if not it will define "EmpName" as Shadow Property => Mean That this "EmpName" will be column in DB but it not represented as property in the model "Employee"

            employee
                   //.Property(nameof(Employee.Name));//use The string which represent the property "Name".
                   .Property(E => E.Name)//Use This Overload.
                   .HasColumnName("EmployeeName")//To Change The Column/Property Name
                                                 //.HasColumnType("varchar(50)")//To Change The Data Type Of Data will stored in column "EmployeeName" to be of type "varchar(50)" with maxLength 50
                   .HasColumnType("varchar")//To Change The Data Type Of Data will stored in column "EmployeeName" to be of type "varchar(1)"
                   .HasMaxLength(50)//Max Length of data will be stored in this column will be 50
                   .IsRequired(false);//To make This Column Allow Null.
        }
    }
}
