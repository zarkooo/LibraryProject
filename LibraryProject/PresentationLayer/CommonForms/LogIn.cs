using BusinessLayer;
using Common.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Models;

namespace PresentationLayer.CommonForms
{
    public partial class LogIn : Form
    {
        private readonly ILogInBusiness logInBusiness;
        public LogIn()
        {
            InitializeComponent();
            this.logInBusiness = new LogInBusiness();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (ErrorValidation())
            {
                User user = new User();
                user.JmbgUser = textBoxLogInJmbg.Text;
                user.Password = textBoxLogInPassword.Text;

                Role role = this.logInBusiness.LogIn(user);

                if (role.Equals(Role.LIBRARIAN))
                {
                    ClearTextBox();
                    Library library = new Library();
                    library.ShowDialog();
                }
                else if (role.Equals(Role.USER))
                {
                    
                    Member member = new Member(this.logInBusiness.GetNameUser(textBoxLogInJmbg.Text));
                    ClearTextBox();
                    member.ShowDialog();
                }
                else if (role.Equals(Role.NONE))
                {
                    ClearTextBox();
                    MessageBox.Show("Wrong entry");
                }
           

            }
        }
        private void ClearTextBox()
        {
            textBoxLogInJmbg.Text = "";
            textBoxLogInPassword.Text = "";
        }
        private bool ErrorValidation()
        {
            if (!long.TryParse(textBoxLogInJmbg.Text, out long r))
            {
                error.SetError(textBoxLogInJmbg, "Enter a numeric value");
                return false;
            }
            else if (textBoxLogInJmbg.Text == "")
            {
                error.SetError(textBoxLogInJmbg, "Required field");
                return false;
            }
            else if (textBoxLogInPassword.Text == "")
            {
                error.SetError(textBoxLogInPassword, "Required field");
                return false;
            }

            error.Clear();
            return true;
        }


    }
}
