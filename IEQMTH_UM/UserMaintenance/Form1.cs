using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            textBoxTop.Text = Names.LastName;
            textBoxLow.Text = Names.FirstName;
            button.Text = Names.Add;

            listBox.DataSource = users;
            listBox.ValueMember = "ID";
            listBox.DisplayMember = "FullName";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBoxTop.Text != "" && textBoxLow.Text != "")
            {
                users.Add(new User(textBoxTop.Text, textBoxLow.Text));
            }

        }
    }
}
