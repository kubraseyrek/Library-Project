using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class AuthorDAL
    {
        DbHelper helper;
        public AuthorDAL()
        {
            helper = new DbHelper();
        }

        public int Insert(Author author)
        {
            helper.CommandText = "INSERT INTO Authors(FirstName,LastName) VALUES(@firstName,@lastName)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@firstName", author.FirstName);
            helper.Parameters.Add("@lastName", author.LastName);

            return helper.ExecuteQuery();
        }


        public int Update(Author author)
        {
            helper.CommandText = "UPDATE Authors SET FirstName=@firstName, LastName=@LastName WHERE AuthorID = @authorID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@firstName", author.FirstName);
            helper.Parameters.Add("@lastName", author.LastName);
            helper.Parameters.Add("@authorID", author.AuthorID);

            return helper.ExecuteQuery();
        }


        public int Delete(int authorID)
        {
            helper.CommandText = "DELETE FROM Authors WHERE AuthorID = @authorID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@authorID", authorID);

            return helper.ExecuteQuery();
        }

        public Author GetAuthorByID(int authorID)
        {
            helper.CommandText = "select * from Authors WHERE  AuthorID= @authorID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@authorID", authorID);

            Author author = null;
            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                author = MapAuthors(reader);
            }
            reader.Close();
            return author;
        }


        public List<Author> GetAllAuthors()
        {
            helper.CommandText = "select * from Authors";
            helper.Parameters.Clear();

            List<Author> authors = new List<Author>();

            Author author = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                author = MapAuthors(reader);
                authors.Add(author);
            }
            reader.Close();
            return authors;
        }

        public List<Author> GetAllAuthorsFullName()
        {
            helper.CommandText = "select AuthorID,FirstName+' '+LastName as FullName from Authors";
            helper.Parameters.Clear();

            List<Author> authors = new List<Author>();

            Author author = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                author = MapAuthorsFullName(reader);
                authors.Add(author);
            }
            reader.Close();
            return authors;
        }


        Author MapAuthors(SqlDataReader reader)
        {
            Author author = new Author();

            author.AuthorID = (int)reader["AuthorID"];
            author.FirstName = reader["FirstName"].ToString();
            author.LastName = reader["LastName"].ToString();

            return author;
        }
        Author MapAuthorsFullName(SqlDataReader reader)
        {
            Author author = new Author();

            author.AuthorID = (int)reader["AuthorID"];
            author.FullName = reader["FullName"].ToString();           

            return author;
        }

    }

}
