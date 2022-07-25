using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReactNet.Model;

namespace ReactNet.Services
{
    public interface IEmployeeService
    {
         Task<IEnumerable<Employee>> GetAllEmploeeysAsync(); 
        Task<Employee> GetEmployeeAsync(int? id);

        IQueryable<SelectListItem> GetDropDownEmployees();
        Task<Employee> AddAsync (Employee employee);
        Task<Employee> UpdateAsync(Employee employee);
        Task DeleteConfirmedAsync(int id);
    }
}