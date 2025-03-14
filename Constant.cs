using System;
using System.Data;
using System.Windows.Forms;

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
    }
}
