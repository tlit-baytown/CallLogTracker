using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.utility
{
    public class Enums
    {
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
            [Description("The email address entered is incomplete or is not in the correct format.")]
            InvalidEmailAddress,
            [Description("The email address cannot be empty.")]
            NoLengthEmailAddress,
            [Description("The email address cannot be \"N/A\".")]
            EmailNA,
            [Description("The employee's phone number was incomplete or not in a valid format.\n")]
            User_InvalidPhone,
            [Description("The employee's password must be between 6 and 24 characters.\n")]
            User_InvalidPassword,
            [Description("The password must contain at least 1 special character.")]
            Password_NumOfSpecials,
            [Description("The password must contain at least 1 digit.")]
            Password_NumOfDigits,
            [Description("The employee has no company associated with them. Select a company and try again.\n")]
            User_InvalidCompany,
            [Description("An exception occured while trying to validate the input. Please try again.")]
            Exception,
            [Description("No error has occured and all validation succeeded.")]
            None
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
    }
}
