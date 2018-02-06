using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class HotelBL:Hotel
    {
        OnlineTicketBookingEntities obj;
        public HotelBL()
        {
            obj = new OnlineTicketBookingEntities();
        }   
                   
        #region CRUD
        public void AddHotel(Hotel hotel)
        {
            obj.Hotels.Add(hotel);
            obj.SaveChanges();
        }

        public void deleteHotel()
        {
             obj.SaveChanges();
        }

        public void updateHotel()
        {
                obj.SaveChanges();
        }

        public List<Hotel> getAll()
        {
            List<Hotel> lst = new List<Hotel>();
            lst =obj.Hotels.ToList();

            return lst;
        }
        #endregion

        #region Filtering Data
        public Hotel getByid()
        {
            Hotel lst = new Hotel();
            lst = obj.Hotels.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion

    }
}
