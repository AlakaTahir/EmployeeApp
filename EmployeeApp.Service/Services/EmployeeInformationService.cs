using EmployeeApp.Model.Entity;
using EmployeeApp.Model.ViewModel;
using EmployeeApp.Service.Interfaces;
using EmployeeInformation.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Service.Services
{
    public class EmployeeInformationService : IEmployeeInformationService
    {
        private readonly EmployeeInformationDataBaseContext _context;

        public EmployeeInformationService(EmployeeInformationDataBaseContext context)
        {
            _context = context;
        }

        public EmployeeInformationResponseViewModel CreateProfile(EmployeeInformationRequestModel model)
        {
            var info = new EmployeeInfo();
            info.Id = Guid.NewGuid();
            info.FirstName = model.FirstName;
            info.LastName = model.LastName;
            info.Email = model.Email;
            info.Gender = model.Gender;
            info.CreatedDate = DateTime.Now;
            info.PhoneNumber = 0; // There is a mistake here
            info.StateofOrigin = model.StateofOrigin;

            _context.EmployeeInfos.Add(info);
            _context.SaveChanges();

            return new EmployeeInformationResponseViewModel { Message = "Successful", Status = true};
        }
    }

}
