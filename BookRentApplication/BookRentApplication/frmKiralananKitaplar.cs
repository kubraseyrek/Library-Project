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
    public partial class frmKiralananKitaplar : Form
    {
        RentBLL _rentBLL;
        BookBLL _bookBLL;
        public frmKiralananKitaplar()
        {
            InitializeComponent();
            _bookBLL = new BookBLL();
        }

        private void frmKiralananKitaplar_Load(object sender, EventArgs e)
        {
             _rentBLL = new RentBLL();
            FillRentBook();


        }

        void FillRentBook()
        {
            List<Rent> kiralananKitaplar = _rentBLL.GetRentList();
            dgvKiralananKitaplar.DataSource = kiralananKitaplar;

        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvKiralananKitaplar.CurrentRow != null)
            {

                var row = dgvKiralananKitaplar.CurrentRow;
                int memberID = (int)row.Cells["RentID"].Value;
                Rent rent = _rentBLL.GetRentByID(memberID);
                Rent updateRent = new Rent();
                updateRent.RentID = rent.RentID;
                updateRent.BookID = rent.BookID;
                updateRent.MemberID = rent.MemberID;
                updateRent.PaymentID = rent.PaymentID;
                updateRent.RentDate = rent.RentDate;
                updateRent.RequiredDate = rent.RequiredDate;
                updateRent.DeliveryDate = DateTime.Now;
                _rentBLL.Update(updateRent);

                Book book=_bookBLL.GetBookByID(updateRent.BookID);
                _bookBLL.ActivateBook(book);
                FillRentBook();

            }
        }
    }
}
