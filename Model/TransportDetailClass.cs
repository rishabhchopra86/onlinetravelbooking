using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public  class TransportDetailClass
    {
        public int Id { get; set; }
        public Nullable<int> TransportId { get; set; }
        public Nullable<int> StationId { get; set; }
        public Nullable<int> RouteNo { get; set; }
        public Nullable<System.TimeSpan> DepartureTime { get; set; }
        public Nullable<System.TimeSpan> ArrivalTime { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public Nullable<int> Days { get; set; }
        public Nullable<decimal> Distance { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

        #region CRUD
        public void AddTransportDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                TransportDetail transdetail = new TransportDetail();
                transdetail.TransportId = TransportId;
                transdetail.StationId = StationId;
                transdetail.RouteNo = RouteNo;
                transdetail.DepartureTime = DepartureTime;
                transdetail.ArrivalTime = ArrivalTime;
                transdetail.Duration = Duration;
                transdetail.Days = Days;
                transdetail.Distance = Distance;
                transdetail.CreatedBy = CreatedBy;
                transdetail.CreatedDate = CreatedDate;
                transdetail.UpdatedBy = UpdatedBy;
                transdetail.UpdatedDate = UpdatedDate;
                transdetail.IsActive = IsActive;

                obj.TransportDetails.Add(transdetail);
                obj.SaveChanges();
            }
        }

        public void DeleteTransportDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                TransportDetail transdetail = obj.TransportDetails.SingleOrDefault(t => t.Id == Id);
                transdetail.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateTransportDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                TransportDetail transdetail = obj.TransportDetails.Where(t => t.Id == Id).FirstOrDefault();
                transdetail.TransportId = TransportId;
                transdetail.StationId = StationId;
                transdetail.RouteNo = RouteNo;
                transdetail.DepartureTime = DepartureTime;
                transdetail.ArrivalTime = ArrivalTime;
                transdetail.Duration = Duration;
                transdetail.Days = Days;
                transdetail.Distance = Distance;
                transdetail.CreatedBy = CreatedBy;
                transdetail.CreatedDate = CreatedDate;
                transdetail.UpdatedBy = UpdatedBy;
                transdetail.UpdatedDate = UpdatedDate;
                transdetail.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public List<TransportDetail> GetAllTransportDetail()
        {
            List<TransportDetail> transDetailList = new List<TransportDetail>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                transDetailList = obj.TransportDetails.ToList();
            }
            return transDetailList;
        }
        #endregion

        #region Filtering
        public TransportDetail GetByTransportDetailid()
        {
            TransportDetail transdetail = new TransportDetail();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                transdetail = obj.TransportDetails.FirstOrDefault(u => u.Id == Id);
            }
            return transdetail;
        }
        #endregion
    }
}
