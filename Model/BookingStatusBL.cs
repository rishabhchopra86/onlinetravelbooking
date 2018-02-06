using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
   public class BookingStatusBL:BookingStatu
    {
        OnlineTicketBookingEntities obj;
        public BookingStatusBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddBookingStatus(BookingStatu bookingstatus)
        {
               obj.BookingStatus.Add(bookingstatus);
               obj.SaveChanges();
        }

       public void DeleteBookingStatus()
       {
                obj.SaveChanges();
       }

       public void UpdateBookingStatus()
       {
               obj.SaveChanges();
       }

       public List<BookingStatu> GetAllBookingStatus()
       {
           List<BookingStatu> bookinglst = new List<BookingStatu>();
           bookinglst = obj.BookingStatus.ToList();
           return bookinglst;
       }
#endregion

 #region Filtering
       public BookingStatu GetByBookingStatusId()
       {
           BookingStatu booking = new BookingStatu();
           booking = obj.BookingStatus.Where(bs => bs.Id == Id).FirstOrDefault();
           return booking;
       }
 #endregion

    }
}
