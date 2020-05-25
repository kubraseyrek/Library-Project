using Lbirary.BusinessLogic;
using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class AdminBLL
    {
        AdminDAL _adminDAL;
        public AdminBLL()
        {
            _adminDAL = new AdminDAL();
        }

        public bool AddAdmin(Admin admin)
        {
            try
            {
                CheckRequiredFields(admin.FirstName, admin.LastName);
                CheckLength(admin.FirstName, admin.LastName);
                CheckMail(admin.Mail);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return _adminDAL.Insert(admin) > 0;
        }


        public bool Update(Admin admin, bool checkMaiFlag = true)
        {
            try
            {
                CheckRequiredFields(admin.FirstName, admin.LastName);
                CheckLength(admin.FirstName, admin.LastName);
                if (checkMaiFlag)
                {
                    CheckMail(admin.Mail);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _adminDAL.AdminUpdate(admin) > 0;
        }

        public bool Delete(int adminID)
        {
            return _adminDAL.Delete(adminID) > 0;
        }

        public Admin GetAdmin(int adminID)
        {
            return _adminDAL.GetAdminByID(adminID);
        }
        public Admin GetAdmin(string mail)
        {
            return _adminDAL.GetAdminByMail(mail);
        }

        public List<Admin> GetAdminList()
        {
            return _adminDAL.GetAllAdmins();
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

            if (_adminDAL.GetAdminByMail(mail) != null)
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
    }

}
