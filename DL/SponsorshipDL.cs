using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class SponsorshipDL
    {
        public void Insert(Sponsorship sp)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertSponsorship, conn);
                    cmd.Parameters.AddWithValue("@amount", sp.Amount);
                    cmd.Parameters.AddWithValue("@sponsorshipDate", sp.SponsorshipDate);
                    cmd.Parameters.AddWithValue("@sponsorId", sp.Sponsor != null ? (object)sp.Sponsor.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@eventId", sp.Event != null ? (object)sp.Event.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorshipDL.Insert", ex);
                 
            }
        }
        public void Update(Sponsorship sp)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateSponsorship, conn);
                    cmd.Parameters.AddWithValue("@id", sp.Id);
                    cmd.Parameters.AddWithValue("@amount", sp.Amount);
                    cmd.Parameters.AddWithValue("@sponsorshipDate", sp.SponsorshipDate);
                    cmd.Parameters.AddWithValue("@sponsorId", sp.Sponsor != null ? (object)sp.Sponsor.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@eventId", sp.Event != null ? (object)sp.Event.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorshipDL.Update", ex);
                 
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteSponsorship, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorshipDL.Delete", ex);
                
            }
        }
        public Sponsorship GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetSponsorshipById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        decimal amount = (decimal)reader["amount"];
                        DateTime sponsorshipDate = (DateTime)reader["sponsorshipDate"];
                        int sponId = reader["sponsorId"] == DBNull.Value ? 0 : (int)reader["sponsorId"];
                        int evId = reader["eventId"] == DBNull.Value ? 0 : (int)reader["eventId"];
                        reader.Close();
                        SponsorDL spdl = new SponsorDL();
                        EventDL edl = new EventDL();
                        Sponsor spon = sponId != 0 ? spdl.GetById(sponId) : null;
                        Event ev = evId != 0 ? edl.GetById(evId) : null;
                        return new Sponsorship(id, amount, sponsorshipDate, spon, ev);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorshipDL.GetById", ex);
                return null;
            }
        }

        public List<Sponsorship> GetAll()
        {
            try
            {
                List<Sponsorship> list = new List<Sponsorship>();

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(DatabaseScripts.GetAllSponsorships, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    SponsorDL sponsorDL = new SponsorDL();
                    EventDL eventDL = new EventDL();

                    while (reader.Read())
                    {
                        int id =
                            Convert.ToInt32(reader["id"]);

                        decimal amount =
                            Convert.ToDecimal(reader["amount"]);

                        DateTime date =
                            Convert.ToDateTime(
                                reader["sponsorshipDate"]);

                        int sponsorId =
                            reader["sponsorId"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["sponsorId"]);

                        int eventId =
                            reader["eventId"] == DBNull.Value
                            ? 0
                            : Convert.ToInt32(reader["eventId"]);

                        Sponsor sponsor =
                            sponsorId > 0
                            ? sponsorDL.GetById(sponsorId)
                            : null;

                        Event ev =
                            eventId > 0
                            ? eventDL.GetById(eventId)
                            : null;

                        list.Add(
                            new Sponsorship(
                                id,
                                amount,
                                date,
                                sponsor,
                                ev));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("SponsorshipDL.GetAll", ex);
                return null;
            }
        }

    }
}
