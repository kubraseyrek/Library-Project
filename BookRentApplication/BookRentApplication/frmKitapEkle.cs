using Library.BusinessLogic;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentApplication
{
    public partial class frmKitapEkle : Form
    {
        BookBLL _bookBLL;
        PublisherBLL _publisherBLL;
        AuthorBLL _authorBLL;


        public frmKitapEkle()
        {
            InitializeComponent();
            _bookBLL = new BookBLL();
            _publisherBLL = new PublisherBLL();
            _authorBLL = new AuthorBLL();
        }

        private void txtAuthorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            ComboGetAuthor();
            ComboGetPublisher();
            DataGridFillBookList();




        }
        void ComboGetAuthor()
        {
            cmbAuthorID.DisplayMember = "FullName";
            cmbAuthorID.ValueMember = "AuthorID";
            cmbAuthorID.DataSource = _authorBLL.GetAuthorListFullName();
        }

        void ComboGetPublisher()
        {
            cmbPublisherID.DisplayMember = "PublisherName";
            cmbPublisherID.ValueMember = "PublisherID";
            cmbPublisherID.DataSource = _publisherBLL.GetPublisherList();
        }
        void DataGridFillBookList()
        {
            dgvKitaplar.DataSource = _bookBLL.GetBookList();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            try
            {
                book.PublisherID = (int)cmbPublisherID.SelectedValue;
                book.AuthorID = (int)cmbAuthorID.SelectedValue;
                book.BookName = txtBookName.Text;
                book.Price = numPrice.Value;
                book.PublicationDate = dateTimePicker1.Value;
                book.Pages = (int)numPages.Value;
                book.Summary = txtSummary.Text;
                book.BookStatus = true;
                book.DamageStatus = false;
                _bookBLL.AddBook(book);
                DataGridFillBookList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.FirstName = txtAuthorNAme.Text;
            author.LastName = txtAuthorLastName.Text;
            _authorBLL.AddAuthor(author);
            ComboGetAuthor();
            MessageBox.Show("Yazar listeye Eklenmiştir.");
        }

        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            Library.Entities.Publisher publisher = new Library.Entities.Publisher();
            publisher.PublisherName = txtPublisherName.Text;
            _publisherBLL.AddPublisher(publisher);
            ComboGetPublisher();
            MessageBox.Show("Yayınevi listeye Eklenmiştir.");
        }
    }
}
