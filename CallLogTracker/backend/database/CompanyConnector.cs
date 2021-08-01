using CallLogTracker.backend.database.wrappers;
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
    public class CompanyConnector
    {
        public static Company GetCompany(int id)
        {
            Company c = null;
            string q = Queries.BuildQuery(Enums.QType.SELECT, "Company", null, null, $"company_id={id}");

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
                                c = new Company
                                {
                                    ID = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Phone = reader.GetString(2),
                                    SupportEmail = reader.GetString(3),
                                    NumOfEmployees = reader.GetInt32(4)
                                };
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"An exception has occured in GetCompany(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return c;
        }

        public static int InsertCompany(Company c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Company");
            columns.RemoveAt(0);
            columns.TrimToSize();
            string q = Queries.BuildQuery(QType.INSERT, "Company", null, columns);

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        cmd.CommandText = q;
                        cmd.Transaction = tr;
                        cmd.Parameters.AddWithValue("@0", c.Name);
                        cmd.Parameters.AddWithValue("@1", c.Phone);
                        cmd.Parameters.AddWithValue("@2", c.SupportEmail);
                        cmd.Parameters.AddWithValue("@3", c.NumOfEmployees);

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
            return affectedRows != 0 ? Database.GetLastRowIDInserted("Company") : 0;
        }

        public static bool UpdateCompany(Company c)
        {
            int affectedRows = 0;
            ArrayList columns = Database.GetColumns("Company");
            string q = Queries.BuildQuery(QType.UPDATE, "Company", null, columns, $"company_id={c.ID}");

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
                        cmd.Parameters.AddWithValue("@1", c.Name);
                        cmd.Parameters.AddWithValue("@2", c.Phone);
                        cmd.Parameters.AddWithValue("@3", c.SupportEmail);
                        cmd.Parameters.AddWithValue("@4", c.NumOfEmployees);

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

        public static bool DeleteCompany(Company c)
        {
            int affectedRows = 0;
            string q = Queries.BuildQuery(QType.DELETE, "Company", null, null, $"company_id={c.ID}");

            try
            {
                using (MySqlConnection con = Database.GetConnection())
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
            }
            catch (Exception)
            {
                return false;
            }

            return affectedRows != 0;
        }
    }
}
