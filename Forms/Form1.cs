using System;
using System.Windows.Forms;

namespace BirthDayDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Отображение информации в метке на начальной форме
        private void Form1_Load(object sender, EventArgs e)
        {
            Class_methods.SelectFromDB selFrDb = new Class_methods.SelectFromDB();
            textBox1.Text = "Доброго времени суток, сейчас " + DateTime.Now.ToString() + "\r\n\r\nИнформация о днях рождения:\r\n\r\n";
            textBox1.Text = textBox1.Text + selFrDb.SelectMethod();
            
        }

        //Переход в форму для добавления информации
        private void добавитьИнформациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddForm adf = new AddForm();
            adf.ShowDialog();
        }
        //Переход в форму для изменения информации
        private void изменитьИнформациюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.ShowDialog();
        }
        //Переход в форму для удаления информации
        private void удалитьИнформациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteForm DelForm = new DeleteForm();
            DelForm.ShowDialog();
        }

        private void проверкаПодключенияКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlClassConnection tr = new SqlClassConnection();
            tr.TryConnection();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа выводит информацию из БД (ФИО, дата рождения, дополнительная информация)");
        }
        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
