using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Members
    {
        public int MemberID { get; set; }
        public int AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime MemberDate { get; set; }
        public bool IsActive { get; set; }

        public List<Book> MemberBooks { get; set; }
    }

}
