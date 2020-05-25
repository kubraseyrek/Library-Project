using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BusinessLogic
{
    public class RentBLL
    {
        RentDAL _rentDAL;
        public RentBLL()
        {
            _rentDAL = new RentDAL();  
        }
        public bool AddRent(Rent rent)
        {
            return _rentDAL.Insert(rent) > 0;
        }

        public bool Update(Rent rent)
        {
            return _rentDAL.Update(rent) > 0;
        }

        public bool Delete(int rentID)
        {
            return _rentDAL.Delete(rentID) > 0;
        }

        public List<Rent> GetRentList()
        {
            return _rentDAL.GetAllRents();
        }

        public List<Rent> GetRentListByMember(int memberID)
        {
            return _rentDAL.GetRentByMemberID(memberID);
        }
         public Rent GetRentByID(int rentID)
        {
            return _rentDAL.GetRentByID(rentID);
        }


    }
}
