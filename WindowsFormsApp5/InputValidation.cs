using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsApp5
{
    class InputValidation
    {
        public InputValidation()
        {

        }

        public void ValidateUsername(string username)
        {
            try
            {
                // start with a letter, allow letter or number.
                string pattern = @"^[a-zA-Z][a-zA-Z0-9]+$";

                if (String.IsNullOrEmpty(username))
                {
                    throw new Exception("The username should not be empty!");
                }
                bool check = Regex.IsMatch(username, pattern);
                if (!check)
                {
                    throw new Exception("The username should contain only numbers and alpahabet, start with letters");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ValidatePassword(string password)
        {
            try
            {
                if (String.IsNullOrEmpty(password))
                {
                    throw new Exception("The password should not be empty");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ValidateName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return false;
            }
            string pattern = "^[a-zA-Z]+( [a-zA-Z-]+)*$";
            bool check = Regex.IsMatch(name, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }
        public bool ValidateEmail(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                return false;
            }
            string pattern = "^.+@.+[.][a-zA-Z]+$";
            bool check = Regex.IsMatch(email, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }
        public bool ValidateAddress(string address)
        {
            if (String.IsNullOrEmpty(address))
            {
                return false;
            }
            string pattern = "^[ a-zA-Z0-9]+$";
            bool check = Regex.IsMatch(address, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }
        public bool ValidateNumberString(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                return false;
            }
            string pattern = "^[0-9]+$";
            bool check = Regex.IsMatch(number, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }
        public bool ValidateFTE(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                return false;
            }
            string pattern = "^0[.][1-9]$";
            bool check = Regex.IsMatch(number, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }

        public bool ValidateDoubleString(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                return false;
            }
            string pattern = "^[0-9]+([.][1-9]*)?$";
            bool check = Regex.IsMatch(number, pattern);
            if (!check)
            {
                return false;
            }
            return true;
        }
    }
}