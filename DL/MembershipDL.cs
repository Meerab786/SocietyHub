using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class MembershipDL
    {
        public void Insert(Membership m)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertMembership, conn);

                    cmd.Parameters.AddWithValue("@status", m.Status);
                    cmd.Parameters.AddWithValue("@joinDate", m.JoinDate);
                    cmd.Parameters.AddWithValue("@leaveDate",
                        m.LeaveDate.HasValue ? (object)m.LeaveDate.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@studentId",
                        m.Student != null ? (object)m.Student.Id : DBNull.Value);

                    cmd.Parameters.AddWithValue("@societyId",
                        m.Society != null ? (object)m.Society.Id : DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("MembershipDL.Insert", ex);
            
            }
        }

        public void Update(Membership m)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateMembership, conn);

                    cmd.Parameters.AddWithValue("@id", m.Id);
                    cmd.Parameters.AddWithValue("@status", m.Status);
                    cmd.Parameters.AddWithValue("@joinDate", m.JoinDate);
                    cmd.Parameters.AddWithValue("@leaveDate",
                        m.LeaveDate.HasValue ? (object)m.LeaveDate.Value : DBNull.Value);

                    cmd.Parameters.AddWithValue("@studentId",
                        m.Student != null ? (object)m.Student.Id : DBNull.Value);

                    cmd.Parameters.AddWithValue("@societyId",
                        m.Society != null ? (object)m.Society.Id : DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("MembershipDL.Update", ex);
                 
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteMembership, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("MembershipDL.Delete", ex);
                
            }
        }

        public Membership GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetMembershipById, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        DateTime joinDate = Convert.ToDateTime(reader["joinDate"]);

                        DateTime? leaveDate =
                            reader["leaveDate"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["leaveDate"]);

                        int studentId = Convert.ToInt32(reader["studentId"]);
                        int societyId = Convert.ToInt32(reader["societyId"]);

                        reader.Close();

                        StudentDL sdl = new StudentDL();
                        SocietyDL sodl = new SocietyDL();

                        Student student = sdl.GetById(studentId);
                        Society society = sodl.GetById(societyId);

                        return new Membership(status, joinDate, leaveDate, student, society);
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("MembershipDL.GetById", ex);
                return null;
            }
        }

        public List<Membership> GetAll()
        {
            try
            {
                List<Membership> list = new List<Membership>();

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllMemberships, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string status = reader["status"].ToString();
                        DateTime joinDate = Convert.ToDateTime(reader["joinDate"]);

                        DateTime? leaveDate =
                            reader["leaveDate"] == DBNull.Value
                            ? (DateTime?)null
                            : Convert.ToDateTime(reader["leaveDate"]);

                        int studentId = Convert.ToInt32(reader["studentId"]);
                        int societyId = Convert.ToInt32(reader["societyId"]);

                        StudentDL sdl = new StudentDL();
                        SocietyDL sodl = new SocietyDL();

                        Student student = sdl.GetById(studentId);
                        Society society = sodl.GetById(societyId);

                        list.Add(new Membership(status, joinDate, leaveDate, student, society));
                    }

                    reader.Close();
                }

                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("MembershipDL.GetAll", ex);
                return null;
            }
        }
    }
}