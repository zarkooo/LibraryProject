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
}
