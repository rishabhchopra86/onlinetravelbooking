using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class CityBL:City
    {
        OnlineTicketBookingEntities obj;
        public CityBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddCities(City city)
        {
               obj.Cities.Add(city);
               obj.SaveChanges();
        }

       public void DeleteCitites()
       {
                obj.SaveChanges();
       }

       public void UpdateCities()
       {
               obj.SaveChanges();
       }

       public List<City> GetAllCities()
       {
           List<City> citylst=new List<City>();
           citylst=obj.Cities.ToList();
           return citylst;
       }
 #endregion

#region Filtering
        public City GetByCitiesId()
       {
           City city = new City();
           city = obj.Cities.Where(c => c.Id == Id).FirstOrDefault();
           return city;
       }
        public int getCityId(string cityname)
        {
            var id=obj.Cities.Where(c => c.CityName == cityname).FirstOrDefault();
            if (id == null)
            {
                return 0;
            }
            return id.Id;
        }
        #endregion
        public List<City> GetallCitiesbyCountry(int Id)
        {
            List<City> citylst = new List<City>();
            var state = obj.States.Where(i => i.CountryId == Id).ToList();
            foreach(State s in state)
            {
                var cities = obj.Cities.Where(i => i.StateId == s.Id).ToList();
                foreach(City c in cities)
                {
                    citylst.Add(c);
                }
            }
            return citylst;
        }
    }
}
