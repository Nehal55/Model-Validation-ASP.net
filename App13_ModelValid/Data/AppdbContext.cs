using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App13_ModelValid.Models;

namespace App13_ModelValid.Models
{
    public class AppdbContext : DbContext
    {
        public AppdbContext (DbContextOptions<AppdbContext> options)
            : base(options)
        {
        }

        public DbSet<App13_ModelValid.Models.Employee> Employee { get; set; }

        public DbSet<App13_ModelValid.Models.Person> Person { get; set; }
    }
}
