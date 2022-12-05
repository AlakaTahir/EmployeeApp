using EmployeeApp.Model.ViewModel;
using EmployeeApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpGet]
        public IActionResult GetProfile(string emailAddress)
        {
            var response = _employeeInformationService.GetProfileByMail(emailAddress);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult GetProfile(Guid id)
        {
            var response = _employeeInformationService.DeleteProfile(id);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult UpdateProfile(Guid id, EmployeeInformationRequestModel model)
        {
            var response = _employeeInformationService.UpdateProfile(id, model);
            return Ok(response);
        }
        [HttpDelete]
        public IActionResult DeleteProfile(Guid id)
        {
            var response = _employeeInformationService.DeleteProfile(id);
            return Ok(response);
        }

    }


}
