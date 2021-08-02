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
    public class CallConnector
    {
        public static Call GetCall(int id)
        {
            Call c = null;
            string q = Queries.BuildQuery(Enums.QType.SELECT, "Call", null, null, $"call_id={id}");

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
                                c = new Call
                                {
                                    ID = reader.GetInt32(0),
                                    CompanyID = reader.GetInt32(1),
                                    UserID = reader.GetInt32(2),
                                    CallerName = reader.GetString(3),
                                    CallerPhone = reader.GetString(4),
                                    Message = reader.GetString(6),
                                    Timestamp = reader.GetDateTime(7)
                                };
                                if (reader.IsDBNull(5))
                                    c.CallerEmail = "N/A";
                                else
                                    c.CallerEmail = reader.GetString(5);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetCall(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return c;
        }

        public static SortableBindingList<Call> GetCallsForToday()
        {
            SortableBindingList<Call> calls = new SortableBindingList<Call>();
            if (Global.Instance.CurrentUser == null || Global.Instance.CurrentCompany == null)
            {
                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> : User or company was null while attempting to fetch calls. Returning an empty list...");
                return calls;
            }

            string q = $"SELECT * FROM Call WHERE date='{DateTime.Now.Date}' AND " +
                $"(user_id={Global.Instance.CurrentUser.ID} AND " +
                $"company_id={Global.Instance.CurrentCompany.ID});";

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
                                Call c = new Call
                                {
                                    ID = reader.GetInt32(0),
                                    CompanyID = reader.GetInt32(1),
                                    UserID = reader.GetInt32(2),
                                    CallerName = reader.GetString(3),
                                    CallerPhone = reader.GetString(4),
                                    Message = reader.GetString(6),
                                    Date = reader.GetDateTime(7),
                                    Timestamp = reader.GetDateTime(8)
                                };
                                if (reader.IsDBNull(5))
                                    c.CallerEmail = "N/A";
                                else
                                    c.CallerEmail = reader.GetString(5);

                                calls.Add(c);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetCallsForToday(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return calls;
        }

        public static int InsertCall(Call c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Call");
            columns.RemoveAt(0);
            columns.TrimToSize();
            string q = Queries.BuildQuery(Enums.QType.INSERT, "Call", null, columns);

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", c.CompanyID);
                        cmd.Parameters.AddWithValue("@1", c.UserID);
                        cmd.Parameters.AddWithValue("@2", c.CallerName);
                        cmd.Parameters.AddWithValue("@3", c.CallerPhone);
                        cmd.Parameters.AddWithValue("@4", c.CallerEmail);
                        cmd.Parameters.AddWithValue("@5", c.Message);
                        cmd.Parameters.AddWithValue("@6", c.Timestamp);

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
            return affectedRows != 0 ? Database.GetLastRowIDInserted("Call") : 0;
        }

        public static bool UpdateCall(Call c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Call");
            string q = Queries.BuildQuery(QType.UPDATE, "Call", null, columns, $"call_id={c.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", c.ID);
                        cmd.Parameters.AddWithValue("@1", c.CompanyID);
                        cmd.Parameters.AddWithValue("@2", c.UserID);
                        cmd.Parameters.AddWithValue("@3", c.CallerName);
                        cmd.Parameters.AddWithValue("@4", c.CallerPhone);
                        cmd.Parameters.AddWithValue("@5", c.CallerEmail);
                        cmd.Parameters.AddWithValue("@6", c.Message);
                        cmd.Parameters.AddWithValue("@7", c.Timestamp);

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

        public static bool DeleteCall(Call c)
        {
            int affectedRows = 0;
            string q = Queries.BuildQuery(QType.DELETE, "Call", null, null, $"call_id={c.ID}");

            using (MySqlConnection con = Database.GetConnection())
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlTransaction tr = con.BeginTransaction())
                        {
                            cmd.CommandText = q;
                            cmd.Transaction = tr;
                            cmd.Connection = con;
                            affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                                tr.Commit();
                            else
                                tr.Rollback();
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in DeleteCall(): {ex.Message}");
                    con.Close();
                    return false;
                }
            }

            return affectedRows != 0;
        }
    }
}
