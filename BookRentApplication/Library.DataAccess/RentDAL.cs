using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class RentDAL
    {
        DbHelper helper;
        public RentDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Rent rent)
        {
            helper.CommandText = "INSERT INTO Rent(MemberID,BookID,RentDate,RequiredDate,DeliveryDate,PaymentID) VALUES(@memberID,@bookID,@rentDate,@requiredDate,@deliveryDate,@paymentID)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", rent.MemberID);
            helper.Parameters.Add("@bookID", rent.BookID);
            helper.Parameters.Add("@rentDate", DateTime.Now);
            helper.Parameters.Add("@requiredDate", DateTime.Now.AddDays(10));
            helper.Parameters.Add("@deliveryDate", rent.DeliveryDate);
            helper.Parameters.Add("@paymentID", rent.PaymentID);

            return helper.ExecuteQuery();
        }

        public int Update(Rent rent)
        {
            helper.CommandText = "UPDATE Rent SET MemberID=@memberID, BookID=@bookID, RentDate=@rentDate,RequiredDate=@requiredDate,DeliveryDate=@deliveryDate,PaymentID=@paymentID  WHERE RentID=@rentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", rent.MemberID);
            helper.Parameters.Add("@bookID", rent.BookID);
            helper.Parameters.Add("@rentDate", rent.RentDate);
            helper.Parameters.Add("@requiredDate", rent.RequiredDate);
            helper.Parameters.Add("@deliveryDate", rent.DeliveryDate);
            helper.Parameters.Add("@paymentID", rent.PaymentID);
            helper.Parameters.Add("@rentID", rent.RentID);

            return helper.ExecuteQuery();
        }
        public int Delete(int rentID)
        {
            helper.CommandText = "DELETE FROM Rent WHERE RentID=@rentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@rentID", rentID);
            return helper.ExecuteQuery();
        }
        public Rent GetRentByID(int rentID) //ıd ye göre uye alır 

        {
            helper.CommandText = "SELECT * FROM Rent WHERE RentID = @rentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@rentID", rentID);
            Rent rent = null;
            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                rent = MapRent(reader);
            }
            reader.Close();
            return rent;
        }

    

        public List<Rent> GetRentByMemberID(int memberID) //member ıd ye göre liste 

        {
            helper.CommandText = "SELECT * FROM Rent WHERE MemberID = @memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);
            List<Rent> rents = new List<Rent>();
            Rent rent = null;
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                rent = MapRent(reader);
                rents.Add(rent);
            }
            reader.Close();
            return rents;
        }
        public List<Rent> GetAllRents()

        {
            helper.CommandText = "SELECT * FROM Rent";
            helper.Parameters.Clear();
            List<Rent> rents = new List<Rent>();
            Rent rent = null;
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                rent = MapRent(reader);
                rents.Add(rent);
            }
            reader.Close();
            return rents;
        }

        public List<Rent> GetRentByBookID(int memberID) //book ıd ye göre liste ******sonradan düzenlenecek

        {
            helper.CommandText = "SELECT * FROM Rent WHERE MemberID = @memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);
            List<Rent> rents = new List<Rent>();
            Rent rent = null;
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                rent = MapRent(reader);
                rents.Add(rent);
            }
            reader.Close();
            return rents;
        }
        private Rent MapRent(SqlDataReader reader)
        {
            Rent rent = new Rent();
            rent.RentID = (int)reader["RentID"];
            rent.MemberID = (int)reader["MemberID"];
            rent.BookID = (int)reader["BookID"];
            rent.RentDate = (DateTime)reader["RentDate"];
            rent.RequiredDate = (DateTime)reader["RequiredDate"];
            rent.DeliveryDate = (DateTime)reader["DeliveryDate"];
            rent.PaymentID = (int)reader["PaymentID"];
            return rent;
        }

    }
}
