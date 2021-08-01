using CallLogTracker.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database.wrappers
{
    public class Company : IDBObject
    {
        public int ID { get; set; }

        public string Name { get; set; } = "";

        public string Phone { get; set; } = "";

        public string SupportEmail { get; set; } = "";

        public int NumOfEmployees { get; set; } = 0;

        public List<ValidatorError> ValidateObject()
        {
            List<ValidatorError> errors = new List<ValidatorError>();

            if (Name.Length <= 0)
                errors.Add(ValidatorError.Company_IncompleteName);

            if (Phone.Length <= 0 || Phone.Length > 12)
                errors.Add(ValidatorError.Company_InvalidPhone);

            if (CompanyConnector.DoesCompanyExist(Name))
                errors.Add(ValidatorError.CompanyExists);

            if (NumOfEmployees <= 0)
                errors.Add(ValidatorError.Company_InvalidEmployeeCount);

            errors.AddRange(Validator.Email(SupportEmail));

            return errors;
        }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = CompanyConnector.InsertCompany(this);
                if (ID == 0)
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to insert a company into the database.";
                return $"{DateTime.Now.ToLocalTime()} -> Company with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (CompanyConnector.UpdateCompany(this))
                    return $"{DateTime.Now.ToLocalTime()} -> Company with id {{{ID}}} has been updated.";
                else
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to update a company in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (CompanyConnector.DeleteCompany(this))
                return $"{DateTime.Now.ToLocalTime()} -> Company with id {{{ID}}} has been deleted.";
            else
                return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to delete a company in the database.";
        }
    }
}
