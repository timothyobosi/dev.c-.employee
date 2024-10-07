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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee{EmployeeId = 1, EmployeeFirstNamr = "John", EmployeeLastName="Juma", EMployeeDateOfBirth = new DateTime(1998,1,1)},
                new Employee{EmployeeId = 2,EmployeeFirstNamr="Webster",EmployeeLastName="Jeferson",EMployeeDateOfBirth= new DateTime(1990,1,1)}
                new Employee {EmployeeId=3,EmployeeFirstNamr="Abi", EmployeeLastName ="Keila", EMployeeDateOfBirth= new DateTime(1995,3,20)}
            );
        }
    }
}
