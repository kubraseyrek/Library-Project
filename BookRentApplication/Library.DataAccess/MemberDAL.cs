using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
   public class MemberDAL
    {
        DbHelper helper;
        public MemberDAL()
        {
            helper = new DbHelper();
        }
        public int Insert(Members member)
        {
            helper.CommandText = "INSERT INTO Members(AdminID,FirstName,LastName,Mail,Password,MemberDate,IsActive) VALUES(@adminID,@firstName,@lastName,@mail,@password,@memberDate,@isActive)";
            helper.Parameters.Clear();
            helper.Parameters.Add("@adminID", member.AdminID);
            helper.Parameters.Add("@firstName", member.FirstName);
            helper.Parameters.Add("@lastName", member.LastName);
            helper.Parameters.Add("@mail", member.Mail);
            helper.Parameters.Add("@password", member.Password);
            helper.Parameters.Add("@memberDate", member.MemberDate);
            helper.Parameters.Add("@isActive", member.IsActive);

            return helper.ExecuteQuery();
        }

        public int MemberUpdate(Members member)
        {
            helper.CommandText = "UPDATE Members SET FirstName=@firstName, LastName=@lastName, Password=@password    WHERE MemberID=@memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@firstName", member.FirstName);
            helper.Parameters.Add("@lastName", member.LastName);
            helper.Parameters.Add("@password", member.Password);
            return helper.ExecuteQuery();
        }

        public int AdminUpdate(Members member )
        {
            helper.CommandText = "UPDATE Members SET IsActive=@isActive  WHERE MemberID=@memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@isActive", member.IsActive);
            helper.Parameters.Add("@memberID", member.MemberID);
            return helper.ExecuteQuery();
        }

        public int Delete(int memberID)
        {
            helper.CommandText = "DELETE FROM Members WHERE MemberID=@memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);
            return helper.ExecuteQuery();
        }
        //List<Members> memberBook = 
        public Members GetMemberByID(int memberID) //ıd ye göre uye alır
        {
            helper.CommandText = "SELECT * FROM Members WHERE MemberID = @memberID";
            helper.Parameters.Clear();
            helper.Parameters.Add("@memberID", memberID);

            Members member = null;

            SqlDataReader reader = helper.GetEntity();
            if (reader.HasRows)
            {
                reader.Read();
                member = MapMember(reader);
            }
            reader.Close();
            return member;
        }

        public List<Members> GetAllMembers() // butun uyeleri getimr
        {
            helper.CommandText = "SELECT * FROM Members";
            helper.Parameters.Clear();

            List<Members> members = new List<Members>();
            Members member = null;

            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                member = MapMember(reader);
                members.Add(member);
            }
            reader.Close();
            return members;
        }

        public Members GetMemberByMail(string mail, bool isLogin)
        {
            helper.CommandText = isLogin ? "SELECT * FROM Members WHERE Mail = @mail AND IsActive='True'" : "SELECT * FROM Members WHERE Mail = @mail";

            helper.Parameters.Clear();
            helper.Parameters.Add("@mail", mail);

            Members member = null;
            SqlDataReader reader = helper.GetEntity();
            //return reader.HasRows;
            if (reader.HasRows)
            {
                reader.Read();
                member = MapMember(reader);
            }
            reader.Close();
            return member;
        }


        public List<Members> BookMembers(int bookID)//kitabın uyeleri
        {
            //selectin yanında sadece member özl alınaca ilk kısım memberbooklist member join book joın where bookıd
            //string CommandText = "SELECT * FROM MemberBookList mb JOIN Members m ON mb.MemberID = h.HavuzID JOIN Kelime k ON k.KelimeID = hd.KelimeID WHERE b.HavuzID = @havuzID";
            helper.CommandText = ("SELECT b.BookID, m.MemberID, b.BookName, m.FirstName FROM MemberBookList mb JOIN Members m ON mb.MemberID= m.MemberID join Books b on b.BookID=mb.BookID where b.BookID=@bookID");
            helper.Parameters.Clear();
            helper.Parameters.Add("@bookID", bookID);
            //parameters.Add("@havuzID", havuzID);
            List<Members> memberList = new List<Members>();
            Members member = null;
            //SqlDataReader reader = helper.ExecuteReader(commandText, parameters);
            SqlDataReader reader = helper.GetEntity();
            while (reader.Read())
            {
                member = MapMember(reader);
                memberList.Add(member);
            }
            return memberList;
        }


        private Members MapMember(SqlDataReader reader)
        {
            Members member = new Members();

            member.MemberID = (int)reader["MemberID"];
            member.AdminID= (int)reader["AdminID"];
            member.FirstName = reader["FirstName"].ToString();
            member.LastName = reader["LastName"].ToString();
            member.Mail= reader["Mail"].ToString();
            member.Password =reader["Password"].ToString();
            member.MemberDate = (DateTime)reader["MemberDate"];
            member.IsActive = (bool)reader["IsActive"];
            return member;
        }
    }
}
