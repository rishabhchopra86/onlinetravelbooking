using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class BookingBL:Booking
    {
        OnlineTicketBookingEntities obj;

        public BookingBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddBooking(Booking booking)
        {
                obj.Bookings.Add(booking);
                obj.SaveChanges();
        }

        public void DeleteBooking()
        {
                obj.SaveChanges();
        }

        public void UpdateBooking()
        {
                obj.SaveChanges();
        }

        public List<Booking> GetAllBooking()
        {
            List<Booking> bookinglst = new List<Booking>();
            bookinglst = obj.Bookings.ToList();
            return bookinglst;
        }
#endregion

#region  Filetering
        public Booking GetByBookingId()
        {
            Booking booking = new Booking();
            booking = obj.Bookings.Where(b => b.Id == Id).FirstOrDefault();
            return booking;
        }
#endregion

    }
}
