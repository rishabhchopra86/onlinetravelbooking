using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayer;

namespace BusinessLayer
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

        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        #region CRUD
        public void AddCountry()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Country cntry = new Country();
                cntry.CountryName = CountryName;
                cntry.Continent = Continent;
                cntry.CreatedBy = CreatedBy;
                cntry.CreatedDate = CreatedDate;
                cntry.UpdatedDate = UpdatedDate;
                cntry.UpdatedBy = UpdatedBy;

                otbe.Countries.Add(cntry);
                saveChanges();
            }
        }
        public void deleteCountry()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Country countryId = otbe.Countries.SingleOrDefault(c=>c.Id==Id);
                otbe.Countries.Remove(countryId);
                saveChanges();
            }
        }
        public void updateCountry()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Country countryId = otbe.Countries.SingleOrDefault(c => c.Id == Id);
                Country cntry = new Country();
                cntry.CountryName = CountryName;
                cntry.Continent = Continent;
                cntry.CreatedBy = CreatedBy;
                cntry.CreatedDate = CreatedDate;
                cntry.UpdatedDate = UpdatedDate;
                cntry.UpdatedBy = UpdatedBy;
                saveChanges();
            }

        }
        public static List<Country> getAll()
        {
            List<Country> lst = null;
            using (OnlineTicketBookingEntities otbe=new OnlineTicketBookingEntities())
            {
                 lst = (from i in otbe.Countries select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Country getByid()
        {

            Country lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                 lst = otbe.Countries.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
