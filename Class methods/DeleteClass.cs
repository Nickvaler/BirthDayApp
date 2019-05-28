using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthDayDates.Class_methods
{
    class DeleteClass:SqlClassConnection
    {
        public void DeleteInformation(string NameFirst, string SurnameFirst)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    string SqlExpression = $"DELETE FROM Users WHERE Name = '{NameFirst}' and Surname = '{SurnameFirst}'";

                    SqlCommand cmd = new SqlCommand(SqlExpression, sqlCon);
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись удалена");
                }
            }
            catch (SqlException sqlexc)
            {
                MessageBox.Show(sqlexc.Message + sqlexc.LineNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
