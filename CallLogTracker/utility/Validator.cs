using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CallLogTracker.utility.Enums;

namespace CallLogTracker.utility
{
    public class Validator
    {
        private static readonly string emailRegExPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                       + "@"
                                       + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";
        private static readonly string passwordSpecialChars = "!@#$%^&*()/-<,>.?;:'\"\\]}[{_+=`~";

        /// <summary>
        /// Validates an e-mail address against an email regular expression pattern.
        /// </summary>
        /// <param name="emailAddress">The email address to validate.</param>
        /// <returns>A list of <see cref="ValidatorError"/>s.</returns>
        public static List<ValidatorError> Email(string emailAddress)
        {
            List<ValidatorError> e = new List<ValidatorError>();

            if (emailAddress.Length <= 0)
                e.Add(ValidatorError.NoLengthEmailAddress);
            if (!Regex.IsMatch(emailAddress, emailRegExPattern))
                e.Add(ValidatorError.InvalidEmailAddress);
            if (emailAddress.ToLower().Equals("n/a"))
                e.Add(ValidatorError.EmailNA);

            return e;
        }

        public static List<ValidatorError> Password(string password)
        {
            List<ValidatorError> e = new List<ValidatorError>();

            int numOfSpecials = 0;
            int numOfDigits = 0;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    numOfDigits++;
                if (passwordSpecialChars.Contains(c))
                    numOfSpecials++;
            }

            if (numOfSpecials < 1)
                e.Add(ValidatorError.Password_NumOfSpecials);
            if (numOfDigits < 1)
                e.Add(ValidatorError.Password_NumOfDigits);

            if (password.Length < 6 || password.Length > 24)
                e.Add(ValidatorError.User_InvalidPassword);

            return e;
        }

        public static string ToRichText(List<ValidatorError> errors)
        {
            StringBuilder bldr = new StringBuilder();
            foreach (ValidatorError e in errors)
            {
                bldr.Append(e.ToDescriptionString()).Append("\n");
            }
            return bldr.ToString();
        }
    }
}
