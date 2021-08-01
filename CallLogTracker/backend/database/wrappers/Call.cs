﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.database.wrappers
{
    public class Call : IDBObject
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public int UserID { get; set; }

        public string CallerName { get; set; }

        public string CallerPhone { get; set; }

        public string CallerEmail { get; set; }

        public string Message { get; set; }

        public DateTime Timestamp { get; set; }

        public string Insert()
        {
            if (ID == 0)
            {
                ID = CallConnector.InsertCall(this);
                if (ID == 0)
                    return "An error has occured while trying to insert a call into the database.";
                return $"Call with id {{{ID}}} has been inserted.";
            }
            else
            {
                if (CallConnector.UpdateCall(this))
                    return $"Call with id {{{ID}}} has been updated.";
                else
                    return "An error has occured while trying to update a call in the database.";
            }
        }

        public string Update()
        {
            return Insert();
        }

        public string Delete()
        {
            if (CallConnector.DeleteCall(this))
                return $"Call with id {{{ID}}} has been deleted.";
            else
                return "An error has occured while trying to delete a call in the database.";
        }
    }
}