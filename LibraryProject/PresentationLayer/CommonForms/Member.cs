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



    public partial class Member : Form
    {
        enum Search { TITLE, AUTHOR }
        public Member(string NameUser)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comboBoxBookSearchBy.DataSource = Enum.GetValues(typeof(Search));

            string s = "";
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour <= 12)
                s = "Good morning";
            else if (dateTime.Hour > 12 && dateTime.Hour <= 18)
                s = "Good afternoon";
            else
                s = "Good evening";
            labelUserNames.Text = s+"," +NameUser;


            dataGridViewBook.AutoGenerateColumns = false;
        }

       

        private void textBoxBookSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
