using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
    public class BookingClass:Booking
    {
       
#region CRUD
        public void AddBooking()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = new Booking();
                booking.BookingCode =this.BookingCode;
                booking.CustomerId = this.CustomerId;
                booking.BookingDate = this.BookingDate;
                booking.CheckoutDate = this.CheckoutDate;
                booking.FareId = this.FareId;
                booking.BoardingStId = this.BoardingStId;
                booking.BookingType = this.BoardingStId;
                booking.Roundtrip = this.Roundtrip;
                booking.Amount = this.Amount;
                booking.Discount = this.Discount;
                booking.Taxtype = this.Taxtype;
                booking.TaxAmount = this.TaxAmount;
                booking.NetAmount = this.NetAmount;
                booking.ProcessingFees = this.ProcessingFees;
                booking.CreatedBy = this.CreatedBy;
                booking.CreatedDate = this.CreatedDate;
                booking.UpdatedBy = this.UpdatedBy;
                booking.UpdatedDate = this.UpdatedDate;
                booking.IsActive = this.IsActive;

                obj.Bookings.Add(booking);
                obj.SaveChanges();

            }
        }

        public void DeleteBooking()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = obj.Bookings.Where(b => b.Id == this.Id).FirstOrDefault();
                booking.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public void UpdateBooking()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = obj.Bookings.Where(x => x.Id == this.Id).FirstOrDefault();
                booking.BookingCode = this.BookingCode;
                booking.CustomerId = this.CustomerId;
                booking.BookingDate = this.BookingDate;
                booking.CheckoutDate = this.CheckoutDate;
                booking.FareId = this.FareId;
                booking.BoardingStId = this.BoardingStId;
                booking.BookingType = this.BookingType;
                booking.Roundtrip = this.Roundtrip;
                booking.Amount = this.Amount;
                booking.Discount = this.Discount;
                booking.Taxtype = this.Taxtype;
                booking.TaxAmount = this.TaxAmount;
                booking.NetAmount = this.NetAmount;
                booking.ProcessingFees = this.ProcessingFees;
                booking.CreatedBy = this.CreatedBy;
                booking.CreatedDate = this.CreatedDate;
                booking.UpdatedBy = this.UpdatedBy;
                booking.UpdatedDate = this.UpdatedDate;
                booking.IsActive = this.IsActive;

                obj.SaveChanges();
            }
        }

        public List<BookingClass> GetAllBooking()
        {
            List<Booking> bookinglst = new List<Booking>();
            List<BookingClass> bookinglstclass = new List<BookingClass>();
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                bookinglst = obj.Bookings.ToList();
                foreach(var book in bookinglst)
                {
                    bookinglstclass.Add((BookingClass)CopyProperties(book,this));
                }
            }
            return bookinglstclass;
        }

        public object CopyProperties(object source, object destination)
        {
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }
            return destination;
        }
        #endregion

        #region  Filetering
        public BookingClass GetByBookingId()
        {
            Booking booking = new Booking();
            BookingClass bookingclass;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                booking = obj.Bookings.Where(b => b.Id == this.Id).FirstOrDefault();
                bookingclass = (BookingClass)CopyProperties(booking, this);
            }
            return bookingclass;
        }
#endregion


    }
}
