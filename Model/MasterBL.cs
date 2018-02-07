using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class MasterBL:Master
    {
        OnlineTicketBookingEntities obj;
        public MasterBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddMaster(Master master)
        {
                obj.Masters.Add(master);
                obj.SaveChanges();
        }

        public void DeleteMaster()
        {
                //Master master = obj.Masters.Where(m => m.Id == this.Id).FirstOrDefault();
                //obj.Masters.Remove(master);
                obj.SaveChanges();
        }

        public void UpdateMaster()
        {
                obj.SaveChanges();
        }

        public List<Master> GetAllMaster()
        {
            List<Master> masterlst = new List<Master>();
            masterlst = obj.Masters.ToList();
            return masterlst;
        }

#endregion

#region Filtering
        public Master GetByMasterId()
        {
            Master master = new Master();
            master = obj.Masters.Where(m => m.Id == this.Id).FirstOrDefault();
            return master;
        }
#endregion
        public List<MasterValue> getMasterValues(int Id)
        {
            var lst = obj.MasterValues.Where(i => i.MasterId == Id).ToList();
            return lst;
        }
    }
}


      