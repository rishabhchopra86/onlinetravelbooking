using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
    public class CancelClass:Cancel
    {
 
#region CRUD
        public void AddCancel()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = new Cancel();
                cancel.TransportId = this.TransportId;
                cancel.CancelRules = this.CancelRules;
                cancel.RatePer = this.RatePer;
                cancel.CreatedBy = this.CreatedBy;
                cancel.CreatedDate = this.CreatedDate;
                cancel.UpdatedBy = this.UpdatedBy;
                cancel.UpdatedDate = this.UpdatedDate;
                cancel.IsActive = this.IsActive;

                obj.Cancels.Add(cancel);
                obj.SaveChanges();
            }
        }

        public void DeleteCancel()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == this.Id).FirstOrDefault();
                cancel.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public void UpdateCancel()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Cancel cancel = obj.Cancels.Where(c => c.Id == this.Id).FirstOrDefault();
                cancel.TransportId = this.TransportId;
                cancel.CancelRules = this.CancelRules;
                cancel.RatePer = this.RatePer;
                cancel.CreatedBy = this.CreatedBy;
                cancel.CreatedDate = this.CreatedDate;
                cancel.UpdatedBy = this.UpdatedBy;
                cancel.UpdatedDate = this.UpdatedDate;
                cancel.IsActive = this.IsActive;

                obj.SaveChanges();
                
            }
        }

        public List<CancelClass> GetAllCancelValue()
        {
            List<Cancel> cancellst = new List<Cancel>();
            List<CancelClass> cancellstclass = new List<CancelClass>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                cancellst = obj.Cancels.ToList();
                foreach(var cancel in cancellst)
                {
                    cancellstclass.Add((CancelClass)CopyProperties(cancel, this));
                }
            }
            return cancellstclass;
        }

        public object CopyProperties(object source, object destination)
        {
            PropertyInfo[] destinationProperties = destination.GetType().GetProperties();
            foreach (PropertyInfo destinationPi in destinationProperties)
            {
                PropertyInfo sourcePi = source.GetType().GetProperty(destinationPi.Name);
                destinationPi.SetValue(destination, sourcePi.GetValue(source, null), null);
            }
            return destination;
        }
#endregion

#region Filtering
        public CancelClass GetByCancelId()
        {
            Cancel cancel=new Cancel();
            CancelClass cancelclass;
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                cancel = obj.Cancels.Where(c => c.Id == Id).FirstOrDefault();
                cancelclass = (CancelClass)CopyProperties(cancel, this);
            }
            return cancelclass;
        }
#endregion

    }
}
