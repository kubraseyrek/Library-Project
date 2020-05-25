using Lbirary.BusinessLogic;
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
    public partial class frmAdmin : Form
    {
        DataTable dataTable;
        MemberBLL _memberBLL;
        public frmAdmin()
        {
            InitializeComponent();
        }

        public object RentBLL { get; private set; }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

             _memberBLL = new MemberBLL();
            FillMemberList();

            //RentBLL _rentBLL = new RentBLL();   kiralanan kitapların listelenmesi kpodu
            //List<Rent> kiralananListe = _rentBLL.GetRentList();
            //dgvKiralananKitaplar.DataSource = kiralananListe;
        }

        private void btnUyeAktif_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow!=null)
            {
               
                var row= dgvUyeler.CurrentRow;
                int memberID=(int)row.Cells["MemberID"].Value;
                Members member =_memberBLL.GetMember(memberID);
                _memberBLL.ActivateUser(member);
                FillMemberList();
            }
        }
        void FillMemberList()
        {
            List<Members> uyeListesi = _memberBLL.GetMemberList();

            dgvUyeler.DataSource = uyeListesi;
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            frmKitapEkle frmKitapEkle = new frmKitapEkle();
            frmKitapEkle.Show();
        }
    }
}
