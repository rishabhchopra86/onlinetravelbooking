using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
   public class BookingStatusClass:BookingStatu
    {
  
#region CRUD
        public void AddBookingStatus()
        {
           using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = new BookingStatu();
               bookingstatus.BookingId = this.BookingId;
               bookingstatus.PnrNo = this.PnrNo;
               bookingstatus.PnrStatus = this.PnrStatus;
               bookingstatus.CreatedBy = this.CreatedBy;
               bookingstatus.CreatedDate = this.CreatedDate;
               bookingstatus.UpdatedBy = this.UpdatedBy;
               bookingstatus.UpdatedDate = this.UpdatedDate;
               bookingstatus.IsActive = this.IsActive;
               bookingstatus.IsCancel = this.IsCancel;

               obj.BookingStatus.Add(bookingstatus);
               obj.SaveChanges();
           }
        }

       public void DeleteBookingStatus()
       {
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = obj.BookingStatus.Where(bs => bs.Id == this.Id).FirstOrDefault();
                bookingstatus.IsActive = IsActive;

                obj.SaveChanges();
           }
       }

       public void UpdateBookingStatus()
       {
           using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = obj.BookingStatus.Where(bs => bs.Id == this.Id).FirstOrDefault();
               bookingstatus.BookingId = this.BookingId;
               bookingstatus.PnrNo = this.PnrNo;
               bookingstatus.PnrStatus = this.PnrStatus;
               bookingstatus.CreatedBy = this.CreatedBy;
               bookingstatus.CreatedDate = this.CreatedDate;
               bookingstatus.UpdatedBy = this.UpdatedBy;
               bookingstatus.UpdatedDate = this.UpdatedDate;
               bookingstatus.IsActive = this.IsActive;
               bookingstatus.IsCancel = this.IsCancel;

               obj.SaveChanges();
           }
       }
       public List<BookingStatusClass> GetAllBookingStatus()
       {
           List<BookingStatu> bookinglst = new List<BookingStatu>();
            List<BookingStatusClass> bookinglstclass = new List<BookingStatusClass>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
           {
               bookinglst = obj.BookingStatus.ToList();
                foreach(var status in bookinglst)
                {
                    bookinglstclass.Add((BookingStatusClass)CopyProperties(status, this));
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
        public BookingStatusClass GetByBookingStatusId()
       {
           BookingStatu booking = new BookingStatu();
            BookingStatusClass bookingstatusclass;
           using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
           {
               booking = obj.BookingStatus.Where(bs => bs.Id == Id).FirstOrDefault();
                bookingstatusclass=((BookingStatusClass)CopyProperties(booking,this));
           }
           return bookingstatusclass;
       }
 #endregion

    }
}
