using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class EventDL
    {
        public void Insert(Event e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertEvent, conn);
                    cmd.Parameters.AddWithValue("@status", e.Status);
                    cmd.Parameters.AddWithValue("@description", e.Description);
                    cmd.Parameters.AddWithValue("@capacity", e.Capacity);
                    cmd.Parameters.AddWithValue("@title", e.Title);
                    cmd.Parameters.AddWithValue("@eventDatetime", e.EventDateTime);
                    cmd.Parameters.AddWithValue("@societyId", e.Society != null ? (object)e.Society.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@venueId", e.Venue != null ? (object)e.Venue.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@categoryId", e.Category != null ? (object)e.Category.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventDL.Insert", ex);
                
            }
        }
        public void Update(Event e)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateEvent, conn);

                    cmd.Parameters.AddWithValue("@id", e.Id);
                    cmd.Parameters.AddWithValue("@title", e.Title);
                    cmd.Parameters.AddWithValue("@description", e.Description);
                    cmd.Parameters.AddWithValue("@capacity", e.Capacity);
                    cmd.Parameters.AddWithValue("@status", e.Status);
                    cmd.Parameters.AddWithValue("@eventDatetime", e.EventDateTime);
                    cmd.Parameters.AddWithValue("@societyId", e.Society.Id);
                    cmd.Parameters.AddWithValue("@venueId", e.Venue.Id);
                    cmd.Parameters.AddWithValue("@categoryId", e.Category.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventDL.Update", ex);
               
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteEvent, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventDL.Delete", ex);
                
            }
        }
        public Event GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetEventById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        string description = reader["description"].ToString();
                        int capacity = (int)reader["capacity"];
                        string title = reader["title"].ToString();
                        DateTime eventDatetime = (DateTime)reader["eventDatetime"];
                        int socId = reader["societyId"] == DBNull.Value ? 0 : (int)reader["societyId"];
                        int venId = reader["venueId"] == DBNull.Value ? 0 : (int)reader["venueId"];
                        int catId = reader["categoryId"] == DBNull.Value ? 0 : (int)reader["categoryId"];
                        reader.Close();
                        SocietyDL sdl = new SocietyDL();
                        VenueDL vdl = new VenueDL();
                        EventCategoryDL ecdl = new EventCategoryDL();
                        Society soc = socId != 0 ? sdl.GetById(socId) : null;
                        Venue ven = venId != 0 ? vdl.GetById(venId) : null;
                        EventCategory cat = catId != 0 ? ecdl.GetById(catId) : null;
                        return new Event(id, status, description, capacity, title, eventDatetime, soc, ven, cat);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventDL.GetById", ex);
                return null;
            }
        }

        public List<Event> GetAll()
        {
            try
            {
                List<Event> list = new List<Event>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllEvents, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<(int id, string status, string desc, int cap, string title, DateTime dt, int socId, int venId, int catId)> rows
                        = new List<(int, string, string, int, string, DateTime, int, int, int)>();
                    while (reader.Read())
                    {
                        rows.Add((
                            (int)reader["id"],
                            reader["status"].ToString(),
                            reader["description"].ToString(),
                            (int)reader["capacity"],
                            reader["title"].ToString(),
                            (DateTime)reader["eventDatetime"],
                            reader["societyId"] == DBNull.Value ? 0 : (int)reader["societyId"],
                            reader["venueId"] == DBNull.Value ? 0 : (int)reader["venueId"],
                            reader["categoryId"] == DBNull.Value ? 0 : (int)reader["categoryId"]
                        ));
                    }
                    reader.Close();
                    foreach (var row in rows)
                    {
                        SocietyDL sdl = new SocietyDL();
                        VenueDL vdl = new VenueDL();
                        EventCategoryDL ecdl = new EventCategoryDL();
                        Society soc = row.socId != 0 ? sdl.GetById(row.socId) : null;
                        Venue ven = row.venId != 0 ? vdl.GetById(row.venId) : null;
                        EventCategory cat = row.catId != 0 ? ecdl.GetById(row.catId) : null;
                        list.Add(new Event(row.id, row.status, row.desc, row.cap, row.title, row.dt, soc, ven, cat));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("EventDL.GetAll", ex);
                return null;
            }
        }
    }
}

