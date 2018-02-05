using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;


namespace OnlineTicketBL
{
    public class MasterValueBL:MasterValue
    {
        OnlineTicketBookingEntities obj;
        public MasterValueBL()
        {
            obj = new OnlineTicketBookingEntities();
        }
     
#region CRUD 
        public void AddMasterValue(MasterValue mastervalue)
        {
                obj.MasterValues.Add(mastervalue);
                obj.SaveChanges();
        }

        public void DeleteMasterValue()
        {
                //MasterValue mastervalue = obj.MasterValues.Where(mval => mval.Id == this.Id).FirstOrDefault();
                //obj.MasterValues.Remove(mastervalue);
                obj.SaveChanges();
        }

        public void UpdateMasterValue()
        {
                obj.SaveChanges();
        }

        public List<MasterValue> GetAllMasterValue()
        {
            List<MasterValue> mastervaluelst = new List<MasterValue>();
            mastervaluelst = obj.MasterValues.ToList();
            return mastervaluelst;
        }
#endregion

#region Filtering
        public MasterValue GetByMasterValueId()
        {
            MasterValue mastervalue = new MasterValue();
            mastervalue = obj.MasterValues.Where(mval => mval.Id == this.Id).FirstOrDefault();
            return mastervalue;
        }
#endregion
    }
}
