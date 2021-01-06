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
    public partial class ReturnBook : UserControl
    {
        private readonly IBookBusiness bookBusiness;
        private readonly IUserBusiness userBusiness;
        enum FindBy { NAME, SURNAME }
        public ReturnBook()
        {

            InitializeComponent();
            this.bookBusiness = new BookBusiness();
            this.userBusiness = new UserBusiness();
            comboBoxReturnUsertBy.DataSource = Enum.GetValues(typeof(FindBy));
            buttonReturnBook.Enabled = false;
        }
       
        private void dataGridViewReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridViewReturn.SelectedRows[0].Index;

          

            textBoxReturnBookJmbg.Text = dataGridViewReturn[0, row].Value.ToString();
            textBoxReturnBookName.Text = dataGridViewReturn[1, row].Value.ToString();
            textBoxReturnBookSurname.Text = dataGridViewReturn[2, row].Value.ToString();

            textBoxReturnBookTitle.Text = dataGridViewReturn[4, row].Value.ToString();
            buttonReturnBook.Enabled = true;
            textBoxReturnBookJmbg.Enabled = !false;
            textBoxReturnBookName.Enabled = !false;
            textBoxReturnBookSurname.Enabled = !false;
            textBoxReturnBookTitle.Enabled = !false;
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            int row = dataGridViewReturn.SelectedRows[0].Index;

            Book book = new Book();
            string JmbgUser = dataGridViewReturn[0, row].Value.ToString();

            book.IdBook = int.Parse(dataGridViewReturn[3, row].Value.ToString());
            book.Title = dataGridViewReturn[4, row].Value.ToString();
            book.NameAuthor = dataGridViewReturn[5, row].Value.ToString();

            if (this.bookBusiness.ReturnBook(JmbgUser, book) == true)
            {
                MessageBox.Show("successfully");
                ReffresTable();
            }
            else
                MessageBox.Show("error");

        }

        
        private void ReffresTable()
        {
            dataGridViewReturn.Rows.Clear();
            List<User> lisuser = null;
            List<Rented> listrented = null;
            foreach (var iter in this.bookBusiness.GetAllBookRentedUsers())
            {
                lisuser = iter.Item2.ToList();
                listrented = iter.Item1.ToList();
            }
            for (int i = 0; i < lisuser.Count && i < listrented.Count; i++)
            {
                dataGridViewReturn.Rows.Add(lisuser[i].JmbgUser, lisuser[i].Name,
                    lisuser[i].Surname, listrented[i].IdBook, listrented[i].Title,
                    listrented[i].NameAuthor, listrented[i].Quantity, listrented[i].DateOfIssue,
                    listrented[i].ReturnDate);
            }
            
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            ReffresTable();
            dataGridViewReturn.Columns[3].Visible = false;
            dataGridViewReturn.Columns[6].Visible = false;
            textBoxReturnBookJmbg.Enabled = false;
            textBoxReturnBookName.Enabled = false;
            textBoxReturnBookSurname.Enabled = false;
            textBoxReturnBookTitle.Enabled = false;


        }

        private void textBoxReturnUserSearch_KeyDown(object sender, KeyEventArgs e)
        {
            List<User> lisuser = null;
            List<Rented> listrented = null;
            foreach (var iter in this.bookBusiness.GetAllBookRentedUsers())
            {
                lisuser = iter.Item2.ToList();
                listrented = iter.Item1.ToList();
            }

            string by = comboBoxReturnUsertBy.SelectedItem.ToString();
            if (by == "NAME")
            {
                User user = new User();
                user.Name = textBoxReturnUserSearch.Text;

                lisuser = userBusiness.SearchUser(by, user).ToList();
            }
            else if (by == "SURNAME")
            {
                User user = new User();
                user.Surname = textBoxReturnUserSearch.Text;

                lisuser = userBusiness.SearchUser(by, user).ToList();
            }
            ReffresTable();
        }
    }
}
