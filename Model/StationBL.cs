using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class StationBL:Station
    {
        OnlineTicketBookingEntities obj;
        public StationBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddStation(Station station)
        {
                obj.Stations.Add(station);
                obj.SaveChanges();
        }

        public void DeleteStation()
        {
                obj.SaveChanges();
        }

        public void updateState()
        {
                obj.SaveChanges();
        }

        public List<Station> getAll()
        {
            List<Station> lst = new List<Station>();
            lst = obj.Stations.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Station getByid()
        {
            Station lst = new Station();
            lst = obj.Stations.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion

    }
}
