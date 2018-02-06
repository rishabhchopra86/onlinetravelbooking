using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class AminitiesBL:Aminity
    {
        OnlineTicketBookingEntities obj;
        public AminitiesBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddAminities(Aminity aminity)
        {
                obj.Aminities.Add(aminity);
                obj.SaveChanges();
        }

        public void DeleteAminities()
        {
                obj.SaveChanges();
        }

        public void UpdateAminities()
        {
                obj.SaveChanges();
        }

        public List<Aminity> GetAllAminities()
        {
            List<Aminity> aminityList = new List<Aminity>();
            aminityList = obj.Aminities.ToList();
            return aminityList;
        }
#endregion

 #region Filtering
        public Aminity GetByAminitiesId()
        {
            Aminity aminity = new Aminity();
            aminity = obj.Aminities.Where(am=> am.Id == Id).FirstOrDefault();
            return aminity;
        }
        #endregion
    }
}
