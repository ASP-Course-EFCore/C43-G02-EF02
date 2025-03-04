using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public required string DepartmentName { get; set; }
        public int? Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
    }
}
