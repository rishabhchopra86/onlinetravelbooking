using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class BookingClass
    {
        public int Id { get; set; }
        public string BookCode { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public Nullable<System.DateTime> CheckoutDate { get; set; }
        public Nullable<int> FareId { get; set; }
        public Nullable<int> BoardingStId { get; set; }
        public Nullable<int> BookingType { get; set; }
        public Nullable<bool> Roundtrip { get; set; }
        public Nullable<double> Amount { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<int> Taxtype { get; set; }
        public Nullable<double> TaxAmount { get; set; }
        public Nullable<double> NetAmount { get; set; }
        public Nullable<double> ProcessingFees { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddBooking()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = new Booking();
                booking.BookCode = BookCode;
                booking.CustomerId = CustomerId;
                booking.BookingDate = BookingDate;
                booking.CheckoutDate = CheckoutDate;
                booking.FareId = FareId;
                booking.BoardingStId = BoardingStId;
                booking.BookingType = BoardingStId;
                booking.Roundtrip = Roundtrip;
                booking.Amount = Amount;
                booking.Discount = Discount;
                booking.Taxtype = Taxtype;
                booking.TaxAmount = TaxAmount;
                booking.NetAmount = NetAmount;
                booking.ProcessingFees = ProcessingFees;
                booking.CreatedBy = CreatedBy;
                booking.CreatedDate = CreatedDate;
                booking.UpdatedBy = UpdatedBy;
                booking.UpdatedDate = UpdatedDate;
                booking.IsActive = IsActive;

                obj.Bookings.Add(booking);
                obj.SaveChanges();

            }
        }

        public void DeleteBooking(BookingClass data)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = obj.Bookings.Where(b => b.Id == data.Id).FirstOrDefault();
                obj.Bookings.Remove(booking);
                obj.SaveChanges();
            }
        }

        public void UpdateBooking(BookingClass data)
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Booking booking = obj.Bookings.Where(x => x.Id == data.Id).FirstOrDefault();
                booking.BookCode = data.BookCode;
                booking.CustomerId = data.CustomerId;
                booking.BookingDate = data.BookingDate;
                booking.CheckoutDate = data.CheckoutDate;
                booking.FareId = data.FareId;
                booking.BoardingStId = data.BoardingStId;
                booking.BookingType = data.BookingType;
                booking.Roundtrip = data.Roundtrip;
                booking.Amount = data.Amount;
                booking.Discount = data.Discount;
                booking.Taxtype = data.Taxtype;
                booking.TaxAmount = data.TaxAmount;
                booking.NetAmount = data.NetAmount;
                booking.ProcessingFees = ProcessingFees;
                booking.CreatedBy = CreatedBy;
                booking.CreatedDate = CreatedDate;
                booking.UpdatedBy = UpdatedBy;
                booking.UpdatedDate = UpdatedDate;
                booking.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Booking> GetAllBooking()
        {
            List<Booking> bookinglst = new List<Booking>();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                bookinglst = obj.Bookings.ToList();
            }
            return bookinglst;
        }
#endregion

#region  Filetering
        public Booking GetByBookingId(BookingClass data)
        {
            Booking booking = new Booking();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                booking = obj.Bookings.Where(b => b.Id == data.Id).FirstOrDefault();
            }
            return booking;
        }
#endregion


    }
}
