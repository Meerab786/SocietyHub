using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Final.BL;

namespace DB_Final.DL
{
    public class SocietyCategoryDL
    {
        public void Insert(SocietyCategory sc)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertSocietyCategory, conn);
                    cmd.Parameters.AddWithValue("@name", sc.Name);
                    cmd.Parameters.AddWithValue("@description", sc.Description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyCategoryDL.Insert", ex);
                 
            }
        }

        public void Update(SocietyCategory sc)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateSocietyCategory, conn);
                    cmd.Parameters.AddWithValue("@id", sc.Id);
                    cmd.Parameters.AddWithValue("@name", sc.Name);
                    cmd.Parameters.AddWithValue("@description", sc.Description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyCategoryDL.Update", ex);
                
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteSocietyCategory, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyCategoryDL.Delete", ex);
                 
            }
        }

        public SocietyCategory GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetSocietyCategoryById, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new SocietyCategory(id, reader["name"].ToString(), reader["description"].ToString());
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyCategoryDL.GetById", ex);
                return null;
            }
        }
        public List<SocietyCategory> GetAll()
        {
            try
            {
                List<SocietyCategory> list = new List<SocietyCategory>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM societycategory", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new SocietyCategory(
                            (int)reader["id"],
                            reader["name"].ToString(),
                            reader["description"].ToString()
                        ));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("SocietyCategoryDL.GetAll", ex);
                return null;
            }
        }
    }
}
