using System;
using System.Windows.Forms;

namespace BirthDayDates
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Заполните обязательное поле \"Имя\"");
            }
            else if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Заполните обязательное поле \"Фамилия\"");
            }
            else
            {
                Class_methods.DeleteClass Del = new Class_methods.DeleteClass();

                Del.DeleteInformation(textBox1.Text, textBox2.Text);
                this.Close();
            }
                
        }
    }
}
