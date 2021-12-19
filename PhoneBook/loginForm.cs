using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PhoneBook
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            FormClosing += loginForm_FormClosing;
        }
        
        private void loginForm_Load(object sender, EventArgs e)
        {
            loginField.Text = "Введите логин...";
            passwordField.Text = "Введите пароль...";
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }
        
        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин...")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }
        
        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин...";
                loginField.ForeColor = Color.Gray;
            }
        }
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите пароль...")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black;

            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введите пароль...";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Просмотреть";
            tableForm view = new tableForm();
            view.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 Get = new Class1();
            
            string userLogin = loginField.Text;
            string userPass = passwordField.Text;
            DB dB = new DB();
            dB.getConnection();
            DataTable dT = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM 'user' WHERE login = {userLogin} AND pass = {userPass}");
            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(dT);

            try
            {
                if (dT.Rows.Count > 0)
                {
                    tableForm form1 = new tableForm();
                    Hide();
                    form1.Show();
                    Get.Role = Convert.ToInt32(dT.Rows[0][8]);
                    Get.Name = Convert.ToString(dT.Rows[0][2]);
                    Get.Fathername = Convert.ToString(dT.Rows[0][3]);
                }

                else
                    MessageBox.Show("");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(e);
        }
    }
}
