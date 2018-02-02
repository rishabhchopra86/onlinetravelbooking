using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class BookingDetailsClass
    {
        public int Id { get; set; }
        public Nullable<int> BookingId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> PersonType { get; set; }
        public Nullable<int> BookStatus { get; set; }
        public string SeatNo { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddBookingDetails()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = new BookingDetail();
                bookingdetails.BookingId = BookingId;
                bookingdetails.Name = Name;
                bookingdetails.Gender = Gender;
                bookingdetails.Age = Age;
                bookingdetails.PersonType = PersonType;
                bookingdetails.BookStatus = BookStatus;
                bookingdetails.SeatNo = SeatNo;
                bookingdetails.RoomId = RoomId;
                bookingdetails.CreatedBy = CreatedBy;
                bookingdetails.CreatedDate = CreatedDate;
                bookingdetails.UpdatedBy = UpdatedBy;
                bookingdetails.UpdatedDate = UpdatedDate;
                bookingdetails.IsActive = IsActive;

                obj.BookingDetails.Add(bookingdetails);
                obj.SaveChanges();
            }
        }

        public void DeleteBookingDetails()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = obj.BookingDetails.Where(bd => bd.Id == Id).FirstOrDefault();
                bookingdetails.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public void UpdateBookingDetails()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = obj.BookingDetails.Where(bd => bd.Id == Id).FirstOrDefault();
                bookingdetails.BookingId = BookingId;
                bookingdetails.Name = Name;
                bookingdetails.Gender = Gender;
                bookingdetails.Age = Age;
                bookingdetails.PersonType = PersonType;
                bookingdetails.BookStatus = BookStatus;
                bookingdetails.SeatNo = SeatNo;
                bookingdetails.RoomId = RoomId;
                bookingdetails.CreatedBy = CreatedBy;
                bookingdetails.CreatedDate = CreatedDate;
                bookingdetails.UpdatedBy = UpdatedBy;
                bookingdetails.UpdatedDate = UpdatedDate;
                bookingdetails.IsActive = IsActive;
              
                obj.SaveChanges();

            }
        }

        public List<BookingDetail> GetAllBookingDetails()
        {
            List<BookingDetail> bookinglst = new List<BookingDetail>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                bookinglst = obj.BookingDetails.ToList();
            }
            return bookinglst;
        }
#endregion

#region Filtering
        public BookingDetail GetByBookingDetailsId()
        {
            BookingDetail booking = new BookingDetail();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                booking = obj.BookingDetails.Where(b => b.Id == Id).FirstOrDefault();
            }
            return booking;
        }
#endregion
    }
}
