using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using UnifyPaper.Classes;
using System.Windows.Forms;

namespace UnifyPaper.Classes.database
{
    class database
    {
        OleDbCommand cmd = null;
        OleDbDataReader dr = null;
        OleDbConnection conn = null;


        public database()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=unifypaper.accdb";
        }

        public Classes.entities.users checkLogin(entities.users data) 
        {
            Classes.entities.users u = new Classes.entities.users();
            
            try
            {
                

                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE username LIKE @username AND PASSWORD LIKE @password";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", data.username);
                cmd.Parameters.AddWithValue("@password", data.password);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    u.UID = dr["id"].ToString();
                    u.username = dr["username"].ToString();
                    u.password = dr["password"].ToString();
                    u.user_level = dr["user_level"].ToString();
                }
                else
                {
                    u = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return u;
        }
    }
}
