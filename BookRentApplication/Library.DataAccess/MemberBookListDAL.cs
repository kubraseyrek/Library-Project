using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class MemberBookListDAL
    {

        DbHelper helper;
        public MemberBookListDAL()
        {
            helper = new DbHelper();
        }

        public int Insert(MemberBookList bookList)
        {          
            helper.CommandText = "insert into MemberBookList (BookID,MemberID) values(@bookID,@memberID)";
            helper.Parameters.Clear();            
            helper.Parameters.Add("@bookID", bookList.BookID);
            helper.Parameters.Add("@memberID", bookList.MemberID);
            return helper.ExecuteQuery();
        }



        public int Delete(int listID)
        {

            helper.CommandText = "DELETE FROM MemberBookList WHERE ListID=@listID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@listID", listID);

            return helper.ExecuteQuery();
        }

        public List<MemberBookList> MemberBookList(int memberID)
        {

            helper.CommandText = @"select b.BookName 
                                from MemberBookList mbl
                                join Books b
                                on b.BookID = mbl.BookID
                                join Members m
                                on m.MemberID = mbl.MemberID
                                where mbl.MemberID = @memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);

            List<MemberBookList> books = new List<MemberBookList>();
            MemberBookList bookList = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                bookList = MapBook(reader);
                books.Add(bookList);
            }
            reader.Close();
            return books;
        }



        private MemberBookList MapBook(SqlDataReader reader) // book özelliklerini okurken kullanılan metot
        {
            MemberBookList booklist = new MemberBookList();

            //booklist.ListID = (int)reader["ListID"];
            //booklist.BookID = (int)reader["BookID"];
            //booklist.MemberID = (int)reader["MemberID"];
            booklist.book = new Book() { BookID = booklist.BookID, BookName = reader["BookName"].ToString() };
            return booklist;
        }
    }

}
