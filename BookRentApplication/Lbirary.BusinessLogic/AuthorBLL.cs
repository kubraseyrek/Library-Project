using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class AuthorBLL
    {
        AuthorDAL _authorDAL;
        public AuthorBLL()
        {
            _authorDAL = new AuthorDAL();
        }


        public bool AddAuthor(Author author)
        {
            try
            {
                CheckFirstName(author.FirstName);
                CheckLastName(author.LastName);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _authorDAL.Insert(author) > 0;
        }

        public bool Update(Author author)
        {
            try
            {

                CheckFirstName(author.FirstName);
                CheckLastName(author.LastName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _authorDAL.Update(author) > 0;
        }

        public bool Delete(int authorID)
        {

            return _authorDAL.Delete(authorID) > 0;
        }
        public List<Author> GetAuthorList()
        {
            return _authorDAL.GetAllAuthors();
        }

        public List<Author> GetAuthorListFullName()
        {
            return _authorDAL.GetAllAuthorsFullName();
        }

        private void CheckLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new NotImplementedException("Yazar soyadı boş geçilemez");
            }

        }

        private void CheckFirstName(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new NotImplementedException("Yazar adı boş geçilemez");
            }
        }
    }

}
