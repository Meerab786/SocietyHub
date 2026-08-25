using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class AnnouncementDL
    {
        public void Insert(Announcement a)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertAnnouncement, conn);
                    cmd.Parameters.AddWithValue("@title", a.Title);
                    cmd.Parameters.AddWithValue("@message", a.Message);
                    cmd.Parameters.AddWithValue("@postedAt", a.PostedAt);
                    cmd.Parameters.AddWithValue("@societyId", a.Society.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("AnnouncementDL.Insert", ex);
               
            }
        }
        public void Update(Announcement a)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateAnnouncement, conn);
                    cmd.Parameters.AddWithValue("@id", a.Id);
                    cmd.Parameters.AddWithValue("@title", a.Title);
                    cmd.Parameters.AddWithValue("@message", a.Message);
                    cmd.Parameters.AddWithValue("@postedAt", a.PostedAt);
                    cmd.Parameters.AddWithValue("@societyId", a.Society.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("AnnouncementDL.Update", ex);
               
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteAnnouncement, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("AnnouncementDL.Delete", ex);
                
            }
        }
        public Announcement GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAnnouncementById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string title = reader["title"].ToString();
                        string message = reader["message"] == DBNull.Value ? null : reader["message"].ToString();
                        DateTime postedAt = (DateTime)reader["postedAt"];
                        int socId = reader["societyId"] == DBNull.Value ? 0 : (int)reader["societyId"];
                        reader.Close();
                        SocietyDL sdl = new SocietyDL();
                        Society soc = socId != 0 ? sdl.GetById(socId) : null;
                        return new Announcement(id, title, message, postedAt, soc);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("AnnouncementDL.GetById", ex);
                return null;
            }
        }

        public List<Announcement> GetAll()
        {
            try
            {
                List<Announcement> list = new List<Announcement>();

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(DatabaseScripts.GetAllAnnouncements, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    SocietyDL sdl = new SocietyDL();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);

                        string title = reader["title"].ToString();

                        string message = reader["message"] == DBNull.Value
                            ? null
                            : reader["message"].ToString();

                        DateTime postedAt =
                            Convert.ToDateTime(reader["postedAt"]);

                        int societyId = reader["societyId"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["societyId"]);

                        Society society =
                            societyId > 0 ? sdl.GetById(societyId) : null;

                        list.Add(new Announcement(
                            id,
                            title,
                            message,
                            postedAt,
                            society));
                    }

                    reader.Close();
                }

                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("AnnouncementDL.GetAll", ex);
                return null;
            }
        }

    }
}
