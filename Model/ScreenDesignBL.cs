using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace OnlineTicketBL
{
    public class ScreenDesignBL : SeatDesign
    {
        OnlineTicketBookingEntities obj;
        public ScreenDesignBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddSeatDesign(SeatDesign seatdesign)
        {
                obj.SeatDesigns.Add(seatdesign);
                obj.SaveChanges();
        }

        public void UpdateSeatDesign()
        {
                obj.SaveChanges();
        }
        #endregion

        #region Filtering
        public SeatDesign GetBySeatDesignId()
        {
            SeatDesign seatdesign = new SeatDesign();
            seatdesign = obj.SeatDesigns.Where(s => s.Id == this.Id).FirstOrDefault();
            return seatdesign;
        }
        #endregion

    }
}
