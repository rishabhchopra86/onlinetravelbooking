using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Model;

namespace Model
{
   public class ContactUsBL:ContactU
    {
        OnlineTicketBookingEntities obj;
        public ContactUsBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
#region CRUD
        public void AddContactUs(ContactU contact)
        {
            obj.ContactUs.Add(contact);
            obj.SaveChanges();
        }
        public List<ContactU> GetAllContactUsValue()
        {
            List<ContactU> contactlst = new List<ContactU>();
            contactlst = obj.ContactUs.ToList();
            return contactlst;
        }
        #endregion

    }
}
