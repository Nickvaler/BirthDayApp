using System;
using System.Windows.Forms;

namespace BirthDayDates
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add user
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
                    Class_methods.ChangeInformationClass ch = new Class_methods.ChangeInformationClass();
                    ch.ChangeInformation(textBox1.Text, textBox2.Text, textName.Text, textSurname.Text,
                        textPatr.Text, dateTimePicker1.Value, textAddInform.Text);
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
