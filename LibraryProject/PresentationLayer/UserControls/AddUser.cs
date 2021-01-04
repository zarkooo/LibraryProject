using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Models;
using System.Text.RegularExpressions;

namespace PresentationLayer.UserControls
{
    public partial class AddUser : UserControl
    {
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        public AddUser()
        {
            InitializeComponent();
            comboBoxSortBy.DataSource = Enum.GetValues(typeof(Role));
        }

        private User ValidationUser
        {
            get
            {
                if (textBoxUserJmbg.Text == "" || textBoxUserName.Text == "" || textBoxUserSurName.Text == "" ||
                     textBoxUserPassword.Text == "")
                    return null;

                if (Regex.Match(textBoxUserEmail.Text, emailRegex).Success)
                {
                    User user = new User();
                    user.JmbgUser = textBoxUserJmbg.Text;
                    user.Name = textBoxUserName.Text;
                    user.Surname = textBoxUserSurName.Text;
                    user.Email = textBoxUserEmail.Text;
                    user.Password = textBoxUserPassword.Text;
                    user.Role = (Role)Enum.Parse(typeof(Role), comboBoxRole.SelectedItem.ToString());
                    return user;
                }
                return null;

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            User user = new User();

            int row = dataGridViewUser.SelectedRows[0].Index;
            user.JmbgUser = dataGridViewUser[0, row].Value.ToString();
            user.Name = dataGridViewUser[1, row].Value.ToString();
            user.Surname = dataGridViewUser[2, row].Value.ToString();
            user.Email = dataGridViewUser[3, row].Value.ToString();
            user.Password = dataGridViewUser[4, row].Value.ToString();

            textBoxUserJmbg.Text = user.JmbgUser;
            textBoxUserName.Text = user.Name;
            textBoxUserSurName.Text = user.Surname;
            textBoxUserEmail.Text = user.Email;
            textBoxUserPassword.Text = user.Password;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int row = dataGridViewUser.SelectedRows[0].Index;

            string Jmbg = dataGridViewUser[0, row].Value.ToString();

            textBoxUserName.Text = dataGridViewUser[1, row].Value.ToString();
            textBoxUserSurName.Text = dataGridViewUser[2, row].Value.ToString();
            textBoxUserEmail.Text = dataGridViewUser[3, row].Value.ToString();
            textBoxUserPassword.Text = dataGridViewUser[4, row].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewUser.SelectedRows[0].Index;

            textBoxUserJmbg.Text = dataGridViewUser[0, row].Value.ToString();

            textBoxUserName.Text = dataGridViewUser[1, row].Value.ToString();
            textBoxUserSurName.Text = dataGridViewUser[2, row].Value.ToString();
            textBoxUserEmail.Text = dataGridViewUser[3, row].Value.ToString();
            textBoxUserPassword.Text = dataGridViewUser[4, row].Value.ToString();
        }
    }
}
