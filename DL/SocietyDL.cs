using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class SocietyDL
    {
        public void Insert(Society s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertSociety, conn);

                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.Parameters.AddWithValue("@foundedDate", s.FoundedDate);
                    cmd.Parameters.AddWithValue("@description", s.Description);
                    cmd.Parameters.AddWithValue("@categoryId", s.Category.Id);
                    cmd.Parameters.AddWithValue("@logoPath", s.LogoPath);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyDL.Insert", ex);

            }
        }
        public void Update(Society s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateSociety, conn);
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.Parameters.AddWithValue("@foundedDate", s.FoundedDate);
                    cmd.Parameters.AddWithValue("@description", s.Description);
                    cmd.Parameters.AddWithValue("@categoryId", s.Category != null ? (object)s.Category.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@logoPath", s.LogoPath);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyDL.Update", ex);

            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteSociety, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyDL.Delete", ex);

            }
        }

        public Society GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetSocietyById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        string description = reader["description"].ToString();
                        DateTime foundedDate = (DateTime)reader["foundedDate"];
                        string status = reader["status"].ToString();
                        int catId = reader["categoryId"] == DBNull.Value ? 0 : (int)reader["categoryId"];
                        reader.Close();
                        SocietyCategoryDL scdl = new SocietyCategoryDL();
                        SocietyCategory cat = catId != 0 ? scdl.GetById(catId) : null;
                        return new Society(id, name, description, foundedDate, cat, status);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyDL.GetById", ex);
                return null;
            }
        }

        public List<Society> GetAll()
        {
            List<Society> list = new List<Society>();

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllSocieties, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string name = reader["name"]?.ToString() ?? "";
                        string status = reader["status"]?.ToString() ?? "";

                        // Safe handling for NULL foundedDate
                        DateTime date = reader["foundedDate"] == DBNull.Value
                            ? DateTime.MinValue
                            : Convert.ToDateTime(reader["foundedDate"]);

                        string desc = reader["description"]?.ToString() ?? "";

                        SocietyCategory cat = null;
                        if (reader["categoryId"] != DBNull.Value)
                        {
                            // Check if 'categoryName' exists in your SELECT query alias
                            string catName = reader["categoryName"]?.ToString() ?? "";
                            cat = new SocietyCategory(Convert.ToInt32(reader["categoryId"]), catName, "");
                        }

                        list.Add(new Society(id, name, desc, date, cat, status));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyDL.GetAll", ex);
            }
            return list;
        }
    }
}
