using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RodgieFritzBarnuevo.Classes
{
    class Database
    {
        OleDbCommand cmd = null;
        OleDbConnection conn = null;
        OleDbDataReader dr = null;
        private string sql = null;
        public Database ()
	    {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=accessdb.accdb";
	    }

        public bool checkAuth(user u)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM accessdb WHERE username LIKE @username AND password LIKE @password";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return false;
        }
    }
}
