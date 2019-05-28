using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthDayDates.Class_methods
{
    class ChangeInformationClass:SqlClassConnection
    {

        //Изменение информации в БД
        public void ChangeInformation(string NameFirst, string SurnameFirst, string Name, string Surname, string Patronymic, DateTime BirthDay, string Info)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    string SqlExpression = $"UPDATE Users SET Name='{Name}', Surname='{Surname}', Patronymic='{Patronymic}', BirthDay='{BirthDay}', AdditionalInformation='{Info}' WHERE Name = '{NameFirst}' and Surname = '{SurnameFirst}'";
                    
                    SqlCommand cmd = new SqlCommand(SqlExpression, sqlCon);
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись изменена");
                }
            }
            catch (SqlException sqlexc)
            {
                MessageBox.Show(sqlexc.Message+sqlexc.LineNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
