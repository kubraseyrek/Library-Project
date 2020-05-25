using Lbirary.BusinessLogic;
using Library.DataAccess;
using Library.DTO;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class MemberBLL
    {

        MemberDAL _memberDAL;
        public MemberBLL()
        {
            _memberDAL = new MemberDAL();
        }

        public bool AddMember(Members member)
        {
            try
            {
                CheckRequiredFields(member.FirstName, member.LastName);
                CheckLength(member.FirstName, member.LastName);
                CheckMail(member.Mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            member.IsActive = false;
            return _memberDAL.Insert(member) > 0;
        }


        public bool Update(Members member, bool checkMaiFlag = true)
        {
            try
            {
                CheckRequiredFields(member.FirstName, member.LastName);
                CheckLength(member.FirstName, member.LastName);
                if (checkMaiFlag)
                {
                    CheckMail(member.Mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _memberDAL.MemberUpdate(member) > 0;
        }
        public bool UpdatebyAdmin(Members member, bool checkMaiFlag = true)
        {
            try
            {
                //CheckRequiredFields(member.FirstName, member.LastName);
                //CheckLength(member.FirstName, member.LastName);
                if (checkMaiFlag)
                {
                    CheckMail(member.Mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _memberDAL.AdminUpdate(member) > 0;
        }

        public bool ActivateUser(Members member)
        {
            member.IsActive = true;
            return _memberDAL.AdminUpdate(member) > 0;
        }

        public bool Delete(int memberID)
        {
            return _memberDAL.Delete(memberID) > 0;
        }

        public bool Delete(Members member)
        {
            member.IsActive = false;
            return _memberDAL.AdminUpdate(member) > 0;
        }

        public Members GetMember(int memberID)
        {
            return _memberDAL.GetMemberByID(memberID);
        }

        public Members GetMember(LoginDTO login)
        {
            return _memberDAL.GetMemberByMail(login.Mail, true);
        }

        public Members GetMember(string mail)
        {
            return _memberDAL.GetMemberByMail(mail, false);
        }

        public List<Members> GetMemberList()
        {
            return _memberDAL.GetAllMembers();
        }

        void CheckRequiredFields(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new RequiredException("İsim");
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new RequiredException("Soyisim");
            }
        }

        void CheckMail(string mail, bool checkMailFlag = true)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                throw new RequiredException("Mail");
            }

            try
            {
                MailAddress address = new MailAddress(mail);
            }
            catch
            {
                throw new Exception("Mail düzgün formatta değil");
            }

            if (_memberDAL.GetMemberByMail(mail, false) != null)
            {
                throw new Exception("Bu mail adresi sistemde kayıtlı");
            }
        }

        void CheckLength(string name, string surname)
        {
            if (name.Length > 20)
            {
                throw new Exception("İsim alanı 20 karakterden fazla olamaz");
            }
            if (surname.Length > 30)
            {
                throw new Exception("Soyisim alanı 30 karakterden fazla olamaz");
            }
        }


        public void CheckTextBox(string mail, string password)
        {
            if (string.IsNullOrWhiteSpace(mail))
            {
                throw new RequiredException("mail");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new RequiredException("password");
            }
        }


    }

}
