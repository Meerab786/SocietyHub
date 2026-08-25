using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class EventRegistrationDL
    {
        public void Insert(EventRegistration er)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertEventRegistration, conn);
                    cmd.Parameters.AddWithValue("@registrationDate", er.RegistrationDate);
                    cmd.Parameters.AddWithValue("@status", er.Status);
                    cmd.Parameters.AddWithValue("@cancellationDate", er.CancellationDate.HasValue ? (object)er.CancellationDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@cancellationReason", er.CancellationReason ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@studentId", er.Student != null ? (object)er.Student.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@eventId", er.Event != null ? (object)er.Event.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventRegistrationDL.Insert", ex);
                
            }
        }
        public void Update(EventRegistration er)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateEventRegistration, conn);
                    cmd.Parameters.AddWithValue("@id", er.Id);
                    cmd.Parameters.AddWithValue("@registrationDate", er.RegistrationDate);
                    cmd.Parameters.AddWithValue("@status", er.Status);
                    cmd.Parameters.AddWithValue("@cancellationDate", er.CancellationDate.HasValue ? (object)er.CancellationDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@cancellationReason", er.CancellationReason ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@studentId", er.Student != null ? (object)er.Student.Id : DBNull.Value);
                    cmd.Parameters.AddWithValue("@eventId", er.Event != null ? (object)er.Event.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventRegistrationDL.Update", ex);
                
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteEventRegistration, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventRegistrationDL.Delete", ex);
                 
            }
        }
        public EventRegistration GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetEventRegistrationById, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime regDate = (DateTime)reader["registrationDate"];
                        string status = reader["status"].ToString();
                        DateTime? cancelDate = reader["cancellationDate"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["cancellationDate"];
                        string cancelReason = reader["cancellationReason"] == DBNull.Value ? null : reader["cancellationReason"].ToString();
                        int stuId = reader["studentId"] == DBNull.Value ? 0 : (int)reader["studentId"];
                        int evId = reader["eventId"] == DBNull.Value ? 0 : (int)reader["eventId"];
                        reader.Close();
                        StudentDL sdl = new StudentDL();
                        EventDL edl = new EventDL();
                        Student stu = stuId != 0 ? sdl.GetById(stuId) : null;
                        Event ev = evId != 0 ? edl.GetById(evId) : null;
                        return new EventRegistration(id, regDate, status, cancelDate, cancelReason, stu, ev);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("EventRegistrationDL.GetById", ex);
                return null;
            }
        }

        public List<EventRegistration> GetAll()
        {
            try
            {
                List<EventRegistration> list = new List<EventRegistration>();

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(DatabaseScripts.GetAllEventRegistrations, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    List<(int id,
                          DateTime regDate,
                          string status,
                          DateTime? cancelDate,
                          string cancelReason,
                          int studentId,
                          int eventId)> rows
                        = new List<(int, DateTime, string, DateTime?, string, int, int)>();

                    while (reader.Read())
                    {
                        rows.Add((
                            Convert.ToInt32(reader["id"]),
                            Convert.ToDateTime(reader["registrationDate"]),
                            reader["status"].ToString(),
                            reader["cancellationDate"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(reader["cancellationDate"]),
                            reader["cancellationReason"] == DBNull.Value
                                ? null
                                : reader["cancellationReason"].ToString(),
                            Convert.ToInt32(reader["studentId"]),
                            Convert.ToInt32(reader["eventId"])
                        ));
                    }

                    reader.Close();

                    StudentDL sdl = new StudentDL();
                    EventDL edl = new EventDL();

                    foreach (var row in rows)
                    {
                        Student stu = sdl.GetById(row.studentId);
                        Event ev = edl.GetById(row.eventId);

                        list.Add(
                            new EventRegistration(
                                row.id,
                                row.regDate,
                                row.status,
                                row.cancelDate,
                                row.cancelReason,
                                stu,
                                ev
                            )
                        );
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("EventRegistrationDL.GetAll", ex);
                return null;
            }
        }
        public List<EventRegistration> GetByEventId(int eventId)
        {
            return GetAll().Where(r => r.Event != null && r.Event.Id == eventId).ToList();
        }
    }
}

