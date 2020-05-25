using Library.BusinessLogic;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentApplication
{
    public partial class frmAdminRegister : Form
    {
        AdminBLL _adminBLL;
        public frmAdminRegister()
        {
            InitializeComponent();
            _adminBLL = new AdminBLL();
        }

        private void frmAdminRegister_Load(object sender, EventArgs e)
        {
            FillAdminList();
        }

        private void FillAdminList()
        {
           dgvAdminListe.DataSource= _adminBLL.GetAdminList();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtRepassword.Text)
            {
                Admin admin = new Admin();
                admin.FirstName = txtFirstName.Text;
                admin.LastName = txtLastName.Text;
                admin.Mail = txtMail.Text;
                admin.Password = txtPassword.Text;
                _adminBLL.AddAdmin(admin);
                FillAdminList();
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmamaktadır.");
            }
           
            }

        private void frmAdminRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
