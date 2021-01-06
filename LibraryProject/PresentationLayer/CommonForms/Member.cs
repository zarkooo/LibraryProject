using BusinessLayer;
using Common.Interfaces.Business;
using Common.Models;
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

        private readonly IBookBusiness bookBusiness;
        private readonly IUserBusiness userBusiness;
        public Member(string NameUser)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comboBoxBookSearchBy.DataSource = Enum.GetValues(typeof(Search));
            this.bookBusiness = new BookBusiness();
            this.userBusiness = new UserBusiness();
            string s = "";
            DateTime dateTime = DateTime.Now;
            if (dateTime.Hour <= 12)
                s = "Good morning";
            else if (dateTime.Hour > 12 && dateTime.Hour <= 18)
                s = "Good afternoon";
            else
                s = "Good evening";
            labelUserNames.Text = s+", " +NameUser;


         
        }

       

        private void textBoxBookSearch_KeyDown(object sender, KeyEventArgs e)
        {
            Book book = new Book();
            List<Book> list = null;
            string by = comboBoxBookSearchBy.SelectedItem.ToString();
            if (by == "TITLE")
            {
                book.Title = textBoxBookSearch.Text;
                list = this.bookBusiness.SearchBook(by, book);
            }
            else
            {
                book.NameAuthor = textBoxBookSearch.Text;
                list = this.bookBusiness.SearchBook(by, book);
            }
            dataGridViewBook.Rows.Clear();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewBook.Rows.Add(list[i].Title,
                    list[i].ISBN, list[i].NameAuthor, list[i].YearOfIssue, list[i].Quantity);
            }
        }
        private void LoadTable()
        {
          
            List<Book> list = this.bookBusiness.GetAllBooks();
            for (int i = 0; i < list.Count; ++i)
            {
                dataGridViewBook.Rows.Add(list[i].Title,
                    list[i].ISBN, list[i].NameAuthor, list[i].YearOfIssue, list[i].Quantity);
            }
            
        }
        private void Member_Load(object sender, EventArgs e)
        {

            LoadTable();

        }
    }
}
