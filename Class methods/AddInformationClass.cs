using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthDayDates.Class_methods
{
    class AddInformationClass:SqlClassConnection
    {
        //Добавление информации в БД
        public void AddInformationToSql(string Name, string Surname, string Patronymic, DateTime BirthDay, string Info)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    string SqlExpression = $"INSERT INTO Users (Name,Surname,Patronymic,BirthDay,AdditionalInformation) VALUES " +
                                                                                    $"('{Name}'," +
                                                                                    $"'{Surname}'," +
                                                                                    $"'{Patronymic}'," +
                                                                                    $"'{BirthDay}'," +
                                                                                    $"'{Info}')";
                    SqlCommand cmd = new SqlCommand(SqlExpression, sqlCon);
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена");
                }
            }
            catch (SqlException sqlexc)
            {
                MessageBox.Show(sqlexc.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
