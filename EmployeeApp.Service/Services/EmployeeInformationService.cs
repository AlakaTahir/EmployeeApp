using EmployeeApp.Model.Entity;
using EmployeeApp.Model.ViewModel;
using EmployeeApp.Service.Interfaces;
using EmployeeInformation.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public BaseResponseViewModel CreateProfile(EmployeeInformationRequestModel model)
        {
            //Find if email already exist on the database
            var profile = _context.EmployeeInfos.FirstOrDefault(x => x.Email == model.Email);

            if(profile == null)
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

                return new BaseResponseViewModel
                {
                    Message = "Successful",
                    Status = true
                };
            }
            //else if record exist
            else
            {
                return new BaseResponseViewModel
                {
                    Message = "User already exist",
                    Status = false
                };
            }


        }

        public EmployeeInformationResponseViewModel GetProfileByMail(string emailAddress)
        {
            var profile = _context.EmployeeInfos.FirstOrDefault(x => x.Email == emailAddress);
            if(profile != null)
            {
                return new EmployeeInformationResponseViewModel
                {
                    FirstName = profile.FirstName,
                    LastName = profile.LastName,
                    PhoneNumber = null,
                    Email = profile.Email,
                    StateofOrigin = profile.StateofOrigin,
                    DateofBirth = profile.DateofBirth,
                    Gender = profile.Gender
                };
            }
            else
            {
                return null;
            }
        }

        public BaseResponseViewModel DeleteProfile(Guid id)
        {
            //Find if record exist
            var profile = _context.EmployeeInfos.FirstOrDefault(x => x.Id == id);

            //if record exist
            if(profile != null)
            {
                _context.EmployeeInfos.Remove(profile);
                _context.SaveChanges();

                return new BaseResponseViewModel
                {
                    Message = "Successful",
                    Status = true
                };
            }
            //else if record does nor exist
            else
            {
                return new BaseResponseViewModel
                {
                    Message = "User does not exist",
                    Status = false
                };
            }
        }

        public BaseResponseViewModel UpdateProfile(Guid id, EmployeeInformationRequestModel model)
        {
            //Find if record exist
            var profile = _context.EmployeeInfos.FirstOrDefault(x => x.Id == id);


            //if record exist
            if (profile != null)
            {
                profile.FirstName = model.FirstName;
                profile.LastName = model.LastName;
                profile.Email = model.Email;
                profile.StateofOrigin = model.StateofOrigin;
                profile.DateofBirth = model.DateofBirth;
                profile.Gender = model.Gender;

                _context.EmployeeInfos.Update(profile);
                _context.SaveChanges();

                return new BaseResponseViewModel
                {
                    Message = "Successful",
                    Status = true
                };
            }
            //else if record does nor exist
            else
            {
                return new BaseResponseViewModel
                {
                    Message = "User does not exist",
                    Status = false
                };
            }
        }
    }

}
