using CallLogTracker.backend.database.wrappers;
using CallLogTracker.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CallLogTracker.backend.Enums;

namespace CallLogTracker.backend.database
{
    public class UserConnector
    {
        /// <summary>
        /// Checks if the specified username exists in the User table.
        /// </summary>
        /// <param name="username">The username of the person to search for</param>
        /// <returns>True if the username already exists; False otherwise</returns>
        public static bool DoesUserExist(string username)
        {
            bool userExists = false;
            string q = Queries.BuildQuery(QType.SELECT, "User", null, new ArrayList { "username" }, $"username='{username}'");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            userExists = true;
                        }
                    }
                }
                con.Close();
            }
            return userExists;
        }

        /// <summary>
        /// Query the database for the User object specified by their username.
        /// </summary>
        /// <param name="username">The username of the person to search for</param>
        /// <returns>
        ///     <list type="bullet">
        ///     <item>A <see cref="User"/> object</item>
        ///     <item>If no user was found with the username, the <see cref="User"/> object will be null.</item>
        ///     </list>
        /// </returns>
        public static User GetUser(string username)
        {
            User u = null;
            string q = Queries.BuildQuery(QType.SELECT, "User", null, null, $"username='{username}'");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                reader.Read();
                                u = new User
                                {
                                    ID = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    PhoneNumber = reader.GetString(3),
                                    AssociatedCompany = reader.GetInt32(4),
                                    Password = reader.GetString(5),
                                    Name = reader.GetString(6)
                                };
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetUser(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return u;
        }

        public static User GetUser(int id)
        {
            User u = null;
            string q = Queries.BuildQuery(QType.SELECT, "User", null, null, $"user_id={id}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                reader.Read();
                                u = new User
                                {
                                    ID = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    PhoneNumber = reader.GetString(3),
                                    AssociatedCompany = reader.GetInt32(4),
                                    Password = reader.GetString(5),
                                    Name = reader.GetString(6)
                                };
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetUser(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return u;
        }

        /// <summary>
        /// Get a <see cref="SortableBindingList{T}"/> of all the users currently in the database.
        /// </summary>
        /// <returns>
        /// <list type="bullet">
        ///     <item>A <see cref="SortableBindingList{T}"/> of users</item>
        ///     <item>If no users, an empty list is returned.</item>
        /// </list>
        /// </returns>
        public static SortableBindingList<User> GetUsers()
        {
            SortableBindingList<User> users = new SortableBindingList<User>();
            string q = Queries.BuildQuery(QType.SELECT, "User");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    reader.Read();
                                    User u = new User
                                    {
                                        ID = reader.GetInt32(0),
                                        Username = reader.GetString(1),
                                        Email = reader.GetString(2),
                                        PhoneNumber = reader.GetString(3),
                                        AssociatedCompany = reader.GetInt32(4),
                                        Password = reader.GetString(5),
                                        Name = reader.GetString(6)
                                    };
                                    users.Add(u);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetUsers(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return users;
        }

        /// <summary>
        /// Get a <see cref="SortableBindingList{T}"/> of all the users currently in the database.
        /// </summary>
        /// <param name="companyID">The id of the company to get users for.</param>
        /// <returns>
        /// <list type="bullet">
        ///     <item>A <see cref="SortableBindingList{T}"/> of users</item>
        ///     <item>If no users, an empty list is returned.</item>
        /// </list>
        /// </returns>
        public static SortableBindingList<User> GetUsers(int companyID)
        {
            SortableBindingList<User> users = new SortableBindingList<User>();
            string q = Queries.BuildQuery(QType.SELECT, "User", null, null, $"associated_company={companyID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            try
                            {
                                while (reader.Read())
                                {
                                    reader.Read();
                                    User u = new User
                                    {
                                        ID = reader.GetInt32(0),
                                        Username = reader.GetString(1),
                                        Email = reader.GetString(2),
                                        PhoneNumber = reader.GetString(3),
                                        AssociatedCompany = reader.GetInt32(4),
                                        Password = reader.GetString(5),
                                        Name = reader.GetString(6)
                                    };
                                    users.Add(u);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetUsers(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return users;
        }

        /// <summary>
        /// Attempts to insert a new record into the User table. If the insert could not be completed, the transaction is rolled back
        /// and no data is committed to the database.
        /// </summary>
        /// <param name="u">The <see cref="User"/> object to insert</param>
        /// <returns>True if the record inserted successfully; False otherwise</returns>
        public static int InsertUser(User u)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("User");
            columns.RemoveAt(0); //remove the id column
            columns.TrimToSize(); //trim the arraylist after index removal
            string q = Queries.BuildQuery(QType.INSERT, "User", null, columns);

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", u.Username);
                        cmd.Parameters.AddWithValue("@1", u.Email);
                        cmd.Parameters.AddWithValue("@2", u.PhoneNumber);
                        cmd.Parameters.AddWithValue("@3", u.AssociatedCompany);
                        cmd.Parameters.AddWithValue("@4", u.Password);
                        cmd.Parameters.AddWithValue("@5", u.Name);

                        cmd.Connection = con;
                        affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            tr.Commit();
                        }
                        else
                        {
                            tr.Rollback();
                        }
                    }
                }
                con.Close();
            }
            return affectedRows != 0 ? Database.GetLastRowIDInserted("User") : 0;
        }

        /// <summary>
        /// Attempts to update the specified user object in the User table. If the update could not be completed, the transaction is rolled back
        /// and no data is committed to the database.
        /// </summary>
        /// <param name="u">The <see cref="User"/> object to update</param>
        /// <returns>True if the record was updated succesfully; False otherwise</returns>
        public static bool UpdateUser(User u)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("User");
            string q = Queries.BuildQuery(QType.UPDATE, "User", null, columns, $"user_id={u.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", u.ID);
                        cmd.Parameters.AddWithValue("@1", u.Username);
                        cmd.Parameters.AddWithValue("@2", u.Email);
                        cmd.Parameters.AddWithValue("@3", u.PhoneNumber);
                        cmd.Parameters.AddWithValue("@4", u.AssociatedCompany);
                        cmd.Parameters.AddWithValue("@5", u.Password);
                        cmd.Parameters.AddWithValue("@6", u.Name);

                        cmd.Connection = con;
                        affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            tr.Commit();
                        }
                        else
                        {
                            tr.Rollback();
                        }
                    }
                }
                con.Close();
            }
            return affectedRows != 0;
        }

        public static bool DeleteUser(User u)
        {
            int affectedRows = 0;
            string q = Queries.BuildQuery(QType.DELETE, "User", null, null, $"user_id={u.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlTransaction tr = con.BeginTransaction())
                        {
                            cmd.CommandText = q;
                            cmd.Transaction = tr;
                            cmd.Connection = con;
                            affectedRows += cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                tr.Commit();
                            }
                            else
                            {
                                tr.Rollback();
                            }
                        }
                    }

                    con.Close();
                    return affectedRows != 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in DeleteUser(): {ex.Message}");
                    con.Close();
                    return false;
                }
            }
        }
    }
}
