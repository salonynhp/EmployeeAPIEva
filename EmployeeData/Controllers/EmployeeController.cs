

//using Employee.Business.Contract;
using Employee.Business;
//using Employee.Business.Business;
using Employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{   
    //This controller will handle the HTTP requests related to employees.
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
      
        private readonly EmployeeBusiness _EmployeeBusiness;
        public EmployeeController()
        {
            _EmployeeBusiness = new EmployeeBusiness();
        }

        //change start
        
        //////1.creation of endpoint
        [HttpGet("{id}")]
        public ActionResult<EmployeeMaster> GetEmployeeById(int id)
        {
            var employee = _EmployeeBusiness.GetEmployeeById(id);
            if (employee == null)
                return NotFound();
                
           return Ok(employee);
        } 
        //change end
        /*
        //action method with parameter
        [HttpGet("{id}")]
        public string GetEmployeeById(int id)
        {
            return employee.ElementAt(id);
        }
        */
        [HttpGet()]
        public IEnumerable<EmployeeMaster> Getemployee()
        {
            var result = _EmployeeBusiness.GetEmployee();
            return result;
        }
    }
}
