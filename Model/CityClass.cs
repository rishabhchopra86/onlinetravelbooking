﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class CityClass
    {
        public int Id { get; set; }
        public Nullable<int> StateId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> CityCode { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddCities()
        {
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               City city = new City();
               city.StateId = StateId;
               city.CityName = CityName;
               city.CityCode = CityCode;
               city.CreatedBy = CreatedBy;
               city.CreatedDate = CreatedDate;
               city.UpdatedBy = UpdatedBy;
               city.UpdatedDate = UpdatedDate;
               city.IsActive = IsActive;

               obj.Cities.Add(city);
               obj.SaveChanges();
           }
        }

       public void DeleteCitites(CityClass data)
       {
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               City city = obj.Cities.Where(c => c.Id == data.Id).FirstOrDefault();
               obj.Cities.Remove(city);
               obj.SaveChanges();
           }
       }

       public void UpdateCities(CityClass data)
       {
           using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               City city = obj.Cities.Where(c => c.Id == data.Id).FirstOrDefault();
               city.StateId = data.StateId;
               city.CityName = data.CityName;
               city.CityCode = data.CityCode;
               city.CreatedBy = data.CreatedBy;
               city.CreatedDate = data.CreatedDate;
               city.UpdatedBy = data.UpdatedBy;
               city.UpdatedDate = data.UpdatedDate;
               city.IsActive = data.IsActive;

               obj.SaveChanges();

           }
       }

       public List<City> GetAllCities()
       {
           List<City> citylst=new List<City>();
           using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
           {
               citylst=obj.Cities.ToList();
           }
           return citylst;
       }
 #endregion

#region Filtering
        public City GetByCitiesId(CityClass data)
       {
           City city = new City();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                city = obj.Cities.Where(c => c.Id == data.Id).FirstOrDefault();
            }
           return city;
       }
#endregion
    }
}
