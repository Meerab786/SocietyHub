using DB_Final.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DB_Final.DL
{
    public class VenueDL
    {
        public void Insert(Venue v)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertVenue, conn);
                    cmd.Parameters.AddWithValue("@name", v.Name);
                    cmd.Parameters.AddWithValue("@location", v.Location);
                    cmd.Parameters.AddWithValue("@capacity", v.Capacity);
                    cmd.Parameters.AddWithValue("@facilities", v.Facilities);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("VenueDL.Insert", ex);
                 
            }
        }
        public void Update(Venue v)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateVenue, conn);
                    cmd.Parameters.AddWithValue("@id", v.Id);
                    cmd.Parameters.AddWithValue("@name", v.Name);
                    cmd.Parameters.AddWithValue("@location", v.Location);
                    cmd.Parameters.AddWithValue("@capacity", v.Capacity);
                    cmd.Parameters.AddWithValue("@facilities", v.Facilities);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("VenueDL.Update", ex);
                
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteVenue, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("VenueDL.Delete", ex);
                
            }
        }
        public Venue GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetVenueById, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Venue(id, reader["name"].ToString(), reader["location"].ToString(), (int)reader["capacity"], reader["facilities"].ToString());
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("VenueDL.GetById", ex);
                return null;
            }
        }
        public List<Venue> GetAll()
        {
            try
            {
                List<Venue> venues = new List<Venue>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllVenues, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        venues.Add(new Venue((int)reader["id"], reader["name"].ToString(), reader["location"].ToString(), (int)reader["capacity"], reader["facilities"].ToString()));
                    }
                }
                return venues;
            }
            catch (Exception ex)
            {
                Logger.LogError("VenueDL.GetAll", ex);
                return null;
            }
        }
    }
}
