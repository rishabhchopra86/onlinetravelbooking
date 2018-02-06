using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class BookingDetailsBL:BookingDetail
    {
        OnlineTicketBookingEntities obj;
        public BookingDetailsBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddBookingDetails(BookingDetail bookingdetails)
        {
                obj.BookingDetails.Add(bookingdetails);
                obj.SaveChanges();
        }

        public void DeleteBookingDetails()
        {
                obj.SaveChanges();
        }

        public void UpdateBookingDetails()
        {
                obj.SaveChanges();
        }

        public List<BookingDetail> GetAllBookingDetails()
        {
            List<BookingDetail> bookinglst = new List<BookingDetail>();
            bookinglst = obj.BookingDetails.ToList();
            return bookinglst;
        }
#endregion

#region Filtering
        public BookingDetail GetByBookingDetailsId()
        {
            BookingDetail booking = new BookingDetail();
            booking = obj.BookingDetails.Where(b => b.Id == Id).FirstOrDefault();
            return booking;
        }
#endregion
    }
}
