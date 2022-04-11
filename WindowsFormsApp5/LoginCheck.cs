using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    class LoginCheck
    {
        private List<User> users;
        private InputValidation valid;
        private SQL sql;

        public LoginCheck()
        { 
            this.valid = new InputValidation();
            this.sql = new SQL();
            this.users = sql.GetUsers();
        }
 
        public void CreateNewUser(string usr, string pass, ACCESS acs)
        {
            users.Add(new User(usr, pass, acs));
        }

        public string GetPasswordByUsername(string username)
        {
            try
            {
                foreach(User u in users)
                {
                    if (username == u.Username)
                        return u.Password;
                }
                throw new Exception("Username not found!");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckLogin(string username, string password)
        {
            try
            {
                username = username.Trim();
                password = password.Trim();

                string validPassword = this.GetPasswordByUsername(username);

                if(validPassword != password)
                {
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public ACCESS GetAccessByUsername(string username)
        {
            try
            {
                foreach (User u in users)
                {
                    if (username == u.Username)
                        return u.Access;
                }
                throw new Exception("Username not found!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
