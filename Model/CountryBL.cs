using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataModel;

namespace Model
{
    public class CountryBL:Country
    {
        OnlineTicketBookingEntities obj;
        public CountryBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddCountry(Country cntry)
        {
                obj.Countries.Add(cntry);
                obj.SaveChanges();
        }

        public void deleteCountry()
        {
                obj.SaveChanges();
        }

        public void updateCountry()
        {
                obj.SaveChanges();
        }

        public List<Country> getAll()
        {
            List<Country> lst = new List<Country>();
            lst = obj.Countries.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Country getByid()
        {

            Country lst = new Country();
            lst = obj.Countries.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion

    }
}
