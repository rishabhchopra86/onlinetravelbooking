using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;


namespace Model
{
    public class MasterValueClass
    {
        public int Id { get; set; }
        public Nullable<int> MasterId { get; set; }
        public string Description { get; set; }

#region CRUD 
        public void AddMasterValue()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                MasterValue mastervalue = new MasterValue();
                mastervalue.MasterId = MasterId;
                mastervalue.Description = Description;

                obj.MasterValues.Add(mastervalue);
                obj.SaveChanges();
            }
        }

        public void DeleteMasterValue(MasterValueClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                MasterValue mastervalue = obj.MasterValues.Where(mval => mval.Id == data.Id).FirstOrDefault();
                obj.MasterValues.Remove(mastervalue);
                obj.SaveChanges();
            }
        }

        public void UpdateMasterValue(MasterValueClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                MasterValue mastervalue = obj.MasterValues.Where(mval => mval.Id == data.Id).FirstOrDefault();
                mastervalue.MasterId = data.MasterId;
                mastervalue.Description = data.Description;

                obj.SaveChanges();
            }
        }

        public List<MasterValue> GetAllMasterValue()
        {
            List<MasterValue> mastervaluelst = new List<MasterValue>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                mastervaluelst = obj.MasterValues.ToList();
            }
            return mastervaluelst;
        }
#endregion

#region Filtering
        public MasterValue GetByMasterValueId(MasterValueClass data)
        {
            MasterValue mastervalue = new MasterValue();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                mastervalue = obj.MasterValues.Where(mval => mval.Id == data.Id).FirstOrDefault();
            }
            return mastervalue;
        }
#endregion
    }
}
