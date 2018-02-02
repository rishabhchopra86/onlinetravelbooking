using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class StationClass
    {
        public int Id { get; set; }
        public string StationName { get; set; }
        public string StationCode { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ContactNo { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<double> Langitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<int> StationType { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }


        #region CRUD
        public void AddStation()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Station station = new Station();

                station.CreatedBy = CreatedBy;
                station.CreatedDate = CreatedDate;
                station.UpdatedBy = UpdatedBy;
                station.UpdatedDate = UpdatedDate;
                station.IsActive = IsActive;

                obj.Stations.Add(station);
                obj.SaveChanges();
            }
        }

     
        #endregion

    }
}
