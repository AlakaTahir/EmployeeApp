using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp.Model.Entity
{
    public class EmployeeInfo
    {
     public Guid Id { get; set; }
     public string FirstName { get; set; }
     public string LastName { get; set; }
     public DateTime CreatedDate { get; set; }
     public DateTime DateofBirth { get; set; }
     public string StateofOrigin { get; set; }
     public string Gender { get; set; }
     public int PhoneNumber { get; set; }
     public string Email { get; set; }
    }
}
