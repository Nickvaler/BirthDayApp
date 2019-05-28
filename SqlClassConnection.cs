using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BirthDayDates
{
    class SqlClassConnection
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set { }
        }
        //Тест подключения к БД
        public void TryConnection()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MessageBox.Show($"Подлючение открыто\n\nСвойства подключения:\n" +
                        $"Строка подключения:\t{sqlCon.ConnectionString}\n" +
                        $"База данных:\t{sqlCon.Database}\n" +
                        $"Сервер:\t{sqlCon.DataSource}\n" +
                        $"Версия сервера:\t{sqlCon.ServerVersion}\n" +
                        $"Состояние:\t{sqlCon.State}\n" +
                        $"WorkStationId:\t{sqlCon.WorkstationId}\n");
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
