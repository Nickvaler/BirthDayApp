using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthDayDates.Class_methods
{
    class SelectFromDB:SqlClassConnection
    {
        public string textToTextBox;
        int countData = 0;
        public int CountData { get { return countData; } private set { } }
        //Метод для вывода информации из БД
        public string SelectMethod()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
                {
                    sqlCon.Open();
                    string sqlExpression = "SELECT * FROM Users";
                    SqlCommand cmd = new SqlCommand(sqlExpression, sqlCon);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        
                        textToTextBox = "Имя"+"\t\t"+ "Фамилия" + "\t\t" + "Отчество" + "\t\t" + "Дата рождения" + "\t\t" + "Дополнительная информация" + "\r\n";
                        while (dataReader.Read())
                        {
                            textToTextBox = textToTextBox + dataReader.GetValue(1) + "\t\t" + dataReader.GetValue(2) + "\t\t" + dataReader.GetValue(3) + "\t\t" + dataReader.GetDateTime(4).ToString("D") + "\t\t" + dataReader.GetValue(5) + "\r\n";
                            countData++;
                        }
                        textToTextBox = textToTextBox + "\nОбщее количество записей равно: " + CountData;
                        
                    }
                    dataReader.Close();
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
            return textToTextBox;
        }
    }
}
