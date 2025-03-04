using Assignment.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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

            #region 02 - CRUD on Instructors table 

            #region 01.1 - ADD/Insert

            //Instructor instructor = new Instructor()
            //{
            //    Name = "Eslam Elsaadany",
            //    Address = "Mansoura",
            //    Bonus = 1000,
            //    HourRate = 50,
            //    Salary = 10000,
            //    DeptId = 5
            //};
            //Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Detached
            //dbContext.Add<Instructor>(instructor);
            //Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Unchanged

            #endregion

            #region 01.2 - Retrieve

            //var instructor = dbContext.Instructors.AsNoTracking().FirstOrDefault(i => i.Address == "Mansoura");

            //if(instructor is not null)
            //  Console.WriteLine($"Name:{instructor.Name} - Address:{instructor.Address} - HourRate:{instructor.HourRate} - Salary:{instructor.Salary:c}" );

            #endregion

            #region 01.3 - Update

            //var instructor = dbContext.Instructors.FirstOrDefault(i => i.Address == "Mansoura");

            //if(instructor is not null)
            //{
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//UnChanged
            //    instructor.Address = "TANTA";
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Modified
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//UnChanged
            //}

            #endregion

            #region 01.4 - Delete

            //var instructor = (from inst in dbContext.Instructors
            //                  where inst.Address == "Mansoura"
            //                  select inst).FirstOrDefault();

            //if(instructor is not null)
            //{
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//UnChanged
            //    dbContext.Remove<Instructor>(instructor);
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Deleted
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Instructor>(instructor).State);//Detached
            //}

            #endregion

            #endregion

            #region 03 - CRUD on Department table 

            #region 01.1 - ADD/Insert

            //Department department = new Department()
            //{
            //    DepartmentName = "HR",
            //};

            //Console.WriteLine(dbContext.Entry(department).State);//Detached
            //dbContext.Add(department);
            //Console.WriteLine(dbContext.Entry(department).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(department).State);//UnChanged

            #endregion

            #region 01.2 - Retrieve

            //var department = dbContext.Departments.AsNoTracking().FirstOrDefault(D => D.DepartmentName == "HR");

            //if (department is not null)
            //{
            //    Console.WriteLine($"DepartmentId:{department.DepartmentId} - DepartmentName:{department.DepartmentName} Ins_Id:{department.Ins_Id}- HiringDate:{department.HiringDate}");
            //}

            #endregion

            #region 01.3 - Update

            //var department = dbContext.Departments.FirstOrDefault(D => D.DepartmentName == "HR");

            //if(department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);//Unchanged
            //    department.DepartmentName = "Al-Azhar";
            //    Console.WriteLine(dbContext.Entry(department).State);//Modified
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(department).State);//Unchanged
            //}

            #endregion

            #region 01.4 - Delete

            //var department = dbContext.Departments.FirstOrDefault(D => D.DepartmentName == "HR");

            //if (department is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(department).State);//Unchanged
            //    dbContext.Remove(department);
            //    Console.WriteLine(dbContext.Entry(department).State);//Deleted
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(department).State);//Detached
            //}

            #endregion

            #endregion

            #region 03 - CRUD on Department table 

            #region 01.1 - ADD/Insert

            //Course course = new Course()
            //{
            //    Name = "C++",
            //    Duration = "120h",
            //    Description = "Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla",
            //    Top_Id = 5
            //};

            //Console.WriteLine(dbContext.Entry(course).State);//Detached
            //dbContext.Add(course);
            //Console.WriteLine(dbContext.Entry(course).State);//Added
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(course).State);//UnChanged

            #endregion

            #region 01.2 - Retrieve

            //var course = dbContext.Courses.AsNoTracking().FirstOrDefault(c => c.Name == "C++");

            //if (course is not null)
            //{
            //    Console.WriteLine($"ID:{course.ID} - Name:{course.Name} - Duration:{course.Duration} - Description:{course.Description}");
            //}

            #endregion

            #region 01.3 - Update

            //var course = dbContext.Courses.FirstOrDefault(c => c.Name == "C++");

            //if (course is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(course).State);//Unchanged
            //    course.Name = "JAVA";
            //    Console.WriteLine(dbContext.Entry(course).State);//Modified
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(course).State);//Unchanged
            //}

            #endregion

            #region 01.4 - Delete

            //var course = dbContext.Courses.FirstOrDefault(c => c.Name == "JAVA");

            //if (course is not null)
            //{
            //    Console.WriteLine(dbContext.Entry(course).State);//Unchanged
            //    dbContext.Remove(course);
            //    Console.WriteLine(dbContext.Entry(course).State);//Deleted
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry(course).State);//Detached
            //}

            #endregion

            #endregion

        }
    }
}
