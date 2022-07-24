using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReactNet.DataBase;
using ReactNet.Services;

namespace ReactNet.Controllers
{
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
     private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAll()
        { 
            return await _service.GetAllEmploeeysAsync(); 
        }
        [HttpGet("/hi")]
        public IActionResult get (){
            return Content ("hello world ");
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        
    }
}