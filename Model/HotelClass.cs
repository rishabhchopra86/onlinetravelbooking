using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class HotelClass
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string HotelRules { get; set; }
        public string CancellationPolicy { get; set; }
        public int HotelType { get; set; }
        public int ImageId { get; set; }
        public string HotelAddress { get; set; }
        public int HotelRating { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public int PhoneNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
              
        #region CRUD
        public void AddHotel()
        {
            using (OnlineTicketBookingEntities obj= new OnlineTicketBookingEntities())
            {
                Hotel htl = new Hotel();
                htl.HotelName = HotelName;
                htl.HotelDescription = HotelDescription;
                htl.HotelRules = HotelRules;
                htl.CancellationPolicy = CancellationPolicy;
                htl.HotelType = HotelType;  
                htl.ImageId = ImageId;
                htl.HotelAddress = HotelAddress;
                htl.HotelRating = HotelRating;
                htl.CityId = CityId;
                htl.PostalCode = PostalCode;
                htl.Email = Email;
                htl.PhoneNo = PhoneNo;
                htl.CreatedBy = CreatedBy;
                htl.CreatedDate = CreatedDate;
                htl.UpdatedBy = UpdatedBy;
                htl.UpdatedDate = UpdatedDate;
                htl.IsActive = IsActive;

                obj.Hotels.Add(htl);
                obj.SaveChanges();
            }
        }
        public void deleteHotel()
        {
            using (OnlineTicketBookingEntities obj= new OnlineTicketBookingEntities())
            {
                Hotel htl = obj.Hotels.SingleOrDefault(c => c.Id == Id);
                htl.IsActive = IsActive;

                obj.SaveChanges();

            }
        }
        public void updateHotel()
        {

            using (OnlineTicketBookingEntities obj= new OnlineTicketBookingEntities())
            {
                Hotel reviewId = obj.Hotels.SingleOrDefault(c => c.Id == Id);
              
                Hotel htl = new Hotel();
                htl.HotelName = HotelName;
                htl.HotelDescription = HotelDescription;
                htl.HotelRules = HotelRules;
                htl.CancellationPolicy = CancellationPolicy;
                htl.HotelType = HotelType;
                htl.ImageId = ImageId;
                htl.HotelAddress = HotelAddress;
                htl.HotelRating = HotelRating;
                htl.CityId = CityId;
                htl.PostalCode = PostalCode;
                htl.Email = Email;
                htl.PhoneNo = PhoneNo;
                htl.CreatedBy = CreatedBy;
                htl.CreatedDate = CreatedDate;
                htl.UpdatedBy = UpdatedBy;
                htl.UpdatedDate = UpdatedDate;
                htl.IsActive = IsActive;

                obj.SaveChanges();

            }

        }
        public static List<Hotel> getAll()
        {
            List<Hotel> lst = null;
            using (OnlineTicketBookingEntities obj= new OnlineTicketBookingEntities())
            {
                lst =obj.Hotels.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Hotel getByid()
        {

            Hotel lst = null;
            using (OnlineTicketBookingEntities obj= new OnlineTicketBookingEntities())
            {
                lst = obj.Hotels.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
