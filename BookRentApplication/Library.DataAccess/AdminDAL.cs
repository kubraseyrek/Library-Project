using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class AdminDAL
    {
        DbHelper helper;
        public AdminDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Admin admin)
        {
            helper.CommandText = "INSERT INTO Admins(FirstName,LastName,Mail,Password) VALUES(@firstName,@lastName,@mail,@pasword)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@firstName", admin.FirstName);
            helper.Parameters.Add("@lastName", admin.LastName);
            helper.Parameters.Add("@mail", admin.Mail);
            helper.Parameters.Add("@password", admin.Password);           
            return helper.ExecuteQuery();
        }
        public int AdminUpdate(Admin admin)
        {
            helper.CommandText = "UPDATE Admins SET FirstName=@firstName, LastName=@lastName, Password=@password WHERE AdminID=@adminID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@firstName", admin.FirstName);
            helper.Parameters.Add("@lastName", admin.LastName);
            helper.Parameters.Add("@password", admin.Password);
            return helper.ExecuteQuery();
        }
        public int Delete(int AdminID)
        {
            helper.CommandText = "DELETE FROM Admins WHERE AdminID=@adminID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@adminID", AdminID);
            return helper.ExecuteQuery();
        }
        public Admin GetAdminByID(int AdminID) //ıd ye göre admin alır
        {
            helper.CommandText = "SELECT * FROM Admins WHERE AdminID = @adminID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@adminID", AdminID);

            Admin admin = null;

            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                admin = MapAdmin(reader);
            }
            reader.Close();
            return admin;
        }
        public Admin GetAdminByMail(string mail)
        {
            helper.CommandText = "SELECT * FROM Admins WHERE Mail = @mail";

            helper.Parameters.Clear();
            helper.Parameters.Add("@mail", mail);

            Admin admin = null;
            SqlDataReader reader = helper.GetEntity();
            //return reader.HasRows;
            if (reader.HasRows)
            {
                reader.Read();
                admin = MapAdmin(reader);
            }
            reader.Close();
            return admin;
        }

        public List<Admin> GetAllAdmins() // butun adminleri getirir.
        {
            helper.CommandText = "SELECT * FROM Admins";
            helper.Parameters.Clear();

            List<Admin> admins = new List<Admin>();
            Admin admin = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                admin = MapAdmin(reader);
                admins.Add(admin);
            }
            reader.Close();
            return admins;
        }

        private Admin MapAdmin(SqlDataReader reader)
        {
            Admin admin = new Admin();

           
            admin.AdminID = (int)reader["AdminID"];
            admin.FirstName = reader["FirstName"].ToString();
            admin.LastName = reader["LastName"].ToString();
            admin.Mail = reader["Mail"].ToString();
            admin.Password = reader["Password"].ToString();           
            return admin;
        }

    }
}
