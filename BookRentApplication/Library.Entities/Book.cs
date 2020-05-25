using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public int PublisherID { get; set; }
        public int AuthorID { get; set; }
        public string BookName { get; set; }
        public int Pages { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Summary { get; set; }
        public bool DamageStatus { get; set; }
        public decimal Price { get; set; }
        public bool BookStatus { get; set; }
        public List<Members> BookMembers { get; set; }
    }
}
