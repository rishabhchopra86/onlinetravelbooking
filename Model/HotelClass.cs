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
        public Nullable<int> HotelType { get; set; }
        public Nullable<int> ImageId { get; set; }
        public string HotelAddress { get; set; }
        public Nullable<int> HotelRating { get; set; }
        public Nullable<int> CityId { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public Nullable<int> PhoneNo { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddHotel()
        {
            Hotel hotel = new Hotel();
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                hotel.HotelName = HotelName;
                hotel.HotelDescription = HotelDescription;
                hotel.HotelRules = HotelRules;
                hotel.CancellationPolicy = CancellationPolicy;
                hotel.HotelType = HotelType;
                hotel.ImageId = ImageId;
                hotel.HotelAddress = HotelAddress;
                hotel.HotelRating = HotelRating;
                hotel.CityId = CityId;
                hotel.PostalCode = PostalCode;
                hotel.Email = Email;
                hotel.PhoneNo = PhoneNo;
                hotel.CreatedBy = CreatedBy;
                hotel.CreatedDate = CreatedDate;
                hotel.UpdatedBy = UpdatedBy;
                hotel.UpdatedDate = UpdatedDate;
                hotel.IsActive = IsActive;

                obj.Hotels.Add(hotel);
                obj.SaveChanges();
            }
       }

        public void DeleteHotel(HotelClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Hotel hotel = obj.Hotels.Where(h => h.Id == data.Id).FirstOrDefault();
                obj.Hotels.Remove(hotel);
                obj.SaveChanges();
            }
        }

        public void UpdateHotel(HotelClass data)
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Hotel hotel = obj.Hotels.Where(h => h.Id == data.Id).FirstOrDefault();
                hotel.HotelName = data.HotelName;
                hotel.HotelDescription = data.HotelDescription;
                hotel.HotelRules = data.HotelRules;
                hotel.CancellationPolicy = data.CancellationPolicy;
                hotel.HotelType = data.HotelType;
                hotel.ImageId = data.ImageId;
                hotel.HotelAddress = data.HotelAddress;
                hotel.HotelRating = data.HotelRating;
                hotel.CityId = data.CityId;
                hotel.PostalCode = data.PostalCode;
                hotel.Email = data.Email;
                hotel.PhoneNo = data.PhoneNo;
                hotel.CreatedBy = data.CreatedBy;
                hotel.CreatedDate = data.CreatedDate;
                hotel.UpdatedBy = data.UpdatedBy;
                hotel.UpdatedDate = data.UpdatedDate;

                obj.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotel()
        {
            List<Hotel> hotellst = new List<Hotel>();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                hotellst = obj.Hotels.ToList();
            }
            return hotellst;
        }
#endregion

#region Filetering
        public Hotel GetByHotelId(HotelClass data)
        {
            Hotel hotel = new Hotel();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                hotel = obj.Hotels.Where(h => h.Id == data.Id).FirstOrDefault();
            }
            return hotel;
        }
#endregion
    }
}
