using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class RoomClass
    {

        public int Id { get; set; }
        public string RoomCode { get; set; }
        public int HotelId { get; set; }
        public int Type { get; set; }
        public int Capacity { get; set; }
        public int Status { get; set; }
        public int PriceBase { get; set; }
        public int PricePerAdult { get; set; }
        public int PricePerChild { get; set; }
        public int NoOfAdultAllowed { get; set; }
        public int NoOfChildAllowed { get; set; }
        public bool SmokingFlag { get; set; }
        public int AmenitiesId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        #region CRUD
        public void AddRoom()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Room roomId = new Room();
                roomId.RoomCode = RoomCode;
                roomId.HotelId = HotelId;
                roomId.Type = Type;
                roomId.Capacity = Capacity;
                roomId.Status = Status;
                roomId.PriceBase = PriceBase;
                roomId.PricePerAdult = PricePerAdult;
                roomId.PricePerChild = PricePerChild;
                roomId.NoOfAdultAllowed = NoOfAdultAllowed;
                roomId.NoOfChildAllowed = NoOfChildAllowed;
                roomId.SmokingFlag = SmokingFlag;
                roomId.AmenitiesId = AmenitiesId;
                roomId.CreatedBy = CreatedBy;
                roomId.CreatedDate = CreatedDate;
                roomId.UpdatedBy = UpdatedBy;
                roomId.UpdatedDate = UpdatedDate;
                roomId.IsActive = IsActive;

                obj.Rooms.Add(roomId);
                obj.SaveChanges();
            }
        }
        public void deleteRoom()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Room room = obj.Rooms.Where(c => c.Id == Id).FirstOrDefault();
                room.IsActive = IsActive;

                obj.SaveChanges();

            }
        }
        public void updateRoom()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Room roomId = obj.Rooms.Where(c => c.Id == Id).FirstOrDefault();
                roomId.RoomCode = RoomCode;
                roomId.HotelId = HotelId;
                roomId.Type = Type;
                roomId.Capacity = Capacity;
                roomId.Status = Status;
                roomId.PriceBase = PriceBase;
                roomId.PricePerAdult = PricePerAdult;
                roomId.PricePerChild = PricePerChild;
                roomId.NoOfAdultAllowed = NoOfAdultAllowed;
                roomId.NoOfChildAllowed = NoOfChildAllowed;
                roomId.SmokingFlag = SmokingFlag;
                roomId.AmenitiesId = AmenitiesId;
                roomId.CreatedBy = CreatedBy;
                roomId.CreatedDate = CreatedDate;
                roomId.UpdatedBy = UpdatedBy;
                roomId.UpdatedDate = UpdatedDate;
                roomId.IsActive = IsActive;
                obj.SaveChanges();
            }

        }
        public static List<Room> getAll()
        {
            List<Room> lst = new List<Room>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Rooms.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Room getByRoomid()
        {

            Room lst = new Room();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Rooms.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion
    }
}
