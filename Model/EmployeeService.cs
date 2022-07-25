using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReactNet.DataBase;

namespace ReactNet.Services
{
    public class EmployeeService : IEmployeeService
    {
     private readonly EmployeDbContext _context;

        public EmployeeService(EmployeDbContext context)
        { 
            _context = context;
        } 

        public async Task<IEnumerable<Employee>> GetAllEmploeeysAsync()
        { 
            return await _context.Employees.Include(x =>
            x.FristName).ToListAsync(); 
        }

        public async Task<Employee> GetEmployeeAsync(int? id) 
        { 
                return await _context.Employees.FirstOrDefaultAsync(m => m.Id
                == id); 
        }

        public IQueryable<SelectListItem> GetDropDownEmployees()
        { 
            return _context.Employees.Select(x => new SelectListItem { Value =
            x.Id.ToString(), Text = x.FristName }); 
        }

       

        public async Task<Employee> AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
        public async Task<Employee> UpdateAsync(Employee employee)
        {
          _context.Update(employee);
           await _context.SaveChangesAsync();
           return employee;
        }

       public async Task DeleteConfirmedAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            _context.Employees.Remove(employee);

            await _context.SaveChangesAsync();
    }
}
}