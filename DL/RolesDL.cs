using DB_Final.BL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.DL
{
    public class RolesDL
    {
        public List<Role> roles()
        {
            try
            {
                List<Role> list = new List<Role>();

                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(DatabaseScripts.GetAllRoles, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Role r = new Role();
                        r.Id = Convert.ToInt32(reader["id"]);
                        r.Name = reader["name"].ToString();
                        r.Description = reader["description"].ToString();

                        list.Add(r);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                Logger.LogError("RolesDL.roles", ex);
                return null;
            }
        }
    }
}
