using CallLogTracker.utility;
using System;
using System.Collections.Generic;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database.wrappers
{
    public class Call : IDBObject
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public int UserID { get; set; }

        public string CallerName { get; set; }

        public string CallerPhone { get; set; }

        public string CallerEmail { get; set; } = null;

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public DateTime Timestamp { get; set; }

        public bool IsUrgent { get; set; }

        public List<ValidatorError> ValidateObject()
        {
            List<ValidatorError> errors = new List<ValidatorError>();

            if (CallerName.Length <= 0 || CallerName.Length > 255)
                errors.Add(ValidatorError.Call_InvalidName);
            if (CallerPhone.Length <= 0 || CallerPhone.Length > 12)
                errors.Add(ValidatorError.Call_InvalidPhone);
            if (Message.Length <= 0 || Message.Length > 65535)
                errors.Add(ValidatorError.Call_InvalidMessage);

            if (CallerEmail != null)
                errors.AddRange(Validator.Email(CallerEmail));

            return errors;
        }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = CallConnector.InsertCall(this);
                if (ID == 0)
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to insert a call into the database.";
                return $"{DateTime.Now.ToLocalTime()} -> Call with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (CallConnector.UpdateCall(this))
                    return $"{DateTime.Now.ToLocalTime()} -> Call with id {{{ID}}} has been updated.";
                else
                    return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to update a call in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (CallConnector.DeleteCall(this))
                return $"{DateTime.Now.ToLocalTime()} -> Call with id {{{ID}}} has been deleted.";
            else
                return $"{DateTime.Now.ToLocalTime()} -> An error has occured while trying to delete a call in the database.";
        }
    }
}
