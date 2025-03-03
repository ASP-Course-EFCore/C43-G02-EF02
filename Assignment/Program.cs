using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region 01 - CRUD on students table 

            #region 01.1 - ADD/Insert

            //Student student = new Student()
            //{
            //    FName = "Eslam",
            //    LName = "El-saadany",
            //    Address = "Mansoura",
            //    Age = 22,
            //};
            //Console.WriteLine(dbContext.Entry<Student>(student).State);//Detached
            //dbContext.Add<Student>(student);
            //Console.WriteLine(dbContext.Entry<Student>(student).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry<Student>(student).State);//Unchanged

            #endregion

            #region 01.2 - Retrieve

            //var emp = dbContext.Students.AsNoTracking<Student>().FirstOrDefault(s => s.Age == 22);

            //if (emp is not null)
            //{

            //    Console.WriteLine($"Id = {emp.Id} - FName = {emp.FName} - LName = {emp.LName} - Age = {emp.Age} - Address = {emp.Address}");
            //    //Id = 2 - FName = Eslam - LName = El-saadany - Age = 22 - Address = Mansoura
            //}

            #endregion

            #region 01.3 - Update

            //var emp = dbContext.Students.FirstOrDefault(s => s.Age == 22);

            //if (emp is not null)
            //{

            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//UnChanged
            //    emp.Age = 33;
            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//Modified
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//UnChanged

            //}

            #endregion

            #region 01.4 - Delete

            //var emp = dbContext.Students.FirstOrDefault(s => s.Age == 22);

            //if(emp is not null)
            //{
            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//UnChanged
            //    dbContext.Remove<Student>(emp);
            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//Deleted
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Student>(emp).State);//Detached

            //}

            #endregion

            #endregion
        }
    }
}
