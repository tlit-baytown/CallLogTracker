using System.ComponentModel;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.utility
{
    public class Enums
    {
        public enum QType
        {
            SELECT,
            INSERT,
            UPDATE,
            DELETE
        }

        /// <summary>
        /// Enum representing the various validator errors from the <see cref="Validator"/> class.
        /// </summary>
        public enum ValidatorError
        {
            [Description("The employee's name was empty.\n")]
            User_IncompleteName,
            [Description("The employee's username was empty.\n")]
            User_IncompleteUsername,
            [Description("The username already exists in the database.\n")]
            UserExists,
            [Description("The email address entered is incomplete or is not in the correct format.\n")]
            InvalidEmailAddress,
            [Description("The email address cannot be empty.")]
            NoLengthEmailAddress,
            [Description("The email address cannot be \"N/A\".")]
            EmailNA,
            [Description("The employee's phone number was incomplete or not in a valid format.\n")]
            User_InvalidPhone,
            [Description("The employee's password must be between 6 and 24 characters.\n")]
            User_InvalidPassword,
            [Description("The password must contain at least 1 special character.\n")]
            Password_NumOfSpecials,
            [Description("The password must contain at least 1 digit.\n")]
            Password_NumOfDigits,
            [Description("The employee has no company associated with them. Select a company and try again.\n")]
            User_InvalidCompany,
            [Description("The company's name cannot be empty.\n")]
            Company_IncompleteName,
            [Description("The company's phone number was incomplete or not in a valid format.\n")]
            Company_InvalidPhone,
            [Description("The company already exists in the database.\n")]
            CompanyExists,
            [Description("The company must have at least one employee.\n")]
            Company_InvalidEmployeeCount,
            [Description("The caller's name cannot be empty and should be between 1 and 255 chars.")]
            Call_InvalidName,
            [Description("The caller's phone number cannot be empty and should be 12 chars.")]
            Call_InvalidPhone,
            [Description("The message cannot be empty and should be between 1 and 65,535 chars.")]
            Call_InvalidMessage,
            [Description("An exception occured while trying to validate the input. Please try again.")]
            Exception,
            [Description("No error has occured and all validation succeeded.")]
            None
        }

        /// <summary>
        /// The available options for filtering call data based on three variables:
        /// Current User, Today, and Unresolved.
        /// </summary>
        public enum CallDisplayOption
        {
            [Description("No display option.")]
            None = 0,
            [Description("Shows all calls in the database regardless of status, date, or user.")]
            AllCalls = 1,
            [Description("Shows all calls in the database that are unresolved regardless of date or user.")]
            AllCallsUnresolved = 2,
            [Description("Shows all calls in the database for today regardless of status or user.")]
            AllCallsToday = 4,
            [Description("Shows all calls in the database for today that are unresolved regardless of user.")]
            AllCallsTodayUnresolved = 8,
            [Description("Shows all calls in the database for the current user regardless of date or status.")]
            AllCallsCurrentUser = 16,
            [Description("Shows all calls in the database for the current user that are unresolved regardless of date.")]
            AllCallsCurrentUserUnresolved = 32,
            [Description("Shows all calls in the database for today for the current user regardless of status.")]
            AllCallsTodayCurrentUser = 64,
            [Description("Shows all calls in the database for today for the current user that are unresolved.")]
            AllCallsTodayCurrentUserUnresolved = 128,
        }

        /// <summary>
        /// This struct's <see cref="DisplayOption"/> determines how the <see cref="gui.user_controls.ViewCallsCtl"/>
        /// displays call information.
        /// <para>You can create a display option by specifing the three values in the constructor of this struct.
        /// After creating the struct, simply get the <see cref="DisplayOption"/> value and display data accordingly.</para>
        /// </summary>
        public struct CallDisplay
        {
            public bool byCurrentUser { get; private set; }
            public bool byToday { get; private set; }
            public bool byUnresolved { get; private set; }

            public CallDisplayOption DisplayOption;

            /// <summary>
            /// Get an instance of this struct with the <see cref="DisplayOption"/> value set
            /// according to the arguments.
            /// </summary>
            /// <param name="byCurrentUser">Should only calls taken by the current user be shown?</param>
            /// <param name="byToday">Should only calls from today be shown?</param>
            /// <param name="byUnresolved">Show only calls that are unresolved be shown?</param>
            public CallDisplay(bool byCurrentUser, bool byToday, bool byUnresolved)
            {
                this.byCurrentUser = byCurrentUser;
                this.byToday = byToday;
                this.byUnresolved = byUnresolved;

                if (!byCurrentUser & !byToday & !byUnresolved)
                    DisplayOption = CallDisplayOption.AllCalls;
                else if (!byCurrentUser & !byToday & byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsUnresolved;
                else if (!byCurrentUser & byToday & !byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsToday;
                else if (!byCurrentUser & byToday & byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsTodayUnresolved;
                else if (byCurrentUser & !byToday & !byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsCurrentUser;
                else if (byCurrentUser & !byToday & byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsCurrentUserUnresolved;
                else if (byCurrentUser & byToday & !byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsTodayCurrentUser;
                else if (byCurrentUser & byToday & byUnresolved)
                    DisplayOption = CallDisplayOption.AllCallsTodayCurrentUserUnresolved;
                else
                    DisplayOption = CallDisplayOption.None;
            }
        }
    }

    /// <summary>
    /// Extension class used for enums to get a description string.
    /// </summary>
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this ValidatorError val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static string ToDescriptionString(this CallDisplayOption val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
