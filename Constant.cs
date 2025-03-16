using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FitnessTracker
{
    class Constant
    {
        public static string AutoID(DataTable dataTable, char specialID)
        {
            if (dataTable.Rows.Count == 0)
            {
                return specialID.ToString() + "0001";
            }
            else
            {
                int size = dataTable.Rows.Count - 1;
                string oldID = dataTable.Rows[size][0].ToString();
                int newID = Convert.ToInt32(oldID.Substring(1, 4));

                if (newID >= 1 && newID < 9)
                {
                    return specialID.ToString() + "000" + (newID + 1);
                }
                else if (newID >= 9 && newID < 99)
                {
                    return specialID.ToString() + "00" + (newID + 1);
                }
                else if (newID >= 99 && newID < 999)
                {
                    return specialID.ToString() + "0" + (newID + 1);
                }
                else if (newID >= 999 && newID < 9999)
                {
                    return specialID.ToString() + (newID + 1);
                }
                else
                {
                    return null;
                }
            }
        }

        public static void Logout(Form form)
        {
            Starter starter = new Starter();
            form.Hide();
            starter.Show();
        }

        public enum Gender
        {
            Male = 'M',
            Female = 'F',
            Other = 'O'
        }

        public enum TableColumnName
        {
            TrackerID,
            TrackerName,
            ActivityName,
            SetGoal,
            TrackDate,
            TotalCalBurn,
            TrackStatus,
            CreatedDate
        }

        public static bool UsernameValidation(string username)
        {
            string pattern = @"^(?=[a-z])(?=.*\d)[a-z0-9]+$";
            return !Regex.IsMatch(username, pattern);
        }

        public static void UsernameValidationAlert(string username)
        {
            string errorMessageFirstUpperCase = !new Regex(@"^[a-z]").IsMatch(username) ? "Username must be start with lower character.\n" : "";
            string errorMessageContainNumber = !new Regex(@"(?=.*\d)").IsMatch(username) ? "Username must contain at least one number.\n" : "";
            string errorMessageContainLowerCharAndNumber = !new Regex(@"^[a-z0-9]+$").IsMatch(username) ? "Username can only contain lowercase letters and numbers.\n" : "";

            string errorMessage = $"{errorMessageFirstUpperCase}{errorMessageContainNumber}{errorMessageContainLowerCharAndNumber}";
            MessageBox.Show(errorMessage, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool PasswordValidation(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z]).{12}$";
            return !Regex.IsMatch(password, pattern);
        }

        public static void PasswordValidationAlert(string password)
        {
            string errorMessageLowercase = !new Regex(@"^(?=.*[a-z]).*$").IsMatch(password) ? "Password must be contain at least one lowercase letter.\n" : "";
            string errorMessageUppercase = !new Regex(@"^(?=.*[A-Z]).*$").IsMatch(password) ? "Password must be contain at least one uppercase letter.\n" : "";
            string errorMessageLength = !new Regex(@"^.{12}$").IsMatch(password) ? "Password must be 12 characters." : "";

            string errorMessage = $"{errorMessageLowercase}{errorMessageUppercase}{errorMessageLength}";
            MessageBox.Show(errorMessage, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool EmailValidation(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return !Regex.IsMatch(email, pattern);
        }
    }
}
