using Library.BusinessLogic;
using Library.DTO;
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
    public partial class frmLogin : Form
    {
        MemberBLL _memberBLL;
        public frmLogin()
        {
            InitializeComponent();
            _memberBLL = new MemberBLL();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            LoginDTO login = new LoginDTO();
            login.Mail = txtMail.Text;
            login.Password = txtPassword.Text;
            try
            {
               
                    _memberBLL.CheckTextBox(txtMail.Text, txtPassword.Text);
                

                Members member = _memberBLL.GetMember(login);
                if (member != null)
                {
                    if (member.Mail == login.Mail && member.Password == login.Password)
                    {
                        frmMember memberForm = new frmMember();
                        memberForm.Owner = this;
                        memberForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Şifre");
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show("Mail Bilgisi Yanlış");
                    ClearTextBox();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearTextBox();
            }
            

        }

        private void ClearTextBox()
        {
            txtMail.Clear();
            txtPassword.Clear();
        }

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Owner = this;
            register.Show();
            this.Hide();


        }
    }
}
