using CallLogTracker.utility;
using System;
using System.Collections.Generic;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database.wrappers
{
    public class User : IDBObject
    {
        public int ID { get; set; }

        public string Username { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public int AssociatedCompany { get; set; } = 0;
        public string Password { get; set; } = "";
        public string Name { get; set; } = "";

        public Company GetCompany()
        {
            return CompanyConnector.GetCompany(AssociatedCompany);
        }

        public List<ValidatorError> ValidateObject()
        {
            List<ValidatorError> errors = new List<ValidatorError>();
            if (AssociatedCompany == 0)
                errors.Add(ValidatorError.User_InvalidCompany);

            if (Name.Length <= 0)
                errors.Add(ValidatorError.User_IncompleteName);
            errors.AddRange(Validator.Email(Email));

            if (PhoneNumber.Length <= 0 || PhoneNumber.Length > 12)
                errors.Add(ValidatorError.User_InvalidPhone);

            if (UserConnector.DoesUserExist(Username))
                errors.Add(ValidatorError.UserExists);

            if (Username.Length <= 0)
                errors.Add(ValidatorError.User_IncompleteUsername);

            errors.AddRange(Validator.Password(Password));

            return errors;
        }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = UserConnector.InsertUser(this);
                if (ID == 0)
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to insert a user into the database.";
                return $"{DateTime.Now.ToLocalTime()} -> User with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (UserConnector.UpdateUser(this))
                    return $"{DateTime.Now.ToLocalTime()} -> User with id {{{ID}}} has been updated.";
                else
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to update a user in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (UserConnector.DeleteUser(this))
                return $"{DateTime.Now.ToLocalTime()} -> User with id {{{ID}}} has been deleted.";
            else
                return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to delete a user in the database.";
        }
    }
}
