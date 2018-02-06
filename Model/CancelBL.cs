using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class CancelBL:Cancel
    {
        OnlineTicketBookingEntities obj;
        public CancelBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

#region CRUD
        public void AddCancel(Cancel cancel)
        {
                obj.Cancels.Add(cancel);
                obj.SaveChanges();
        }

        public void DeleteCancel()
        {
                obj.SaveChanges();
        }

        public void UpdateCancel()
        {
                obj.SaveChanges();
        }

        public List<Cancel> GetAllCancelValue()
        {
            List<Cancel> cancellst = new List<Cancel>();
            cancellst = obj.Cancels.ToList();
            return cancellst;
        }

#endregion

#region Filtering
        public Cancel GetByCancelId()
        {
            Cancel cancel=new Cancel();
            cancel = obj.Cancels.Where(c => c.Id == Id).FirstOrDefault();
            return cancel;
        }
#endregion

    }
}
