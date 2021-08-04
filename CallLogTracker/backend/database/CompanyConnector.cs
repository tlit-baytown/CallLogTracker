using CallLogTracker.backend.database.wrappers;
using CallLogTracker.utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using static CallLogTracker.backend.Enums;

namespace CallLogTracker.backend.database
{
    public class CompanyConnector
    {
        /// <summary>
        /// Checks if the specified companyName exists in the Company table.
        /// </summary>
        /// <param name="companyName">The name of the company to search for.</param>
        /// <returns>True if the company already exists; False otherwise</returns>
        public static bool DoesCompanyExist(string companyName)
        {
            bool companyExists = false;
            string q = Queries.BuildQuery(QType.SELECT, "Company", null, new ArrayList { "name" }, $"name='{companyName}'");

            using (MySqlConnection con = Database.GetConnection())
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(q, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            companyExists = true;
                        }
                    }
                }
                con.Close();
            }
            return companyExists;
        }

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
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetCompany(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return c;
        }

        public static SortableBindingList<Company> GetCompanies()
        {
            SortableBindingList<Company> companies = new SortableBindingList<Company>();
            string q = Queries.BuildQuery(QType.SELECT, "Company");

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
                                    Company c = new Company
                                    {
                                        ID = reader.GetInt32(0),
                                        Name = reader.GetString(1),
                                        Phone = reader.GetString(2),
                                        SupportEmail = reader.GetString(3),
                                        NumOfEmployees = reader.GetInt32(4)
                                    };
                                    companies.Add(c);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in GetCompanies(): {e.Message}");
                            }
                        }
                    }
                }
                con.Close();
            }
            return companies;
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
                    Console.WriteLine($"{DateTime.Now.ToLocalTime()} -> An exception has occured in DeleteCompany(): {ex.Message}");
                    con.Close();
                    return false;
                }
            }
            return affectedRows != 0;
        }
    }
}
