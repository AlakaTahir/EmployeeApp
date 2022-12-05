using EmployeeApp.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Service.Interfaces
{
    public interface IEmployeeInformationService
    {
        BaseResponseViewModel CreateProfile(EmployeeInformationRequestModel model);

        EmployeeInformationResponseViewModel GetProfileByMail(string emailAddress);

        BaseResponseViewModel DeleteProfile(Guid id);

        BaseResponseViewModel UpdateProfile(Guid id, EmployeeInformationRequestModel model);
    }
}
