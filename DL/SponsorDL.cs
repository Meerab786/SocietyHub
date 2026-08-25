using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class SponsorDL
    {
        public void Insert(Sponsor s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertSponsor, conn);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@organization", s.Organization);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@phone", s.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorDL.Insert", ex);
                
            }
        }
        public void Update(Sponsor s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateSponsor, conn);
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@organization", s.Organization);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@phone", s.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorDL.Update", ex);
                
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteSponsor, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorDL.Delete", ex);
                 
            }
        }
        public Sponsor GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetSponsorById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Sponsor(id, reader["name"].ToString(), reader["organization"].ToString(), reader["email"].ToString(), reader["phone"].ToString());
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorDL.GetById", ex);
                return null;
            }
        }

        public List<Sponsor> GetAll()
        {
            try
            {
                List<Sponsor> sponsors = new List<Sponsor>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllSponsors, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sponsors.Add(new Sponsor((int)reader["id"], reader["name"].ToString(), reader["organization"].ToString(), reader["email"].ToString(), reader["phone"].ToString()));
                    }
                }
                return sponsors;
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorDL.GetAll", ex);
                return null;
            }
        }
    }
}