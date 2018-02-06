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
#endregion
    }
}
