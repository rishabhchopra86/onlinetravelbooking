using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
   public class BookingStatusClass
    {
        public int Id { get; set; }
        public Nullable<int> BookingId { get; set; }
        public string PnrNo { get; set; }
        public Nullable<int> PnrStatus { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsCancel { get; set; }

#region CRUD
        public void AddBookingStatus()
        {
           using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = new BookingStatu();
               bookingstatus.BookingId = BookingId;
               bookingstatus.PnrNo = PnrNo;
               bookingstatus.PnrStatus = PnrStatus;
               bookingstatus.CreatedBy = CreatedBy;
               bookingstatus.CreatedDate = CreatedDate;
               bookingstatus.UpdatedBy = UpdatedBy;
               bookingstatus.UpdatedDate = UpdatedDate;
               bookingstatus.IsActive = IsActive;
               bookingstatus.IsCancel = IsCancel;

               obj.BookingStatus.Add(bookingstatus);
               obj.SaveChanges();
           }
        }

       public void DeleteBookingStatus()
       {
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = obj.BookingStatus.Where(bs => bs.Id == Id).FirstOrDefault();
                bookingstatus.IsActive = IsActive;

                obj.SaveChanges();
           }
       }

       public void UpdateBookingStatus()
       {
           using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               BookingStatu bookingstatus = obj.BookingStatus.Where(bs => bs.Id == Id).FirstOrDefault();
               bookingstatus.BookingId = BookingId;
               bookingstatus.PnrNo = PnrNo;
               bookingstatus.PnrStatus = PnrStatus;
               bookingstatus.CreatedBy = CreatedBy;
               bookingstatus.CreatedDate = CreatedDate;
               bookingstatus.UpdatedBy = UpdatedBy;
               bookingstatus.UpdatedDate = UpdatedDate;
               bookingstatus.IsActive = IsActive;
               bookingstatus.IsCancel = IsCancel;

               obj.SaveChanges();
           }
       }
       public List<BookingStatu> GetAllBookingStatus()
       {
           List<BookingStatu> bookinglst = new List<BookingStatu>();
           using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
           {
               bookinglst = obj.BookingStatus.ToList();
           }
           return bookinglst;
       }
#endregion

 #region Filtering
       public BookingStatu GetByBookingStatusId()
       {
           BookingStatu booking = new BookingStatu();
           using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
           {
               booking = obj.BookingStatus.Where(bs => bs.Id == Id).FirstOrDefault();
           }
           return booking;
       }
 #endregion

    }
}
