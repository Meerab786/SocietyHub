using DB_Final.BL;
using DB_Final.DL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class FeedbackDL
    {
        public void Insert(Feedback f)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertFeedback, conn);
                    cmd.Parameters.AddWithValue("@rating", f.Rating);
                    cmd.Parameters.AddWithValue("@comment", f.Comment ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@submittedAt", f.SubmittedAt);
                    cmd.Parameters.AddWithValue("@eventId", f.Event != null ? (object)f.Event.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@studentId", f.Student != null ? (object)f.Student.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Logger.LogError("FeedbackDL.Insert", ex);
                 
            }
        }
        public void Update(Feedback f)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateFeedback, conn);
                    cmd.Parameters.AddWithValue("@id", f.Id);
                    cmd.Parameters.AddWithValue("@rating", f.Rating);
                    cmd.Parameters.AddWithValue("@comment", f.Comment ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@submittedAt", f.SubmittedAt);
                    cmd.Parameters.AddWithValue("@eventId", f.Event != null ? (object)f.Event.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@studentId", f.Student != null ? (object)f.Student.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Logger.LogError("FeedbackDL.Update", ex);
                 
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteFeedback, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Logger.LogError("FeedbackDL.Delete", ex);
                 
            }
        }
        public Feedback GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetFeedbackById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int rating = (int)reader["rating"];
                        string comment = reader["comment"] == DBNull.Value ? null : reader["comment"].ToString();
                        DateTime submittedAt = (DateTime)reader["submittedAt"];
                        int stuId = reader["studentId"] == DBNull.Value ? 0 : (int)reader["studentId"];
                        int evId = reader["eventId"] == DBNull.Value ? 0 : (int)reader["eventId"];
                        reader.Close();
                        StudentDL sdl = new StudentDL();
                        EventDL edl = new EventDL();
                        Student stu = stuId != 0 ? sdl.GetById(stuId) : null;
                        Event ev = evId != 0 ? edl.GetById(evId) : null;
                        return new Feedback(id, rating, comment, submittedAt, stu, ev);
                    }
                    return null;
                }
            }
            catch(Exception ex)
            {
                Logger.LogError("FeedbackDL.GetById", ex);
                return null;
            }
        }

        public List<Feedback> GetAll()
        {
            try {
                List<Feedback> list = new List<Feedback>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllFeedbacks, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<(int id, int rating, string comment, DateTime sa, int stuId, int evId)> rows
                        = new List<(int, int, string, DateTime, int, int)>();
                    while (reader.Read())
                    {
                        rows.Add((
                            (int)reader["id"],
                            (int)reader["rating"],
                            reader["comment"] == DBNull.Value ? null : reader["comment"].ToString(),
                            (DateTime)reader["submittedAt"],
                            reader["studentId"] == DBNull.Value ? 0 : (int)reader["studentId"],
                            reader["eventId"] == DBNull.Value ? 0 : (int)reader["eventId"]
                        ));
                    }
                    reader.Close();
                    foreach (var row in rows)
                    {
                        StudentDL sdl = new StudentDL();
                        EventDL edl = new EventDL();
                        Student stu = row.stuId != 0 ? sdl.GetById(row.stuId) : null;
                        Event ev = row.evId != 0 ? edl.GetById(row.evId) : null;
                        list.Add(new Feedback(row.id, row.rating, row.comment, row.sa, stu, ev));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("FeedbackDL.GetAll", ex);
                return new List<Feedback>();
            }
        }

        public List<Feedback> GetsAll()
        {
            List<Feedback> list = new List<Feedback>();

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllFeedbacks, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Create instances of your Data Logic layers outside the loop
                    StudentDL sdl = new StudentDL();
                    EventDL edl = new EventDL();

                    // Temporary list to hold raw database rows safely
                    var rawRows = new List<(int id, int rating, string comment, DateTime sa, int stuId, int evId)>();

                    while (reader.Read())
                    {
                        rawRows.Add((
                            Convert.ToInt32(reader["id"]),
                            Convert.ToInt32(reader["rating"]),
                            reader["comment"] == DBNull.Value ? "" : reader["comment"].ToString(),
                            Convert.ToDateTime(reader["submittedAt"]),
                            reader["studentId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["studentId"]),
                            reader["eventId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["eventId"])
                        ));
                    }
                    reader.Close(); // Always close the reader before moving to secondary queries

                    // Map the objects using your reliable, pre-existing .GetById() methods
                    foreach (var row in rawRows)
                    {
                        // If ID is valid, use your working DL methods; otherwise, keep it null
                        Student stu = (row.stuId != 0) ? sdl.GetById(row.stuId) : null;
                        Event ev = (row.evId != 0) ? edl.GetById(row.evId) : null;

                        list.Add(new Feedback(row.id, row.rating, row.comment, row.sa, stu, ev));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("FeedbackDL.GetsAll", ex);
                System.Windows.Forms.MessageBox.Show("Database Error: " + ex.Message);
            }

            return list;
        }
    }
}
