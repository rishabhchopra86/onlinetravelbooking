using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
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



        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

      

        #region CRUD
        public void AddRoom()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Room rm = new Room();
                rm.RoomCode = RoomCode;
                rm.HotelId = HotelId;
                rm.Type = Type;
                rm.Capacity = Capacity;
                rm.Status = Status;
                rm.PriceBase = PriceBase;
                rm.PricePerAdult = PricePerAdult;
                rm.PricePerChild = PricePerChild;
                rm.NoOfAdultAllowed = NoOfAdultAllowed;
                rm.NoOfChildAllowed = NoOfChildAllowed;
                rm.SmokingFlag = SmokingFlag;
                rm.AmenitiesId = AmenitiesId;
                rm.CreatedBy = CreatedBy;
                rm.CreatedDate = CreatedDate;
                rm.UpdatedBy = UpdatedBy;
                rm.UpdatedDate = UpdatedDate;
                rm.IsActive = IsActive;

                otbe.Rooms.Add(rm);
                saveChanges();
            }
        }
        public void deleteRoom()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Room roomId = otbe.Rooms.SingleOrDefault(c => c.Id == Id);
                otbe.Rooms.Remove(roomId);
                saveChanges();
            }
        }
        public void updateRoom()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Room roomId = otbe.Rooms.SingleOrDefault(c => c.Id == Id);
                Room rm = new Room();
                rm.RoomCode = RoomCode;
                rm.HotelId = HotelId;
                rm.Type = Type;
                rm.Capacity = Capacity;
                rm.Status = Status;
                rm.PriceBase = PriceBase;
                rm.PricePerAdult = PricePerAdult;
                rm.PricePerChild = PricePerChild;
                rm.NoOfAdultAllowed = NoOfAdultAllowed;
                rm.NoOfChildAllowed = NoOfChildAllowed;
                rm.SmokingFlag = SmokingFlag;
                rm.AmenitiesId = AmenitiesId;
                rm.CreatedBy = CreatedBy;
                rm.CreatedDate = CreatedDate;
                rm.UpdatedBy = UpdatedBy;
                rm.UpdatedDate = UpdatedDate;
                rm.IsActive = IsActive;
                saveChanges();
            }

        }
        public static List<Room> getAll()
        {
            List<Room> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.Rooms select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Room getByid()
        {

            Room lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.Rooms.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion
    }
}
