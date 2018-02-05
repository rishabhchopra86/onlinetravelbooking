using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Reflection;

namespace Model
{
   public class AminitiesClass:Aminity
    {

      

#region CRUD
        public void AddAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = new Aminity();
                aminity.TypeId = this.TypeId;
                aminity.RTCId = this.RTCId;
                aminity.CreatedBy = this.CreatedBy;
                aminity.CreatedDate = this.CreatedDate;
                aminity.UpdatedBy = this.UpdatedBy;
                aminity.UpdatedDate = this.UpdatedDate;
                aminity.IsActive = this.IsActive;

                obj.Aminities.Add(aminity);
                obj.SaveChanges();

            }
        }

        public void DeleteAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = obj.Aminities.Where(am => am.Id == this.Id).FirstOrDefault();
                aminity.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateAminities()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Aminity aminity = obj.Aminities.Where(am => am.Id == this.Id).FirstOrDefault();
                aminity.TypeId = this.TypeId;
                aminity.RTCId = this.RTCId;
                aminity.CreatedBy = this.CreatedBy;
                aminity.CreatedDate = this.CreatedDate;
                aminity.UpdatedBy = this.UpdatedBy;
                aminity.UpdatedDate = this.UpdatedDate;
                aminity.IsActive = this.IsActive;

                obj.SaveChanges();
            }
        }

        public List<AminitiesClass> GetAllAminities()
        {
            List<Aminity> aminitylist = new List<Aminity>();
            List<AminitiesClass> aminityclassList = new List<AminitiesClass>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                aminitylist = obj.Aminities.ToList();
                foreach (var ami in aminitylist)
                {
                    aminityclassList.Add((AminitiesClass)CopyProperties(ami, this));
                }
            }
            return aminityclassList;
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
        public AminitiesClass GetByAminitiesId()
        {
            Aminity aminity = new Aminity();
            AminitiesClass aminityclass;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                aminity = obj.Aminities.Where(am=> am.Id == this.Id).FirstOrDefault();
                aminityclass = (AminitiesClass)CopyProperties(aminity, this);
            }
            return aminityclass;
         }
#endregion
    }
}
