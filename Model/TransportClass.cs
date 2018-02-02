using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class TransportClass
    {
        public int Id { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string TransportNo { get; set; }
        public Nullable<int> AgentId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public Nullable<int> AminitiesId { get; set; }
        public Nullable<bool> Monday { get; set; }
        public Nullable<bool> Tuesday { get; set; }
        public Nullable<bool> Wednesday { get; set; }
        public Nullable<bool> Thursday { get; set; }
        public Nullable<bool> Friday { get; set; }
        public Nullable<bool> Saturday { get; set; }
        public Nullable<bool> Sunday { get; set; }
        public Nullable<int> Ratings { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

        #region CRUD
        public void AddTransport()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Transport trans = new Transport();
                trans.TypeId = TypeId;
                trans.TransportNo = TransportNo;
                trans.AgentId = AgentId;
                trans.Source = Source;
                trans.Destination = Destination;
                trans.AminitiesId= AminitiesId;
                trans.Monday = Monday;
                trans.Tuesday = Tuesday;
                trans.Wednesday = Wednesday;
                trans.Thursday = Thursday;
                trans.Friday = Friday;
                trans.Saturday = Saturday;
                trans.Sunday = Sunday;
                trans.Ratings = Ratings;
                trans.CreatedBy = CreatedBy;
                trans.CreatedDate = CreatedDate;
                trans.UpdatedBy = UpdatedBy;
                trans.UpdatedDate = UpdatedDate;
                trans.IsActive = IsActive;

                obj.Transports.Add(trans);
                obj.SaveChanges();
            }
        }

        public void DeleteTransport()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Transport trans = obj.Transports.SingleOrDefault(t => t.Id == Id);
                trans.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateTransport()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Transport trans = obj.Transports.SingleOrDefault(t => t.Id == Id);
                trans.TypeId = TypeId;
                trans.TransportNo = TransportNo;
                trans.AgentId = AgentId;
                trans.Source = Source;
                trans.Destination = Destination;
                trans.AminitiesId = AminitiesId;
                trans.Monday = Monday;
                trans.Tuesday = Tuesday;
                trans.Wednesday = Wednesday;
                trans.Thursday = Thursday;
                trans.Friday = Friday;
                trans.Saturday = Saturday;
                trans.Sunday = Sunday;
                trans.Ratings = Ratings;
                trans.CreatedBy = CreatedBy;
                trans.CreatedDate = CreatedDate;
                trans.UpdatedBy = UpdatedBy;
                trans.UpdatedDate = UpdatedDate;
                trans.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public List<Transport> GetAllTransports()
        {
            List<Transport> transportList = new List<Transport>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                transportList = obj.Transports.ToList();
            }
            return transportList;
        }
        #endregion

        #region Filtering
        public Transport GetByTransportid()
        {
            Transport transport= new Transport();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                transport = obj.Transports.FirstOrDefault(t => t.Id == Id);
            }
            return transport;
        }
        #endregion
    }
}
