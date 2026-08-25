using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class StudentDL
    {
        public void Insert(Student s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertStudent, conn);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@department", s.Department);
                    cmd.Parameters.AddWithValue("@phone", s.Phone);
                    cmd.Parameters.AddWithValue("@batchYear", s.BatchYear);
                    cmd.Parameters.AddWithValue("@regNo", s.RegNo);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StudentDL.Insert", ex);
               
            }
        }
        public void Update(Student s)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateStudent, conn);
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@department", s.Department);
                    cmd.Parameters.AddWithValue("@phone", s.Phone);
                    cmd.Parameters.AddWithValue("@batchYear", s.BatchYear);
                    cmd.Parameters.AddWithValue("@regNo", s.RegNo);
                    cmd.Parameters.AddWithValue("@status", s.Status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StudentDL.Update", ex);
               
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteStudent, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StudentDL.Delete", ex);
                 
            }
        }

        public Student GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetStudentById, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return new Student(
                            id,
                            reader["name"].ToString(),
                            Convert.ToInt32(reader["batchYear"]),
                            reader["department"].ToString(),
                            reader["status"].ToString(),
                            reader["email"].ToString(),
                            reader["regNo"].ToString(),
                            reader["phone"].ToString()
                        );
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("StudentDL.GetById", ex);
                return null;
            }
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(DatabaseScripts.GetAllStudents, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        students.Add(
                            new Student(
                                Convert.ToInt32(reader["id"]),
                                reader["name"].ToString(),
                                Convert.ToInt32(reader["batchYear"]),
                                reader["department"].ToString(),
                                reader["status"].ToString(),
                                reader["email"].ToString(),
                                reader["regNo"].ToString(),
                                reader["phone"].ToString()
                            )
                        );
                    }
                }

                return students;
            }
            catch (Exception ex)
            {
                Logger.LogError("StudentDL.GetAll", ex);
            }

            return students;
        }
    }
}
