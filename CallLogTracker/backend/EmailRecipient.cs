using CallLogTracker.backend.database.wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.backend
{
    public class EmailRecipient
    {
        public User User { get; set; }

        public override string ToString()
        {
            if (User != null)
                return $"{User.Name}\t{User.Email}";
            else
                return "";
        }
    }
}
