using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App13_ModelValid.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string Designation { get; set; }

        [DataType(DataType.Date), Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }

        [Range(1000, 10000)]
        public double Salary { get; set; }

        [Range(1, 10)]
        public int Grade { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [StringLength(11)]
        [MinLength(11)]
        public string CellPhone { get; set; }

    }
}
