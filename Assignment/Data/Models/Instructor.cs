using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    //Data Annotations
    class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstId { get; set; }
        [DataType("varchar(20)", ErrorMessage = "Maximum Length is 20 chars ")]
        [MinLength(3, ErrorMessage = "Min Length is 3 chars")]
        public string Name { get; set; }
        public int Bonus { get; set; }
        [DisplayName("Net_Salary")]
        public int Salary { get; set; }
        [DataType("varchar")]
        [MaxLength(50)]
        [MinLength(5)]
        public string? Address { get; set; }
        public decimal? HourRate { get; set; }
        [NotMapped]
        public int DeptId { get; set; }
    }
}
