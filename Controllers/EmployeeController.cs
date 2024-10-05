using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAPIs.Data;
using MyAPIs.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace MyAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            _context =context;
        }

        //GET: api/employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        //GET: api/employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee( int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if(employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        //POST: api/employee
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.EmployeeId},employee);
        }

        //PUT : api/employee/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if(id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee( int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}