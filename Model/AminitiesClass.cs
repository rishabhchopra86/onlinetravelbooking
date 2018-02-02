using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class AminitiesClass
    {

        public int Id { get; set; }
        public Nullable<int> TypeId { get; set; }
        public Nullable<int> RTCId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD
        public void AddAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = new Aminity();
                aminity.TypeId = TypeId;
                aminity.RTCId = RTCId;
                aminity.CreatedBy = CreatedBy;
                aminity.CreatedDate = CreatedDate;
                aminity.UpdatedBy = UpdatedBy;
                aminity.UpdatedDate = UpdatedDate;
                aminity.IsActive = IsActive;

                obj.Aminities.Add(aminity);
                obj.SaveChanges();

            }
        }

        public void DeleteAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = obj.Aminities.Where(am => am.Id == Id).FirstOrDefault();
                aminity.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = obj.Aminities.Where(am => am.Id == Id).FirstOrDefault();
                aminity.TypeId = TypeId;
                aminity.RTCId = RTCId;
                aminity.CreatedBy = CreatedBy;
                aminity.CreatedDate = CreatedDate;
                aminity.UpdatedBy = UpdatedBy;
                aminity.UpdatedDate = UpdatedDate;
                aminity.IsActive = IsActive;

                obj.SaveChanges();
            }
        }

        public List<Aminity> GetAllAminities()
        {
            List<Aminity> aminityList = new List<Aminity>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                aminityList = obj.Aminities.ToList();
            }
            return aminityList;
        }
#endregion

 #region Filtering
        public Aminity GetByAminitiesId()
        {
            Aminity aminity = new Aminity();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                aminity = obj.Aminities.Where(am=> am.Id == Id).FirstOrDefault();
            }
            return aminity;
        }
        #endregion
    }
}
