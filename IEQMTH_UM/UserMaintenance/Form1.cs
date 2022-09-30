using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            labelTop.Text = Names.LastName;
            labelLow.Text = Names.FirstName;
            button.Text = Names.Add;
            buttonToSave.Text = Names.WriteToFile;
            buttonToDelete.Text = Names.DeleteRow;

            listBox.DataSource = users;
            listBox.ValueMember = "ID";
            listBox.DisplayMember = "FullName";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textBoxTop.Text != "" && textBoxLow.Text != "")
            {
                users.Add(new User($"{textBoxTop.Text} {textBoxLow.Text}"));
            }
            EmptyTextBoxes();
        }

        List<string> instances = new List<string>();
        private void buttonToSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            saveFileDialog.ShowDialog();

            foreach (var user in users)
            {
                instances.Add($"{user.ID}@{user.FullName}");
            }

            File.WriteAllLines(saveFileDialog.FileName, instances);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = listBox.SelectedItem as User;
            textBoxTop.Text = selected.FullName.Split(' ')[0];
            textBoxLow.Text = selected.FullName.Split(' ')[1];

        }

        private void buttonToDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                var selectedUser = listBox.SelectedItem as User;
                int counter = 0;
                while (counter < users.Count && users[counter] != selectedUser)
                {
                    counter++;
                }
                if (users[counter] == selectedUser)
                {
                    users.Remove(users[counter]);
                }
            }
            EmptyTextBoxes();
        }

        private void EmptyTextBoxes()
        {
            textBoxTop.Text = "";
            textBoxLow.Text = "";
        }
    }
}
