using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace Model
{
    public class CountryClass
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }

        #region CRUD
        public void AddCountry()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Country cntry = new Country();
                cntry.CountryName = CountryName;
                cntry.Continent = Continent;
                cntry.CreatedBy = CreatedBy;
                cntry.CreatedDate = CreatedDate;
                cntry.UpdatedDate = UpdatedDate;
                cntry.UpdatedBy = UpdatedBy;
                cntry.IsActive = IsActive;
                obj.Countries.Add(cntry);
                obj.SaveChanges();
            }
        }
        public void deleteCountry()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Country countryId = obj.Countries.FirstOrDefault(c=>c.Id==Id);
                countryId.IsActive = IsActive;

                obj.SaveChanges();
            }
        }
        public void updateCountry()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Country cntry = obj.Countries.FirstOrDefault(c => c.Id == Id);
                cntry.CountryName = CountryName;
                cntry.Continent = Continent;
                cntry.CreatedBy = CreatedBy;
                cntry.CreatedDate = CreatedDate;
                cntry.UpdatedDate = UpdatedDate;
                cntry.UpdatedBy = UpdatedBy;
                cntry.IsActive = IsActive;
                obj.SaveChanges();
            }

        }
        public static List<Country> getAll()
        {
            List<Country> lst = null;
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                 lst = obj.Countries.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Country getByid()
        {

            Country lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                 lst = obj.Countries.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
