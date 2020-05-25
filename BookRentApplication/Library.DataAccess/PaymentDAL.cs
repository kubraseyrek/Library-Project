using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class PaymentDAL
    {
        DbHelper helper;
        public PaymentDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Payment payment)
        {
            helper.CommandText = "INSERT INTO Payment (PaymentType) VALUES(@paymentType)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@paymentType", payment.PaymentType);
            return helper.ExecuteQuery();
        }
        public int Update(Payment payment)
        {
            helper.CommandText = "UPDATE Payment SET PaymentType=@paymentType WHERE PaymentID=@paymentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@paymentType", payment.PaymentType);
            return helper.ExecuteQuery();
        }

        public int Delete(int paymentID)
        {
            helper.CommandText = "DELETE FROM Payment WHERE PaymentID=@paymentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@paymentID", paymentID);
            return helper.ExecuteQuery();
        }
        public Payment GetPaymentByID(int paymentID)

        {
            helper.CommandText = "SELECT * FROM Payment WHERE PaymentID = @paymentID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@paymentID", paymentID);
            Payment payment = null;
            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                payment = MapPayment(reader);
            }
            reader.Close();
            return payment;
        }
        public List<Payment> GetAllPayment()

        {
            helper.CommandText = "SELECT * FROM Payment";
            helper.Parameters.Clear();
            List<Payment> payments = new List<Payment>();
            Payment payment = null;
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                payment = MapPayment(reader);
                payments.Add(payment);
            }
            reader.Close();
            return payments;
        }
        private Payment MapPayment(SqlDataReader reader)
        {
            Payment payment = new Payment();
            payment.PaymentID = (int)reader["PaymentID"];
            payment.PaymentType = reader["PaymentType"].ToString();
            return payment;
        }

    }
}
