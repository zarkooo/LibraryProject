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
    public partial class Books : UserControl
    {
        enum Search { TITLE, AUTHOR }
        public Books()
        {
            InitializeComponent();
            comboBoxSortByBooks.DataSource = Enum.GetValues(typeof(Search));
        }

        private bool ErrorValidation()
        {
            
            if (textBoxTitle.Text == "")
            {
                error.SetError(textBoxTitle, "Required field");
                return false;
            }
            else if (textBoxISBN.Text == "")
            {
                error.SetError(textBoxISBN, "Required field");
                return false;
            }
            else if (textBoxAuthorName.Text == "")
            {
                error.SetError(textBoxAuthorName, "Required field");
                return false;
            }
            else if (!int.TryParse(textBoxYearOfIssue.Text, out int r))
            {
                error.SetError(textBoxYearOfIssue, "Enter a numeric value");
                return false;
            }
            else if (textBoxYearOfIssue.Text == "")
            {
                error.SetError(textBoxYearOfIssue, "Required field");
                return false;
            }
            else if (!int.TryParse(textBoxQuantity.Text, out int r2))
            {
                error.SetError(textBoxQuantity, "Enter a numeric value");
                return false;
            }
            else if (textBoxQuantity.Text == "")
            {
                error.SetError(textBoxQuantity, "Required field");
                return false;
            }

            error.Clear();
            return true;
        }

        private Book ValidationBook
        {
            get
            {
                if (textBoxTitle.Text == "" || textBoxISBN.Text == "" || textBoxAuthorName.Text == "" ||
                    !int.TryParse(textBoxYearOfIssue.Text, out int year) || !int.TryParse(textBoxQuantity.Text, out int quantity))
                    return null;

                Book book = new Book();
                book.Title = textBoxTitle.Text;
                book.NameAuthor = textBoxAuthorName.Text;
                book.ISBN = textBoxISBN.Text;
                book.YearOfIssue = year;
                book.Quantity = quantity;
                return book;
                
            }
        }

        private void buttonAddBooks_Click(object sender, EventArgs e)
        {
            if (ErrorValidation())
            {

            }
        }

        private void buttonUpdateBooks_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            int row = dataGridViewBook.SelectedRows[0].Index;
            book.Title = dataGridViewBook[1, row].Value.ToString();
            book.ISBN = dataGridViewBook[2, row].Value.ToString();
            book.NameAuthor = dataGridViewBook[3, row].Value.ToString();
            book.YearOfIssue = int.Parse(dataGridViewBook[4, row].Value.ToString());
            book.Quantity = int.Parse(dataGridViewBook[5, row].Value.ToString());

         /*   textBoxTitle.Text = book.Title;
            textBoxISBN.Text = book.ISBN;
            textBoxAuthorName.Text = book.NameAuthor;
            int yearConvert = Convert.ToInt32(textBoxYearOfIssue.Text);
            yearConvert = book.YearOfIssue;

            int quantityConvert = Convert.ToInt32(textBoxQuantity.Text);
            quantityConvert = book.Quantity; */
        }

        private void buttonDeleteBooks_Click(object sender, EventArgs e)
        {
            int row = dataGridViewBook.SelectedRows[0].Index;
            int IdBook = Convert.ToInt32(dataGridViewBook[0, row].Value.ToString());

            /* textBoxTitle.Text = dataGridViewBook[1, row].Value.ToString();
            textBoxISBN.Text = dataGridViewBook[2, row].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBook[3, row].Value.ToString();
            int yearConvert = Convert.ToInt32(textBoxYearOfIssue.Text);
            int yearConvert2 = Convert.ToInt32(dataGridViewBook[4, row].Value.ToString());
            yearConvert = yearConvert2;
            int quantityConvert = Convert.ToInt32(textBoxQuantity.Text);
            int quantityConvert2 = Convert.ToInt32(textBoxQuantity.Text);
            quantityConvert = quantityConvert2; */
            
        }

        private void textBoxSearchBooks_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewBook.SelectedRows[0].Index;

            textBoxTitle.Text = dataGridViewBook[1, row].Value.ToString();
            textBoxISBN.Text = dataGridViewBook[2, row].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBook[3, row].Value.ToString();


            int yearConvert = Convert.ToInt32(textBoxYearOfIssue.Text);
            int yearConvert2 = Convert.ToInt32(dataGridViewBook[4, row].Value.ToString());
            yearConvert = yearConvert2;
            int quantityConvert = Convert.ToInt32(textBoxQuantity.Text);
            int quantityConvert2 = Convert.ToInt32(textBoxQuantity.Text);
            quantityConvert = quantityConvert2;
        }
    }
}
