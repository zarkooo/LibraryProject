using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.CommonForms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (ErrorValidation())
            {


            if (textBoxLogInPassword.Text == "1")
            {
                Member member = new Member("Jack");
                
                member.ShowDialog();
                
            }
            else
            {
                Library library = new Library();
                
                library.ShowDialog();
                
            }

            }
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
