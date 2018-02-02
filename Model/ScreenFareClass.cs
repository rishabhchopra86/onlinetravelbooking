using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
     public class ScreenFareClass
    {
        public int Id { get; set; }
        public Nullable<int> ScreenId { get; set; }
        public Nullable<int> FareType { get; set; }
        public Nullable<double> Rate { get; set; }

#region CRUD
        public void AddScreenFare()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                ScreenFare screenfare = new ScreenFare();
                screenfare.ScreenId = ScreenId;
                screenfare.FareType = FareType;
                screenfare.Rate = Rate;

                obj.ScreenFares.Add(screenfare);
                obj.SaveChanges();
            }
        }
        public void UpdateScreenFare()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                ScreenFare screenfare = obj.ScreenFares.Where(s => s.Id == Id).FirstOrDefault();
                screenfare.ScreenId = ScreenId;
                screenfare.FareType = FareType;
                screenfare.Rate = Rate;

                obj.SaveChanges();
            }
        }

        public void DeleteScreenFare()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                ScreenFare screenfare = obj.ScreenFares.Where(s => s.Id == Id).FirstOrDefault();
                obj.ScreenFares.Remove(screenfare);
                obj.SaveChanges();
            }
        }

        public List<ScreenFare> GetAllScreenFare()
        {
            List<ScreenFare> screenfarelst = new List<ScreenFare>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                screenfarelst = obj.ScreenFares.ToList();
            }
            return screenfarelst;
        }
#endregion
#region Filtering
        public ScreenFare GetByScreenFareId()
        {
            ScreenFare screenfare = new ScreenFare();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                screenfare = obj.ScreenFares.Where(s => s.Id == Id).FirstOrDefault();
            }
            return screenfare;
        }
#endregion
    }
}
