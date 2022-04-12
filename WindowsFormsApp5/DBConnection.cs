using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    sealed class DBConnection
    {
        private string server;
        private string database;
        private string username;
        private string password;
        public string ConnString { get; private set; }
        public DBConnection()
        {
            //db no longer exists
            server = "";
            database = "";
            username = "";
            password = "";
            ConnString = String.Format("server={0};database={1};uid={2};password={3};", server, database, username, password);
        }
    }
}
