using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class CinemaBL:Cinema
    {
        OnlineTicketBookingEntities obj;
        public CinemaBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddCinema(Cinema cinema)
        {
                obj.Cinemas.Add(cinema);
                obj.SaveChanges();
        }
        public void deleteCinema()
        {
              //Cinema cinema= obj.Cinemas.Where(c=>c.Id==this.Id).FirstOrDefault();
              //cinema.IsActive = IsActive;
              obj.SaveChanges();
        }

        public void updateCinema()
        {
                obj.SaveChanges();
        }

        public List<Cinema> getAllCinemas()
        {
            List<Cinema> lst = new List<Cinema>();
            lst = obj.Cinemas.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Cinema getByid()
        {
            Cinema lst = new Cinema();
            lst = obj.Cinemas.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }

        
        #endregion
    }
}
