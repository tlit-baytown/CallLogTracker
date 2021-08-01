using System;
using System.Security.Cryptography;

namespace CallLogTracker.security
{
    /// <summary>
    /// This class handles passwords for the application. It is responsible for hashing passwords and authenticating passwords.
    /// <para>Using the method, <see cref="HashPassword(string)"/> a plain-text string can be turned into a hashed password.</para>
    /// <para>Using the method, <see cref="AuthenticatePassword(string, string)"/> a plain-text string can be compared against a hashed password for equality.</para>
    /// <para>To control the password strength, this class has private members for the <see cref="SALT_LENGTH"/>, <see cref="ITERATION_MAX"/>, and <see cref="ITERATION_MIN"/></para>
    /// <para>A password is hashed according to these private members and a <see cref="Random"/> object.</para>
    /// </summary>
    public class Hasher
    {
        private const int SALT_LENGTH = 64;
        private const int ITERATION_MIN = 500;
        private const int ITERATION_MAX = 2000;

        private static readonly Random random = new Random();

        /// <summary>
        ///Generates a new Hash for the specified password. The salt and iteration count for each password is random.
        ///</summary>
        ///<param name="password">The plain-text password to hash</param>
        ///<returns>A new hashed-version of the supplied password</returns>
        public static string HashPassword(string password)
        {
            RNGCryptoServiceProvider saltCellar = new RNGCryptoServiceProvider();
            byte[] salt = new byte[65];
            saltCellar.GetBytes(salt);

            Rfc2898DeriveBytes hashTool = new Rfc2898DeriveBytes(password, salt);
            int rNum = random.Next(ITERATION_MIN, ITERATION_MAX);
            hashTool.IterationCount = rNum;
            byte[] hash = hashTool.GetBytes(SALT_LENGTH);

            // The format that is stored in the database: IterationCount:Salt:HashedPassword
            string databaseStoredPassword = $"{rNum}:{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";

            return databaseStoredPassword;
        }

        /// <summary>
        ///Compares a non-hashed password against the hashed password from the database. Converts the non-hashed password
        /// into a hashed password and compares using XOR against the database password. If there are no differences, the password
        /// is the same and the user can be authenticated.
        ///</summary>
        ///<param name="password">The non-hashed, plain-text password to check</param>
        ///<param name="hashedPassword">The hashed password present in the database</param>
        ///<returns>True if the two passwords are the same; False if not.</returns>
        public static bool AuthenticatePassword(string password, string hashedPassword)
        {
            try
            {
                string[] hashParts = hashedPassword.Split(':');
                int iterations = Convert.ToInt32(hashParts[0]);
                byte[] originalSalt = Convert.FromBase64String(hashParts[1]);
                byte[] originalHash = Convert.FromBase64String(hashParts[2]);

                var hashTool = new Rfc2898DeriveBytes(password, originalSalt);
                hashTool.IterationCount = iterations;
                byte[] testHash = hashTool.GetBytes(originalHash.Length);

                // Compare the two passwords using XOR comparison
                var differences = Convert.ToUInt32(originalHash.Length) ^ System.Convert.ToUInt32(testHash.Length);

                // Iterate through the differences and ensure that each bit is equal
                for (var position = 0; position <= Math.Min(originalHash.Length, testHash.Length) - 1; position++)
                    differences |= Convert.ToUInt32(originalHash[position] ^ testHash[position]);

                // Returns True if each bit of the password matches each bit of the hashedPassword
                return differences == 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

