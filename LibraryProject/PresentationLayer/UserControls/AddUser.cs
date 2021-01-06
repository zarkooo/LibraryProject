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
using BusinessLayer;
using Common.Interfaces.Business;

namespace PresentationLayer.UserControls
{
    public partial class AddUser : UserControl
    {
        private string emailRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        private readonly IUserBusiness userBusiness = new UserBusiness();
        enum FindBy { NAME,SURNAME}
        public AddUser()
        {
            InitializeComponent();
            comboBoxSortBy.DataSource = Enum.GetValues(typeof(FindBy));
            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));
            
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

            if (ErrorValidation())
            {

                User user = new User();

                user.JmbgUser = textBoxUserJmbg.Text;
             
                user.Name = textBoxUserName.Text;
                user.Surname = textBoxUserSurName.Text;
                user.Email = textBoxUserEmail.Text;
                user.Password = textBoxUserPassword.Text;
                user.Role = (Role)Enum.Parse(typeof(Role), comboBoxRole.SelectedItem.ToString());


                if (this.userBusiness.UpdataUser(user) == true)
                {
                    MessageBox.Show("successfully");
                    ReffresTable();
                    setTextBox();
                }
                else
                    MessageBox.Show("error");
            }

          
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int row = dataGridViewUser.SelectedRows[0].Index;

            string Jmbg = dataGridViewUser[0, row].Value.ToString();

            textBoxUserName.Text = dataGridViewUser[1, row].Value.ToString();
            textBoxUserSurName.Text = dataGridViewUser[2, row].Value.ToString();
            textBoxUserEmail.Text = dataGridViewUser[3, row].Value.ToString();
            textBoxUserPassword.Text = dataGridViewUser[4, row].Value.ToString();
            if (this.userBusiness.DeleteUser(Jmbg) == true)
            {
                MessageBox.Show("successfully");
                ReffresTable();
                setTextBox();
            }
            else
                MessageBox.Show("error");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
         if(ErrorValidation())
            {
                if (this.userBusiness.AddUser(ValidationUser) == true)
                {
                    MessageBox.Show("Uspesno");
                    setTextBox();
                    ReffresTable();
                }
                else
                    MessageBox.Show("Greska");
            }
        }
        private void setTextBox()
        {
            textBoxUserEmail.Clear();
            textBoxUserJmbg.Clear();
            textBoxUserName.Clear();
            textBoxUserSurName.Clear();
            textBoxUserPassword.Clear();
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

        private bool ErrorValidation ()
        {
            if (!long.TryParse(textBoxUserJmbg.Text, out long r))
            {
                error.SetError(textBoxUserJmbg, "Enter a numeric value");
                return false;
            }
            else if (textBoxUserJmbg.Text == "")
            {
                error.SetError(textBoxUserJmbg, "Required field");
                return false;
            }
            else if (textBoxUserName.Text == "")
            {
                error.SetError(textBoxUserName, "Required field");
                return false;
            }
            else if (textBoxUserSurName.Text == "")
            {
                error.SetError(textBoxUserSurName, "Required field");
                return false;
            }
            else if (textBoxUserPassword.Text == "")
            {
                error.SetError(textBoxUserPassword, "Required field");
                return false;
            }
            else if (!Regex.Match(textBoxUserEmail.Text, emailRegex).Success)
            {
                error.SetError(textBoxUserEmail, "Wrong entry");
                return false;
            }


            error.Clear();
            return true;
        }
        private void ReffresTable()
        {
            //dataGridViewUser.DataSource = userBusiness.GetAllUsers().ToList();
            dataGridViewUser.Rows.Clear();
            List<User> list = this.userBusiness.GetAllUsers();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewUser.Rows.Add(list[i].JmbgUser, list[i].Name,
                    list[i].Surname, list[i].Email, list[i].Password, list[i].Role);
            }
           
        }
      
        
        private void AddUser_Load(object sender, EventArgs e)
        {
            ReffresTable();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string by = comboBoxSortBy.SelectedItem.ToString();
            List<User> listuser = null;
            if(by== "NAME")
            {
                User user = new User();
                user.Name = textBoxSearch.Text;
                listuser = this.userBusiness.SearchUser(by, user).ToList();
            }
            else if(by== "SURNAME")
            {
                User user = new User();
                user.Surname = textBoxSearch.Text;
                listuser = this.userBusiness.SearchUser(by, user).ToList();
            }
            dataGridViewUser.Rows.Clear();
            
            for (int i = 0; i < listuser.Count; ++i)
            {
                dataGridViewUser.Rows.Add(listuser[i].JmbgUser, listuser[i].Name,
                    listuser[i].Surname, listuser[i].Email, listuser[i].Password, listuser[i].Role);
            }
        }
    }
}
