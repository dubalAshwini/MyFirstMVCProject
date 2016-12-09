using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using myFirstMVCProject.Models;

namespace MigrationsDemo
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

    
}
