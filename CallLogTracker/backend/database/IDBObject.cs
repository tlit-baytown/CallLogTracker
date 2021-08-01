using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.backend.database
{
    public interface IDBObject
    {
        int ID { get; set; }

        List<ValidatorError> ValidateObject();

        string Insert();
        string Update();
        string Delete();
    }
}
