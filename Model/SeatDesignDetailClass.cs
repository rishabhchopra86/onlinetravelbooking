using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
    public class SeatDesignDetailClass
    {
        public int Id { get; set; }
        public Nullable<int> SeatDesignId { get; set; }
        public Nullable<int> Rows { get; set; }
        public Nullable<int> Columns { get; set; }
        public Nullable<bool> Button { get; set; }

        #region CRUD
        public void AddSeatDesignDeatail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                SeatDesignDetail seatdesign = new SeatDesignDetail();
                seatdesign.SeatDesignId = SeatDesignId;
                seatdesign.Rows = Rows;
                seatdesign.Columns = Columns;
                seatdesign.Button = Button;

                obj.SeatDesignDetails.Add(seatdesign);
                obj.SaveChanges();
            }
        }

        public void UpdateSeatDesignDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                SeatDesignDetail seatdesign = obj.SeatDesignDetails.Where(sd => sd.Id == Id).FirstOrDefault();
                seatdesign.SeatDesignId = SeatDesignId;
                seatdesign.Rows = Rows;
                seatdesign.Columns = Columns;
                seatdesign.Button = Button;

                obj.SaveChanges();
            }
        }
        #endregion

        #region Filtering
        public SeatDesignDetail GetBySeatDesignDetailId()
        {
            SeatDesignDetail seatdesign = new SeatDesignDetail();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                seatdesign = obj.SeatDesignDetails.Where(s => s.Id == Id).FirstOrDefault();
            }
            return seatdesign;
        }
        #endregion
    }
}
