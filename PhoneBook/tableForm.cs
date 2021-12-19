using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Class1 get = new Class1();
            string name = get.Name;
            string fathername = get.Fathername;
            int role = get.Role;
            if (role == 1)
                greetingsText.Text = $"Добро пожаловать, {name} {fathername}";
        }
    }
}
