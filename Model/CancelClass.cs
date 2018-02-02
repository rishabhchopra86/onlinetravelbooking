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

        public void DeleteCancel()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == Id).FirstOrDefault();
                cancel.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public void UpdateCancel()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == Id).FirstOrDefault();
                cancel.TransportId = TransportId;
                cancel.CancelRules = CancelRules;
                cancel.RatePer = RatePer;
                cancel.CreatedBy = CreatedBy;
                cancel.CreatedDate = CreatedDate;
                cancel.UpdatedBy = UpdatedBy;
                cancel.UpdatedDate = UpdatedDate;
                cancel.IsActive = IsActive;

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
        public Cancel GetByCancelId()
        {
            Cancel cancel=new Cancel();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                cancel = obj.Cancels.Where(c => c.Id == Id).FirstOrDefault();
            }
            return cancel;
        }
#endregion

    }
}
