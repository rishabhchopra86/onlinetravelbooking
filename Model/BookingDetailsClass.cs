using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
    public class BookingDetailsClass:BookingDetail
    {
   
#region CRUD
        public void AddBookingDetails()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = new BookingDetail();
                bookingdetails.BookingId = this.BookingId;
                bookingdetails.Name = this.Name;
                bookingdetails.Gender = this.Gender;
                bookingdetails.Age = this.Age;
                bookingdetails.PersonType = this.PersonType;
                bookingdetails.BookStatus = this.BookStatus;
                bookingdetails.SeatNo = this.SeatNo;
                bookingdetails.RoomId = this.RoomId;
                bookingdetails.CreatedBy = this.CreatedBy;
                bookingdetails.CreatedDate = this.CreatedDate;
                bookingdetails.UpdatedBy = this.UpdatedBy;
                bookingdetails.UpdatedDate = this.UpdatedDate;
                bookingdetails.IsActive = this.IsActive;

                obj.BookingDetails.Add(bookingdetails);
                obj.SaveChanges();
            }
        }

        public void DeleteBookingDetails()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = obj.BookingDetails.Where(bd => bd.Id == this.Id).FirstOrDefault();
                bookingdetails.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public void UpdateBookingDetails()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                BookingDetail bookingdetails = obj.BookingDetails.Where(bd => bd.Id == this.Id).FirstOrDefault();
                bookingdetails.BookingId = this.BookingId;
                bookingdetails.Name = this.Name;
                bookingdetails.Gender = this.Gender;
                bookingdetails.Age = this.Age;
                bookingdetails.PersonType = this.PersonType;
                bookingdetails.BookStatus = this.BookStatus;
                bookingdetails.SeatNo = this.SeatNo;
                bookingdetails.RoomId = this.RoomId;
                bookingdetails.CreatedBy = this.CreatedBy;
                bookingdetails.CreatedDate = this.CreatedDate;
                bookingdetails.UpdatedBy = this.UpdatedBy;
                bookingdetails.UpdatedDate = this.UpdatedDate;
                bookingdetails.IsActive = this.IsActive;
              
                obj.SaveChanges();

            }
        }

        public List<BookingDetailsClass> GetAllBookingDetails()
        {
            List<BookingDetail> bookinglst = new List<BookingDetail>();
            List<BookingDetailsClass> bookinglstclass = new List<BookingDetailsClass>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                bookinglst = obj.BookingDetails.ToList();
                foreach(var bookingdetail in bookinglst)
                {
                    bookinglstclass.Add((BookingDetailsClass)CopyProperties(bookingdetail, this));
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

        #region Filtering
        public BookingDetailsClass GetByBookingDetailsId()
        {
            BookingDetail booking = new BookingDetail();
            BookingDetailsClass bookingclass;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                booking = obj.BookingDetails.Where(b => b.Id == this.Id).FirstOrDefault();
                bookingclass = ((BookingDetailsClass)CopyProperties(booking, this));
            }
            return bookingclass;
        }
#endregion
    }
}
