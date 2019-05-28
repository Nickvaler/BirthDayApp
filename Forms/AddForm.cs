using System;
using System.Windows.Forms;

namespace BirthDayDates
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {//close button
            
            this.Close();
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
                Class_methods.AddInformationClass sqlAdd = new Class_methods.AddInformationClass();
                sqlAdd.AddInformationToSql(textBox1.Text, textBox2.Text,
                    textBox3.Text, dateTimePicker1.Value, textBox5.Text);
                this.Close();
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
