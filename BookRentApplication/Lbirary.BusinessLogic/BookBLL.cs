using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class BookBLL
    {
        BookDAL _bookDAL;

        public BookBLL()
        {
            _bookDAL = new BookDAL();
        }

        public bool AddBook(Book book)
        {
            try
            {
                CheckAuthorID(book.AuthorID);
                CheckPublisherID(book.PublisherID);
                CheckBookName(book.BookName);
                CheckPages(book.Pages);
                CheckPublicationDate(book.PublicationDate);
                CheckSummary(book.Summary);
                CheckDamageStatus(book.DamageStatus);
                CheckPrice(book.Price);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _bookDAL.Insert(book) > 0;
        }

        public bool Update(Book book)
        {
            try
            {
                CheckAuthorID(book.AuthorID);
                CheckPublisherID(book.PublisherID);
                CheckBookName(book.BookName);
                CheckPages(book.Pages);
                CheckPublicationDate(book.PublicationDate);
                CheckSummary(book.Summary);
                CheckDamageStatus(book.DamageStatus);
                CheckPrice(book.Price);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _bookDAL.Update(book) > 0;
        }


        public bool Delete(Book book) // hoca burda silmeyip aktifliğini false yapıyordu acaba biz silsek mi direkt
        {
            book.BookStatus = false;
            return _bookDAL.Update(book) > 0;
        }


        public bool ActivateBook(Book book)
        {
            book.BookStatus = true;
            return _bookDAL.BookUpdate(book) > 0;
        }

        public Book GetBookByID(int bookID)
        {
            return _bookDAL.GetBookByID(bookID);
        }

        public List<Book> GetBookList()
        {
            return _bookDAL.GetAllBooks();
        }

        public List<Book> GetBookListByUser(int memberID)
        {
            return _bookDAL.GetAllBooks(memberID);
        }


        void CheckBookName(string bookName)
        {
            if (string.IsNullOrWhiteSpace(bookName))
            {
                throw new Exception("Kitap adı boş geçilemez");
            }

            if (bookName.Length > 50)
            {
                throw new Exception("Başlık 50 karakterden fazla olamaz");
            }
        }


        private void CheckPrice(decimal price)
        {
            if (price == 0)
            {
                throw new Exception("Kitap fiyatı boş geçilemez");
            }
        }

        private void CheckDamageStatus(bool damageStatus)
        {
            if (damageStatus != false && damageStatus != true)
            {
                throw new Exception("Kitabın hasar durumu bilgisi boş geçilemez");
            }
        }

        private void CheckSummary(string summary)
        {
            if (summary.Length > 500)
            {
                throw new Exception("Özet 500 karakterden fazla olamaz");
            }
        }

        private void CheckPublicationDate(DateTime publicationDate)
        {
            if (publicationDate == null)
            {
                throw new Exception("Kitabın basım yılı bilgisi boş geçilemez");
            }
        }

        private void CheckPages(int pages)
        {
            if (pages < 0)
            {
                throw new NotImplementedException("Kitabın sayfa sayısı bilgisi 0 dan büyük olmalıdır.");
            }

        }


        private void CheckPublisherID(int publisherID)
        {
            if (publisherID <= 0)
            {
                throw new NotImplementedException("Kitabın yayın evi bilgisi olmalıdır");
            }

        }
        private void CheckAuthorID(int authorID)
        {
            if (authorID <= 0)
            {
                throw new NotImplementedException("Kitabın yazar bilgisi olmalıdır");
            }

        }

    }


}
