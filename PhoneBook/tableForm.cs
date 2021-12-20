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
            int i = 0;
            while(i <= dataTable.Rows.Count )  
            {
                names.Add($"{dataTable.Rows[i][1]} {dataTable.Rows[i][2]} {dataTable.Rows[i][3]}");
                if (dataTable.Rows[i][])
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
    }
}
