using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class tableForm : Form
    {
        public tableForm()
        {
            InitializeComponent();
            FormClosing += tableForm_FormClosing;
            greetingsText.Visible = false;
        }
        private void tableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(e);
        }

        private void tableForm_Load(object sender, EventArgs e)
        {
            Getters get = new Getters();
            string name = get.Name;
            string fathername = get.Fathername;
            DB dB = new DB();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM 'user'");
            dataAdapter.SelectCommand = command;
            int role = get.Role;
            dataAdapter.Fill(dataTable);
            List<string> names = new List<string>();
            for(int k; k = 2;k++)
            {
                names.Add($"{}")
            }
            if (role == 1)
            {
                greetingsText.Text = $"Добро пожаловать, {name} {fathername}";
                adressTB.ReadOnly = false;
                cabTB.ReadOnly = false;
                citynumberTB.ReadOnly = false;
                fathernameTB.ReadOnly = false;
                nameTB.ReadOnly = false;
                postTB.ReadOnly = false;
                surnameTB.ReadOnly = false;
            }
            

            
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void fathernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void adressTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cabTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void citynumberTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void postTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
