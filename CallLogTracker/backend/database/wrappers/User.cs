using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.database.wrappers
{
    public class User : IDBObject
    {
        public int ID { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AssociatedCompany { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public Company GetCompany()
        {
            return CompanyConnector.GetCompany(AssociatedCompany);
        }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = UserConnector.InsertUser(this);
                if (ID == 0)
                    return "An error has occured while trying to insert a user into the database.";
                return $"User with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (UserConnector.UpdateUser(this))
                    return $"User with id {{{ID}}} has been updated.";
                else
                    return "An error has occured while trying to update a user in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (UserConnector.DeleteUser(this))
                return $"User with id {{{ID}}} has been deleted.";
            else
                return "An error has occured while trying to delete a user in the database.";
        }
    }
}
