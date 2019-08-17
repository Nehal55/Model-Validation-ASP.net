using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App13_ModelValid.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Remote(action:"verify", controller:"Test")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [Required]
        public string Occupation { get; set; }
    }
}
