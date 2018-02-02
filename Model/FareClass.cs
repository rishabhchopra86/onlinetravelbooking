using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class FareClass
    {
        public int Id { get; set; }
        public Nullable<int> TransportId { get; set; }
        public Nullable<int> From { get; set; }
        public Nullable<int> To { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<int> Categories { get; set; }
        public Nullable<double> RoundtripRate { get; set; }
        public Nullable<int> PersonType { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddFare()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Fare fare = new Fare();
                fare.TransportId = TransportId;
                fare.From =From;
                fare.To = To;
                fare.Rate = Rate;
                fare.Categories = Categories;
                fare.RoundtripRate = RoundtripRate;
                fare.PersonType = PersonType;
                fare.CreatedBy = CreatedBy;
                fare.CreatedDate = CreatedDate;
                fare.UpdatedBy = UpdatedBy;
                fare.UpdatedDate = UpdatedDate;
                fare.IsActive = IsActive;

                obj.Fares.Add(fare);
                obj.SaveChanges();
            }
        }

        public void DeleteFare()
        {
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               Fare fare = obj.Fares.Where(f => f.Id == Id).FirstOrDefault();
                fare.IsActive = IsActive;

                obj.SaveChanges();
           }
        }

        public void UpdateFare()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Fare fare = obj.Fares.Where(f => f.Id == Id).FirstOrDefault();
                fare.TransportId = TransportId;
                fare.From = From;
                fare.To = To;
                fare.Rate = Rate;
                fare.Categories = Categories;
                fare.RoundtripRate = RoundtripRate;
                fare.PersonType = PersonType;
                fare.CreatedBy = CreatedBy;
                fare.CreatedDate = CreatedDate;
                fare.UpdatedBy = UpdatedBy;
                fare.UpdatedDate = UpdatedDate;
                fare.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Fare> GetAllFare()
        {
            List<Fare> farelst = new List<Fare>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                farelst = obj.Fares.ToList();
            }
            return farelst;
        }
#endregion

#region Filtering
        public Fare GetByFareId()
        {
            Fare fare = new Fare();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                fare = obj.Fares.Where(f => f.Id == Id).FirstOrDefault();
            }
            return fare;
        }
#endregion
    }
}
