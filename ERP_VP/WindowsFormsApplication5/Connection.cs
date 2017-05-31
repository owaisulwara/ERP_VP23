using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApplication5
{
    public class Connection
    {
        public OleDbConnection con = new OleDbConnection();
        public void conString() {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PC_DB.accdb;Persist Security Info=False;";
        }
    }
}
