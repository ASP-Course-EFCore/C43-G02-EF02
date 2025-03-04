using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    [PrimaryKey("Stud_Id", "Course_Id")]
    [Table("StudentsCourses")]
    class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public decimal Grade { get; set; }
    }
}
