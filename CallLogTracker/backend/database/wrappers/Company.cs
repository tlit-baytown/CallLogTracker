using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.database.wrappers
{
    public class Company : IDBObject
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string SupportEmail { get; set; }

        public int NumOfEmployees { get; set; }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = CompanyConnector.InsertCompany(this);
                if (ID == 0)
                    return "An error has occured while trying to insert a company into the database.";
                return $"Company with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (CompanyConnector.UpdateCompany(this))
                    return $"Company with id {{{ID}}} has been updated.";
                else
                    return "An error has occured while trying to update a company in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (CompanyConnector.DeleteCompany(this))
                return $"Company with id {{{ID}}} has been deleted.";
            else
                return "An error has occured while trying to delete a company in the database.";
        }
    }
}
