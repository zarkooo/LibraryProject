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

namespace PresentationLayer.UserControls
{
    public partial class Retnt : UserControl
    {
        enum Search { TITLE, AUTHOR }

        public Retnt()
        {
            InitializeComponent();
            comboBoxUserBy.DataSource = Enum.GetValues(typeof(Role));
            comboBoxBooksBy.DataSource = Enum.GetValues(typeof(Search));
            buttonIssue.Visible = false;
        }

        private void textBoxUserSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxBooksSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewUser.SelectedRows[0].Index;

            //POGLEDATI KOJIM REDOM IDU KOLONE PRI ISPISU

            textBoxJmbgUser.Text = dataGridViewUser[0, row].Value.ToString();
            textBoxNameUser.Text = dataGridViewUser[1, row].Value.ToString();
            textBoxSurnameUser.Text = dataGridViewUser[2, row].Value.ToString();
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewBooks.SelectedRows[0].Index;

            //POGLEDATI KOJIM REDOM IDU KOLONE PRI ISPISU

            textBoxTitleBooks.Text = dataGridViewBooks[1, row].Value.ToString(); 
        }

        private void buttonIssue_Click(object sender, EventArgs e)
        {
            int row1 = dataGridViewUser.SelectedRows[0].Index;
            int row2 = dataGridViewBooks.SelectedRows[0].Index;

            string Jmbg = dataGridViewUser[0, row1].Value.ToString();

            Rented rented = new Rented();
            rented.IdBook = int.Parse(dataGridViewBooks[0, row2].Value.ToString());

            rented.DateOfIssue = DateTime.Parse(dateTimePickerDateOfIssue.Value.ToString());

            rented.ReturnDate = DateTime.Parse(dateTimePickerReturnBooks.Value.ToString());

            buttonIssue.Visible = true;
            
            //Pozvati metodu iz biznis sloja za izdavanje
            

        }
    }
}
