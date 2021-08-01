using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend.database
{
    public interface IDBObject
    {
        int ID { get; set; }
        string Insert();
        string Update();
        string Delete();
    }
}
