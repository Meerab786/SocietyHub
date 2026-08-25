using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class EventCategoryDL
    {
        public void Insert(EventCategory e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertEventCategory, conn);
                    cmd.Parameters.AddWithValue("@name", e.Name);
                    cmd.Parameters.AddWithValue("@description", e.Description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventCategoryDL.Insert", ex);
               
            }
        }
        public void Update(EventCategory e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateEventCategory, conn);
                    cmd.Parameters.AddWithValue("@id", e.Id);
                    cmd.Parameters.AddWithValue("@name", e.Name);
                    cmd.Parameters.AddWithValue("@description", e.Description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventCategoryDL.Update", ex);
             
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteEventCategory, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventCategoryDL.Delete", ex);
               
            }
        }

        public EventCategory GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetEventCategoryById, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new EventCategory(id, reader["name"].ToString(), reader["description"].ToString());
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventCategoryDL.GetById", ex);
                return null;
            }
        }
        public List<EventCategory> GetAll()
        {
            try
            {
                List<EventCategory> categories = new List<EventCategory>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllEventCategories, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categories.Add(new EventCategory((int)reader["id"], reader["name"].ToString(), reader["description"].ToString()));
                    }
                }
                return categories;
            }
            catch (Exception ex)
            {
                Logger.LogError("EventCategoryDL.GetAll", ex);
                return null;
            }
        }
    }
}
