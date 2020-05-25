using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Rent
    {
        public int RentID { get; set; }
        public int MemberID { get; set; }
        public int BookID { get; set; }
        public int PaymentID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        
    }

}
