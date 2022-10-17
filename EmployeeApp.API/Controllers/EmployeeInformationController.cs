using EmployeeApp.Model.ViewModel;
using EmployeeApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInformationController : ControllerBase
    {  
        private readonly IEmployeeInformationService _employeeInformationService;
        public EmployeeInformationController(IEmployeeInformationService employeeInformationService)
        {
            _employeeInformationService = employeeInformationService;
        }
        [HttpPost]
        public IActionResult CreateProfile(EmployeeInformationRequestModel model) 
        {
            var response = _employeeInformationService.CreateProfile(model);
            return Ok (response);
        }
    
    
    } 


}
