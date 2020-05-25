using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
   public class BookDAL
    {
        DbHelper helper;
        public BookDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Book book)
        {
            helper.CommandText = "INSERT INTO Books(PublisherID,AuthorID,BookName,Pages,PublicationDate,Summary,DamageStatus,Price,BookStatus) VALUES(@publisherID,@authorID,@bookName,@pages,@publicDate,@summary,@damageStatus,@price,@bookStatus)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherID", book.PublisherID);
            helper.Parameters.Add("@authorID", book.AuthorID);
            helper.Parameters.Add("@bookName", book.BookName);
            helper.Parameters.Add("@pages", book.Pages);
            helper.Parameters.Add("@publicDate", book.PublicationDate);
            helper.Parameters.Add("@summary", book.Summary);
            helper.Parameters.Add("@damageStatus", book.DamageStatus);
            helper.Parameters.Add("@price", book.Price);
            helper.Parameters.Add("@bookStatus", book.BookStatus);

            return helper.ExecuteQuery();
        }
        public int Update(Book book)
        {
            helper.CommandText = "UPDATE Books SET PublisherID=@publisherID, AuthorID=@authorID, BookName=@bookName, Pages=@pages, PublicationDate=@publicDate, Summary=@summary, DamageStatus=@damageStatus, Price=@price, BookStatus=@bookStatus  WHERE BookID=@bookID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherID", book.PublisherID);
            helper.Parameters.Add("@authorID", book.AuthorID);
            helper.Parameters.Add("@bookName", book.BookName);
            helper.Parameters.Add("@pages", book.Pages);
            helper.Parameters.Add("@publicDate", book.PublicationDate);
            helper.Parameters.Add("@summary", book.Summary);
            helper.Parameters.Add("@damageStatus", book.DamageStatus);
            helper.Parameters.Add("@price", book.Price);
            helper.Parameters.Add("@bookStatus", book.BookStatus);

            return helper.ExecuteQuery();
        }

        public int BookUpdate(Book book)
        {
            helper.CommandText = "UPDATE Book SET IsActive=@isActive  WHERE BookID=@bookID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@isActive", book.BookStatus);
            helper.Parameters.Add("@memberID", book.BookID);
            return helper.ExecuteQuery();
        }
        public int Delete(int bookID)
        {
            helper.CommandText = "DELETE FROM Books WHERE BookID=@bookID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@bookID", bookID);

            return helper.ExecuteQuery();
        }

        public Book GetBookByID(int bookID)
        {
            helper.CommandText = "SELECT * FROM Books WHERE BookID = @bookID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@bookID", bookID);

            Book book = null;

            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                book = MapBook(reader);
            }
            reader.Close();
            return book;
        }
        public List<Book> GetAllBooks()
        {
            helper.CommandText = "SELECT * FROM Books";
            helper.Parameters.Clear();

            List<Book> books = new List<Book>();
            Book book = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                book = MapBook(reader);
                books.Add(book);
            }
            reader.Close();
            return books;
        }
        public List<Book> GetAllBooks(int memberID) // ID ye göre kitap list
        {
            helper.CommandText = "SELECT * FROM MemberBookList WHERE MemberID = @memberID AND IsActive='True'";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);

            List<Book> books = new List<Book>();
            Book book = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                book = MapBook(reader);
                books.Add(book);
            }
            reader.Close();
            return books;
        }

        public List<Book> GetAllRentBooks(int memberID) // ID ye göre kitap list kiraladığı
        {
            helper.CommandText = "SELECT * FROM Rent WHERE MemberID = @memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);

            List<Book> books = new List<Book>();
            Book book = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                book = MapBook(reader);
                books.Add(book);
            }
            reader.Close();
            return books;
        }

        public List<Book> MemberBooks(int memberID)//kitabın uyeleri
        {
            //selectin yanında sadece member özl alınaca ilk kısım memberbooklist member join book joın where bookıd
            //string CommandText = "SELECT * FROM MemberBookList mb JOIN Members m ON mb.MemberID = h.HavuzID JOIN Kelime k ON k.KelimeID = hd.KelimeID WHERE b.HavuzID = @havuzID";
            helper.CommandText = ("SELECT b.BookID, m.MemberID, b.BookName, m.FirstName FROM MemberBookList mb JOIN Members m ON mb.MemberID= m.MemberID join Books b on b.BookID=mb.BookID where m.MemberID=@memberID");
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);
            //parameters.Add("@havuzID", havuzID);
            List<Book> booksList = new List<Book>();
            Book book = null;
            //SqlDataReader reader = helper.ExecuteReader(commandText, parameters);
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                book = MapBook(reader);
                booksList.Add(book);
            }
            return booksList;
        }



        private Book MapBook(SqlDataReader reader) // book özelliklerini okurken kullanılan metot
        {
            Book book = new Book();

            book.BookID = (int)reader["BookID"];
            book.PublisherID = (int)reader["PublisherID"];
            book.AuthorID =(int)reader["AuthorID"];
            book.BookName = reader["BookName"].ToString();
            book.Pages = (int)reader["Pages"];
            book.PublicationDate = (DateTime)reader["PublicationDate"];
            book.Summary =reader["Summary"].ToString();
            book.DamageStatus = (bool)reader["DamageStatus"];
            book.Price = (decimal)reader["Price"];
            book.BookStatus = (bool)reader["BookStatus"];
            return book;
        }
    }
}
