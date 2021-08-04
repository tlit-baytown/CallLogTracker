using CallLogTracker.backend.database.wrappers;
using System;

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

        public class UserCreatedEventArgs : EventArgs
        {
            public User CreatedUser { get; internal set; }

            public UserCreatedEventArgs(User u)
            {
                CreatedUser = u;
            }
        }
    }
}
