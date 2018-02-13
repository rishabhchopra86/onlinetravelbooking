using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class AvilableSeatBL:AvailableSeat
    {
        OnlineTicketBookingEntities obj;
        public AvilableSeatBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddAvilableSeat(AvailableSeat avilableseat)
        {
                obj.AvailableSeats.Add(avilableseat);
                obj.SaveChanges();
        }

        public void DeleteAvillableSeat()
        {
                obj.SaveChanges();
        }

        public void UpdateAvilableSeat()
        {
                obj.SaveChanges();
        }

        public List<AvailableSeat> GetAllAvailableSeat()
        {
            List<AvailableSeat> seatList = new List<AvailableSeat>();
            seatList = obj.AvailableSeats.ToList();
            return seatList;
        }
#endregion

        #region Filtering
        public AvailableSeat GetByAvailableSeatId()
        {
            AvailableSeat availableseat = new AvailableSeat();
            availableseat = obj.AvailableSeats.Where(avls => avls.Id == this.Id).FirstOrDefault();
            return availableseat;
        }   
        #endregion

    }
}
