using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace OnlineTicketBL
{
     public class ScreenFareBL:ScreenFare
    {
        OnlineTicketBookingEntities obj;
        public ScreenFareBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddScreenFare(ScreenFare screenfare)
        {
                obj.ScreenFares.Add(screenfare);
                obj.SaveChanges();
        }
        public void UpdateScreenFare()
        {
                obj.SaveChanges();
        }

        public void DeleteScreenFare()
        {
              //  ScreenFare screenfare = obj.ScreenFares.Where(s => s.Id == Id).FirstOrDefault();
               // obj.ScreenFares.Remove(screenfare);
                obj.SaveChanges();
        }

        public List<ScreenFare> GetAllScreenFare()
        {
            List<ScreenFare> screenfarelst = new List<ScreenFare>();
            screenfarelst = obj.ScreenFares.ToList();
            return screenfarelst;
        }
#endregion
#region Filtering
        public ScreenFare GetByScreenFareId()
        {
            ScreenFare screenfare = new ScreenFare();
            screenfare = obj.ScreenFares.Where(s => s.Id == Id).FirstOrDefault();
            return screenfare;
        }
#endregion
    }
}
