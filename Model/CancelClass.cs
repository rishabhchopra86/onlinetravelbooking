using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class CancelClass
    {
        public int Id { get; set; }
        public Nullable<int> TransportId { get; set; }
        public string CancelRules { get; set; }
        public Nullable<double> RatePer { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddCancel()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = new Cancel();
                cancel.TransportId = TransportId;
                cancel.CancelRules = CancelRules;
                cancel.RatePer = RatePer;
                cancel.CreatedBy = CreatedBy;
                cancel.CreatedDate = CreatedDate;
                cancel.UpdatedBy = UpdatedBy;
                cancel.UpdatedDate = UpdatedDate;
                cancel.IsActive = IsActive;

                obj.Cancels.Add(cancel);
                obj.SaveChanges();
            }
        }

        public void DeleteCancel(CancelClass data)
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == data.Id).FirstOrDefault();
                obj.Cancels.Remove(cancel);
                obj.SaveChanges();
            }
        }

        public void UpdateCancel(CancelClass data)
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == data.Id).FirstOrDefault();
                cancel.TransportId = data.TransportId;
                cancel.CancelRules = data.CancelRules;
                cancel.RatePer = data.RatePer;
                cancel.CreatedBy = data.CreatedBy;
                cancel.CreatedDate = data.CreatedDate;
                cancel.UpdatedBy = data.UpdatedBy;
                cancel.UpdatedDate = data.UpdatedDate;
                cancel.IsActive = data.IsActive;

                obj.SaveChanges();
                
            }
        }

        public List<Cancel> GetAllCancelValue()
        {
            List<Cancel> cancellst = new List<Cancel>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                cancellst = obj.Cancels.ToList();
            }
            return cancellst;
        }

#endregion

#region Filtering
        public Cancel GetByCancelId(CancelClass data)
        {
            Cancel cancel=new Cancel();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                cancel = obj.Cancels.Where(c => c.Id == data.Id).FirstOrDefault();
            }
            return cancel;
        }
#endregion

    }
}
