using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
    public class SeatDesignDetailBL:SeatDesignDetail
    {
        OnlineTicketBookingEntities obj;
        public SeatDesignDetailBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddSeatDesignDeatail(SeatDesignDetail seatdesign)
        {
                obj.SeatDesignDetails.Add(seatdesign);
                obj.SaveChanges();
        }

        public void UpdateSeatDesignDetail()
        {
                obj.SaveChanges();
        }
        #endregion

        #region Filtering
        public SeatDesignDetail GetBySeatDesignDetailId()
        {
            SeatDesignDetail seatdesign = new SeatDesignDetail();
            seatdesign = obj.SeatDesignDetails.Where(s => s.Id == Id).FirstOrDefault();
            return seatdesign;
        }
        #endregion
    }
}
