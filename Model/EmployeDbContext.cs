using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReactNet.Model
{
    public class EmployeDbContext : DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext> options): base(options) { } 
        public DbSet <Employee> Employees { get; set; }

    }
}