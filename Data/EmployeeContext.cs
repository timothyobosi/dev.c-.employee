using Microsoft.EntityFrameworkCore;
using MyAPIs.Models;

namespace MyAPIs.Data 
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set;}
    }
}
