using EmployeeApp.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Service.Interfaces
{
    public interface IEmployeeInformationService
    {
        EmployeeInformationResponseViewModel CreateProfile(EmployeeInformationRequestModel model);
    }
}
