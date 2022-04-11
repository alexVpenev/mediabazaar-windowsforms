using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Attendance
    {
        public string Username { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }

        public Attendance()
        {

        }

        public Attendance(string username, string type, DateTime dateTime, string comment)
        {
            this.Username = username;
            this.Type = type;
            this.DateTime = dateTime;
            this.Comment = comment;
        }

        public override string ToString()
        {
            if(this.Comment == "")
            {
                return this.Type + ": " + this.DateTime;
            }
            else return this.Type + ": " + this.DateTime + " (" + this.Comment + ")";
        }
    }
}
