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
    public partial class ReturnBook : UserControl
    {
        public ReturnBook()
        {
            InitializeComponent();
            comboBoxReturnBookSortBy.DataSource = Enum.GetValues(typeof(Role));
        }

        private void dataGridViewReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewReturn.SelectedRows[0].Index;

            //POGLEDATI KOJIM REDOM IDU KOLONE PRI ISPISU

            textBoxReturnBookJmbg.Text = dataGridViewReturn[0, row].Value.ToString();
            textBoxReturnBookName.Text = dataGridViewReturn[1, row].Value.ToString();
            textBoxReturnBookSurname.Text = dataGridViewReturn[2, row].Value.ToString();

            textBoxReturnBookTitle.Text = dataGridViewReturn[4, row].Value.ToString();
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            int row = dataGridViewReturn.SelectedRows[0].Index;

            Book book = new Book();
            string JmbgUser = dataGridViewReturn[0, row].Value.ToString();
            
            book.Title = dataGridViewReturn[4, row].Value.ToString();

            //POZVATI METODU 

        }

        private void textBoxReturnBookSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
