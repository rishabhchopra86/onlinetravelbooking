using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class RoomBL:Room
    {
        OnlineTicketBookingEntities obj;
        public RoomBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
    
        #region CRUD
        public void AddRoom(Room room)
        {
                obj.Rooms.Add(room);
                obj.SaveChanges();
        }

        public void deleteRoom()
        {
                obj.SaveChanges();
        }

        public void updateRoom()
        {
                obj.SaveChanges();
        }

        public List<Room> getAll()
        {
            List<Room> lst = new List<Room>();
            lst = obj.Rooms.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Room getByRoomid()
        {

            Room lst = new Room();
            lst = obj.Rooms.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion
    }
}
