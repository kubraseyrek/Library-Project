using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class PublisherBLL
    {
        PublisherDAL _publisherDAL;

        public PublisherBLL()
        {
            _publisherDAL = new PublisherDAL();
        }

        public bool AddPublisher(Publisher publisher)
        {
            try
            {
                CheckName(publisher.PublisherName);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _publisherDAL.Insert(publisher) > 0;
        }

        public bool Update(Publisher publisher)
        {
            try
            {
                CheckName(publisher.PublisherName);               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _publisherDAL.PublisherUpdate(publisher) > 0;
        }

        public bool Delete(int publisherID)
        {
           
            return _publisherDAL.Delete(publisherID) > 0;
        }

        public Publisher GetPublisherByID(int publisherID)
        {
            return _publisherDAL.GetPublisherByID(publisherID);
        }

        public List<Publisher> GetPublisherList()
        {
            return _publisherDAL.GetAllPublishers();
        }
        /*public List<Publisher> GetPublisherListByBook(int bookID)
        {
            return _publisherDAL.GetAllPublishers();
        }*/

        void CheckName(string PublisherName)
        {
            if (string.IsNullOrWhiteSpace(PublisherName))
            {
                throw new Exception("Yayınevi  boş geçilemez");
            }

            if (PublisherName.Length > 50)
            {
                throw new Exception("Yayınevi adı 50 karakterden fazla olamaz");
            }
        }       
    }
}
