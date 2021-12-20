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
            DataTable dataTable2 = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `address`", dB.getConnection());
            MySqlDataAdapter dataAdapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand();
            dataAdapter.SelectCommand = command;
            int role = get.Role;
            dB.connectionOpen();
            dataAdapter.Fill(dataTable);
            dB.connectionClose();
            int i = 0;
            while (i <= dataTable.Rows.Count)
            {
                command2.CommandText = $"SELECT * FROM `department` WHERE id = {dataTable.Rows[i][7]}";
                command2.Connection = dB.getConnection();
                dB.connectionOpen();
                dataAdapter2.Fill(dataTable2);
                dB.connectionClose();
                listBox1.Items.Add($"{dataTable2.Rows[0][1]}");
                dataTable2.Clear();
                if (i != 0 && Convert.ToString(dataTable.Rows[i][7]) != Convert.ToString(dataTable.Rows[i-1][7])) 
                {
                    command2.CommandText = $"SELECT * FROM `department` WHERE id = {dataTable.Rows[i][7]}";
                    command2.Connection = dB.getConnection();
                    dB.connectionOpen();
                    dataAdapter2.Fill(dataTable2);
                    dB.connectionClose();
                    listBox1.Items.Add($"{dataTable2.Rows[0][1]}");
                    dataTable2.Clear();
                }
                listBox1.Items.Add($"{Convert.ToString(dataTable.Rows[i][1])} {Convert.ToString(dataTable.Rows[i][2])} {Convert.ToString(dataTable.Rows[i][3])}");
                i++;
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
