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
using Common.Interfaces.Business;
using BusinessLayer;

namespace PresentationLayer.UserControls
{
    public partial class Books : UserControl
    {
      
        enum Search { TITLE, AUTHOR }
        private readonly IBookBusiness bookBusiness;
        public Books()
        {
            InitializeComponent();
            comboBoxSortByBooks.DataSource = Enum.GetValues(typeof(Search));
            this.bookBusiness = new BookBusiness();

            buttonUpdateBooks.Enabled = false;
            buttonDeleteBooks.Enabled = false;
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
                if (this.bookBusiness.AddBook(ValidationBook) == true)
                {
                    MessageBox.Show("successfully");
                    RefreshTable();
                    SetTextBox();


                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }
        private void SetTextBox()
        {
            textBoxAuthorName.Text = "";
            textBoxAuthorName.Text = "";
            textBoxQuantity.Text = "";
            textBoxTitle.Text = "";
            textBoxISBN.Text = "";
            textBoxYearOfIssue.Text = "";
        }
        private void buttonUpdateBooks_Click(object sender, EventArgs e)
        {
            if(ErrorValidation())
            {
                Book book = new Book();
                int row = dataGridViewBook.SelectedRows[0].Index;
                book.IdBook = Convert.ToInt32(dataGridViewBook[0, row].Value.ToString());
                book.Title = textBoxTitle.Text;
                book.ISBN = textBoxISBN.Text;
                book.NameAuthor = textBoxAuthorName.Text;
                book.YearOfIssue = int.Parse(textBoxYearOfIssue.Text);
                book.Quantity = int.Parse(textBoxQuantity.Text);



                if (this.bookBusiness.UpdataBook(book) == true)
                {
                    MessageBox.Show("successfully");
                    RefreshTable();
                    SetTextBox();


                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }
        public int TestRowCount => dataGridViewBook.Rows.Count;
        private void buttonDeleteBooks_Click(object sender, EventArgs e)
        {
            int row = dataGridViewBook.SelectedRows[0].Index;
            int IdBook = Convert.ToInt32(dataGridViewBook[0, row].Value.ToString());

            textBoxTitle.Text = dataGridViewBook[1, row].Value.ToString();
            textBoxISBN.Text = dataGridViewBook[2, row].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBook[3, row].Value.ToString();
            textBoxYearOfIssue.Text = dataGridViewBook[4, row].Value.ToString();
            textBoxQuantity.Text = dataGridViewBook[5, row].Value.ToString();

            if (this.bookBusiness.DeleteBook(IdBook) == true)
            {
                MessageBox.Show("successfully");
                RefreshTable();
                SetTextBox();


            }
            else
            {
                MessageBox.Show("error");
            }


        }

        private void textBoxSearchBooks_KeyDown(object sender, KeyEventArgs e)
        {
            Book book = new Book();
            List<Book> listbook = null;
            string by = comboBoxSortByBooks.SelectedItem.ToString();
            if (by == "TITLE")
            {
                book.Title = textBoxSearchBooks.Text;
            listbook = this.bookBusiness.SearchBook(by, book);
            }
            else
            {
                book.NameAuthor = textBoxSearchBooks.Text;
                listbook = this.bookBusiness.SearchBook(by, book);
            }
            dataGridViewBook.Rows.Clear();
            for (int i = 0; i < listbook.Count; ++i)
            {
                dataGridViewBook.Rows.Add(listbook[i].IdBook,listbook[i].Title,
                    listbook[i].ISBN, listbook[i].NameAuthor, listbook[i].YearOfIssue, listbook[i].Quantity);
            }
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewBook.SelectedRows[0].Index;

            textBoxTitle.Text = dataGridViewBook[1, row].Value.ToString();
            textBoxISBN.Text = dataGridViewBook[2, row].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBook[3, row].Value.ToString();
            textBoxYearOfIssue.Text = dataGridViewBook[4, row].Value.ToString();
            textBoxQuantity.Text = dataGridViewBook[5, row].Value.ToString();

            buttonUpdateBooks.Enabled = !false;
            buttonDeleteBooks.Enabled = !false;
        }
        public void  RefreshTable()
        {
            //  dataGridViewBook.AutoGenerateColumns = false;
            //   dataGridViewBook.DataSource = this.bookBusiness.GetAllBooks().ToList();
            // dataGridViewBook.Columns[0].Visible = false;
            dataGridViewBook.Rows.Clear();
            List<Book> list = this.bookBusiness.GetAllBooks();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewBook.Rows.Add(list[i].IdBook,list[i].Title,
                    list[i].ISBN, list[i].NameAuthor, list[i].YearOfIssue, list[i].Quantity);
            }
            dataGridViewBook.Columns[0].Visible = false;
        }
        private void Books_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
