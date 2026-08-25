using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_Final.BL;

namespace DB_Final.DL
{
    public class RoleHistoryDL
    {
        //---Roles---
        public void InsertRole(string name, string description)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertRole, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.InsertRole", ex);
                 
            }
        }
        public void UpdateRole(int id, string name, string description)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateRole, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.UpdateRole", ex);
                
            }
        }
        public void DeleteRole(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteRole, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.DeleteRole", ex);
                
            }
        }
        public List<(int id, string name, string description)> roles()
        {
            try
            {
                List<(int id, string role, string description)> roles = new List<(int, string, string)>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllRoles, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roles.Add(((int)reader["id"], reader["name"].ToString(), reader["description"].ToString()));
                    }
                }
                return roles;
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.roles", ex);
                return null;
            }
        }

        public string GetRoleById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetRoleById, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["name"].ToString();
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.GetRoleById", ex);
                return null;
            }
        }
        //----End Roles----

        public void Insert(RoleHistory mrh, int roleId)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.InsertMembershipRoleHistory, conn);
                    cmd.Parameters.AddWithValue("@startDate", mrh.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", mrh.EndDate.HasValue ? (object)mrh.EndDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@membershipId", mrh.Membership != null ? (object)mrh.Membership.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.Insert", ex);
                 
            }
        }
        public void Update(RoleHistory mrh, int roleId)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.UpdateMembershipRoleHistory, conn);
                    cmd.Parameters.AddWithValue("@id", mrh.Id);
                    cmd.Parameters.AddWithValue("@startDate", mrh.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", mrh.EndDate.HasValue ? (object)mrh.EndDate.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@membershipId", mrh.Membership != null ? (object)mrh.Membership.Id : DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.Update", ex);
                 
            }
        }
        public void Delete(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.DeleteMembershipRoleHistory, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.Delete", ex);
                
            }
        }
        public RoleHistory GetById(int id)
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetMembershipRoleHistoryById, conn);
                    cmd.Parameters.AddWithValue("id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime sDate = (DateTime)reader["startDate"];
                        DateTime eDate = (DateTime)reader["endDate"];
                        int rId = (int)reader["roleId"];
                        int mId = (int)reader["membershipId"];
                        reader.Close();
                        RoleHistoryDL mrhd = new RoleHistoryDL();
                        MembershipDL md = new MembershipDL();
                        String roleTitle = mrhd.GetRoleById(rId);
                        Membership ms = md.GetById(mId);
                        return new RoleHistory(sDate, eDate, roleTitle, ms);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.GetById", ex);
                return null;
            }
        }
        public List<RoleHistory> GetAll()
        {
            try
            {
                List<RoleHistory> list = new List<RoleHistory>();
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllMembershipRoleHistories, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<(int id, DateTime st, DateTime et, int rId, int mId)> rows = new List<(int, DateTime, DateTime, int, int)>();
                    while (reader.Read())
                    {
                        rows.Add(((int)reader["id"], (DateTime)reader["startDate"], (DateTime)reader["endDate"], (int)reader["roleId"], (int)reader["membershipId"]));
                    }
                    reader.Close();
                    foreach (var row in rows)
                    {
                        MembershipDL md = new MembershipDL();
                        RoleHistoryDL mrhd = new RoleHistoryDL();
                        string role = mrhd.GetRoleById(row.rId);
                        Membership m = md.GetById(row.mId);
                        list.Add(new RoleHistory(row.id, row.st, row.et, role, m));
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("RoleHistoryDL.GetAll", ex);
                return null;
            }
        }
    }
}
