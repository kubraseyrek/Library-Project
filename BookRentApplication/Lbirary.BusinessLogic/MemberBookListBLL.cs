using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class MemberBookListBLL
    {

        MemberBookListDAL _memberBookListDAL;
        public MemberBookListBLL()
        {
            _memberBookListDAL = new MemberBookListDAL();
        }

        public bool AddBookMemberList(MemberBookList bookList)
        {
            try
            {
                CheckBookID(bookList.BookID);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _memberBookListDAL.Insert(bookList) > 0;
        }


        public bool Delete(int listID)
        {
            return _memberBookListDAL.Delete(listID) > 0;
        }

        public List<MemberBookList> GetMemberBookList(int memberID)
        {
            return _memberBookListDAL.MemberBookList(memberID);
        }


        private void CheckBookID(int bookID)
        {
            if (bookID < 1)
            {
                throw new Exception("Kitap seçimi yapmadınız");
            }
        }
    }
}


