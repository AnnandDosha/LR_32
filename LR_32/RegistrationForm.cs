using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_32
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registryButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == repeatTextBox.Text && loginTextBox.Text != "" && loginTextBox.Text.IndexOf(' ') == -1)
            {
                MessageBox.Show(loginTextBox.Text + ",вы успешно зарегистрированы");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

            if (repeatTextBox.Text != passwordTextBox.Text)
            {
                repeatTextBox.BackColor = Color.Red;
            }
            else
            {
                repeatTextBox.BackColor = Color.White;
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginTextBox.Text.IndexOf(' ') != -1 || loginTextBox.Text == "")
            {
                loginTextBox.BackColor = Color.Red;
            }
            else
            {
                loginTextBox.BackColor = Color.White;
            }
        }

        private void repeatTextBox_TextChanged(object sender, EventArgs e)
        {
            if (repeatTextBox.Text != passwordTextBox.Text)
            {
                repeatTextBox.BackColor = Color.Red;
            }
            else
            {
                repeatTextBox.BackColor = Color.White;
            }
        }


        private void countryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateValue = new DateTime();
            dateValue = birthDateTimePicker.Value;
            DateTime now = DateTime.Today;
            int age = now.Year - dateValue.Year;
            if (dateValue > now.AddYears(-age)) age--;
            ageLabel.Text = "Возраст:" + Convert.ToString(age);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            birthDateTimePicker.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SquareCircle circle = new SquareCircle();
            circle.Show();
        }
    }
}
