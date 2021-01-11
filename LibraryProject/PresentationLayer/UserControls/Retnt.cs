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
    public partial class Retnt : UserControl
    {
        enum Search { TITLE, AUTHOR }
        enum ByUser { NAME,SURNAME}
        private readonly IBookBusiness bookBusiness;
        private readonly IUserBusiness userBusiness;
        public Retnt()
        {
            InitializeComponent();
            this.bookBusiness = new BookBusiness();
            this.userBusiness = new UserBusiness();
            comboBoxUserBy.DataSource = Enum.GetValues(typeof(ByUser));
            comboBoxBooksBy.DataSource = Enum.GetValues(typeof(Search));
            buttonIssue.Enabled = false;
        }

        private void textBoxUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string by =comboBoxUserBy.SelectedItem.ToString();
            List<User> listuser = null;
            if (by == "NAME")
            {
                User user = new User();
                user.Name = textBoxUserSearch.Text;
                listuser = this.userBusiness.SearchUser(by, user).ToList();
            }
            else if (by == "SURNAME")
            {
                User user = new User();
                user.Surname = textBoxUserSearch.Text;
                listuser = this.userBusiness.SearchUser(by, user).ToList();
            }
            dataGridViewUser.Rows.Clear();
          
            for (int i = 0; i < listuser.Count; ++i)
            {
                dataGridViewUser.Rows.Add(listuser[i].JmbgUser, listuser[i].Name,
                    listuser[i].Surname, listuser[i].Email, listuser[i].Password, listuser[i].Role);
            }
        }


        private void textBoxBooksSearch_KeyDown(object sender, KeyEventArgs e)
        {
            List<Book> lisbook = null;
            string by = comboBoxBooksBy.SelectedItem.ToString();
            if (by == "TITLE")
            {
                Book book = new Book();
                book.Title = textBoxBooksSearch.Text;
                lisbook = this.bookBusiness.SearchBook(by, book);
            }
            else if (by == "AUTHOR")
            {
                Book book = new Book();
                book.NameAuthor = textBoxBooksSearch.Text;
                lisbook = this.bookBusiness.SearchBook(by, book);
            }
            dataGridViewBooks.Rows.Clear();
          
            for (int i = 0; i < lisbook.Count; ++i)
            {
                dataGridViewBooks.Rows.Add(lisbook[i].IdBook, lisbook[i].Title,
                     lisbook[i].ISBN, lisbook[i].NameAuthor, lisbook[i].YearOfIssue, lisbook[i].Quantity);
            }
            dataGridViewBooks.Columns[0].Visible = false;

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewUser.SelectedRows[0].Index;

                textBoxJmbgUser.Text = dataGridViewUser[0, row].Value.ToString();
                textBoxNameUser.Text = dataGridViewUser[1, row].Value.ToString();
                textBoxSurnameUser.Text = dataGridViewUser[2, row].Value.ToString();
            }
            catch { MessageBox.Show("You must select a row, not a column!"); }

            textBoxJmbgUser.Enabled = !false;
            textBoxSurnameUser.Enabled = !false;
            textBoxNameUser.Enabled = !false;
        }

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonIssue.Enabled = true;
            try
            {
                int row = dataGridViewBooks.SelectedRows[0].Index;
                textBoxTitleBooks.Text = dataGridViewBooks[1, row].Value.ToString();
            }
            catch { MessageBox.Show("You must select a row, not a column!"); }
           
            textBoxTitleBooks.Enabled = !false;


        }
       
        private void buttonIssue_Click(object sender, EventArgs e)
        {
            
            int row1 = dataGridViewUser.SelectedRows[0].Index;
            int row2 = dataGridViewBooks.SelectedRows[0].Index;

            string Jmbg = dataGridViewUser[0, row1].Value.ToString();
          
            Rented rented = new Rented();
            rented.IdBook = int.Parse(dataGridViewBooks[0, row2].Value.ToString());
            rented.Title = dataGridViewBooks[1, row2].Value.ToString();
            
            rented.NameAuthor = dataGridViewBooks[3, row2].Value.ToString();
           
            rented.DateOfIssue = DateTime.Parse(dateTimePickerDateOfIssue.Value.ToString());

            rented.ReturnDate = DateTime.Parse(dateTimePickerReturnBooks.Value.ToString());
            




            if (this.bookBusiness.RentedBook(Jmbg, rented) == true)
            {
                MessageBox.Show("successfully");
                LoadTableBooks();
                LoadTableUser();
                SetTextBox();

            }
            else
                MessageBox.Show("error");
         
            

        }
        private void SetTextBox()
        {
            textBoxJmbgUser.Text = "";
            textBoxNameUser.Text = "";
            textBoxSurnameUser.Text = "";
            textBoxTitleBooks.Text = "";
        }

       
        private void LoadTableUser()
        {
            dataGridViewUser.Rows.Clear();
            List<User> list = this.userBusiness.GetAllUsers();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewUser.Rows.Add(list[i].JmbgUser, list[i].Name,
                    list[i].Surname, list[i].Email, list[i].Password, list[i].Role);
            }
        }
        private void LoadTableBooks()
        {
            dataGridViewBooks.Rows.Clear();
            List<Book> list = this.bookBusiness.GetAllBooks();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewBooks.Rows.Add(list[i].IdBook, list[i].Title,
                    list[i].ISBN, list[i].NameAuthor, list[i].YearOfIssue, list[i].Quantity);
            }
            dataGridViewBooks.Columns[0].Visible = false;
        }

        private void Retnt_Load(object sender, EventArgs e)
        {
            LoadTableUser();
            LoadTableBooks();
            



            textBoxJmbgUser.Enabled = false;
            textBoxSurnameUser.Enabled = false;
            textBoxNameUser.Enabled = false;
            textBoxTitleBooks.Enabled = false;
        }
    }
}
