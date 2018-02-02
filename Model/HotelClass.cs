using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
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


        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        #region CRUD
        public void AddHotel()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
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

                otbe.Hotels.Add(htl);
                saveChanges();
            }
        }
        public void deleteHotel()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Hotel reviewId = otbe.Hotels.SingleOrDefault(c => c.Id == Id);
                otbe.Hotels.Remove(reviewId);
                saveChanges();
            }
        }
        public void updateHotel()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Hotel reviewId = otbe.Hotels.SingleOrDefault(c => c.Id == Id);
              
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

                saveChanges();
            }

        }
        public static List<Hotel> getAll()
        {
            List<Hotel> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.Hotels select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Hotel getByid()
        {

            Hotel lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.Hotels.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
