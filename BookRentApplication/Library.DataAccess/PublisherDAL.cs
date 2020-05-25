using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class PublisherDAL
    {
        DbHelper helper;
        public PublisherDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Publisher publisher)
        {
            helper.CommandText = "INSERT INTO Publishers VALUES(@publisherName)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherName", publisher.PublisherName);           
            return helper.ExecuteQuery();
        }
        public int PublisherUpdate(Publisher publisher)
        {
            helper.CommandText = "UPDATE Publishers SET PublisherName=@publisherName  WHERE PublisherID=@publisherID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherName", publisher.PublisherName);
            return helper.ExecuteQuery();
        }
        public int Delete(int publisherID)
        {
            helper.CommandText = "DELETE FROM Publishers WHERE PublisherID=@publisherID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherID", publisherID);
            return helper.ExecuteQuery();
        }

        public Publisher GetPublisherByID(int publisherID) //ıd ye göre publisher alır
        {
            helper.CommandText = "SELECT * FROM Publishers WHERE PublisherID = @publisherID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@publisherID", publisherID);

            Publisher publisher = null;

            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                publisher = MapPublisher(reader);
            }
            reader.Close();
            return publisher;
        }
        public List<Publisher> GetAllPublishers() // butun publisherları getirme
        {
            helper.CommandText = "SELECT * FROM Publishers";
            helper.Parameters.Clear();

            List<Publisher> publishers = new List<Publisher>();
            Publisher publisher = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                publisher = MapPublisher(reader);
                publishers.Add(publisher);
            }
            reader.Close();
            return publishers;
        }
        private Publisher MapPublisher(SqlDataReader reader)
        {
            Publisher publisher = new Publisher();

            publisher.PublisherID = (int)reader["PublisherID"];
            publisher.PublisherName = reader["PublisherName"].ToString();
            
            return publisher;
        }

    }
}
