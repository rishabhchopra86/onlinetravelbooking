using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class ScreenDesignClass
    {
        public int Id { get; set; }
        public Nullable<int> ScreenId { get; set; }
        public Nullable<int> NoOfRows { get; set; }
        public Nullable<int> NoOfColumns { get; set; }

#region CRUD
        public void AddSeatDesign()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                SeatDesign seatdesign = new SeatDesign();
                seatdesign.ScreenId = ScreenId;
                seatdesign.NoOfRows = NoOfRows;
                seatdesign.NoOfColumns = NoOfColumns;

                obj.SeatDesigns.Add(seatdesign);
                obj.SaveChanges();
            }
        }

        public void UpdateSeatDesign()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                SeatDesign seatdesign = obj.SeatDesigns.Where(sd => sd.Id == Id).FirstOrDefault();
                seatdesign.ScreenId = ScreenId;
                seatdesign.NoOfRows = NoOfRows;
                seatdesign.NoOfColumns = NoOfColumns;

                obj.SaveChanges();
            }
        }
        #endregion

#region Filtering
        public SeatDesign GetBySeatDesignId()
        {
            SeatDesign seatdesign = new SeatDesign();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                seatdesign = obj.SeatDesigns.Where(s => s.Id == Id).FirstOrDefault();
            }
            return seatdesign;
        }
        #endregion

    }
}
