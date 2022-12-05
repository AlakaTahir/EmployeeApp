using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Model.ViewModel
{
    public class EmployeeInformationResponseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string StateofOrigin { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
