using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class CinemaClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> PhoneNo { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<decimal> Langitude { get; set; }
        public Nullable<decimal> Lattitude { get; set; }
        public string Description { get; set; }
        public Nullable<double> Ratings { get; set; }
        public string Email { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

        #region CRUD
        public void AddCinema()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Cinema cinema = new Cinema();
                cinema.Address = Address;
                cinema.CityId = CityId;
                cinema.Email = Email;
                cinema.PhoneNo = PhoneNo;
                cinema.Langitude = Langitude;
                cinema.Lattitude = Lattitude;
                cinema.Name = Name;
                cinema.Ratings = Ratings;
                cinema.CreatedBy = CreatedBy;
                cinema.CreatedDate = CreatedDate;
                cinema.UpdatedDate = UpdatedDate;
                cinema.UpdatedBy = UpdatedBy;
                cinema.IsActive = IsActive;

                obj.Cinemas.Add(cinema);
                obj.SaveChanges();
            }
        }
        public void deleteCinema()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Cinema cinema= obj.Cinemas.Where(c=>c.Id==Id).FirstOrDefault();
                cinema.IsActive = IsActive;

                obj.SaveChanges();
            }
        }
        public void updateCinema()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Cinema cinemaId = obj.Cinemas.Where(c => c.Id == Id).FirstOrDefault();
                Cinema cinema= new Cinema();
                cinema.Address = Address;
                cinema.CityId = CityId;
                cinema.Email = Email;
                cinema.PhoneNo = PhoneNo;
                cinema.Langitude = Langitude;
                cinema.Lattitude = Lattitude;
                cinema.Name = Name;
                cinema.Ratings = Ratings;
                cinema.CreatedBy = CreatedBy;
                cinema.CreatedDate = CreatedDate;
                cinema.UpdatedDate = UpdatedDate;
                cinema.UpdatedBy = UpdatedBy;
                cinema.IsActive = IsActive;

                obj.SaveChanges();

            }

        }
        public static List<Cinema> getAllCinemas()
        {
            List<Cinema> lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Cinemas.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Cinema getByid()
        {

            Cinema lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Cinemas.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion
    }
}
