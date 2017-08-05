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
        public Database ()
	    {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=accessdb.accdb";
	    }

        public bool checkAuth(user u)
        { 
            
        }

    }
}
