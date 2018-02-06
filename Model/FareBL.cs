using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class FareBL:Fare
    {
        OnlineTicketBookingEntities obj;

        public FareBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddFare(Fare fare)
        {
                obj.Fares.Add(fare);
                obj.SaveChanges();
        }

        public void DeleteFare()
        {
                obj.SaveChanges();
        }

        public void UpdateFare()
        {
                obj.SaveChanges();
        }

        public List<Fare> GetAllFare()
        {
            List<Fare> farelst = new List<Fare>();
            farelst = obj.Fares.ToList();
            return farelst;
        }
#endregion

#region Filtering
        public Fare GetByFareId()
        {
            Fare fare = new Fare();
            fare = obj.Fares.Where(f => f.Id == Id).FirstOrDefault();
            return fare;
        }
#endregion
    }
}
