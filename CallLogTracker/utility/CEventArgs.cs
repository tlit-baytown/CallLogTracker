using CallLogTracker.backend.database.wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallLogTracker.utility
{
    public class CEventArgs
    {
        /// <summary>
        /// Event args representing when a database connection is done connecting.
        /// </summary>
        public class DBArgs : EventArgs
        {
            public int ExceptionCode { get; internal set; }

            public DBArgs(int exCode)
            {
                ExceptionCode = exCode;
            }
        }

        public class LoginDoneEventArgs : EventArgs
        {
            public User LoggedInUser { get; internal set; }

            public LoginDoneEventArgs(User u)
            {
                LoggedInUser = u;
            }
        }
    }
}
