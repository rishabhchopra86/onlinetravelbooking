using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class PackageDetailClass
    {

        public int Id { get; set; }
        public int PackageId { get; set; }
        public int TypeId { get; set; }
        public int RTCId { get; set; }
        public bool Sidescene { get; set; }
        public int FareId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }


       

        #region CRUD
        public void AddPackageDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                PackageDetail pckdtl = new PackageDetail();
                pckdtl.PackageId = PackageId;
                pckdtl.TypeId = TypeId;
                pckdtl.RTCId = RTCId;
                pckdtl.Sidescene = Sidescene;
                pckdtl.FareId = FareId;
                pckdtl.CreatedBy = CreatedBy;
                pckdtl.CreatedDate = CreatedDate;
                pckdtl.UpdatedDate = UpdatedDate;
                pckdtl.UpdatedBy = UpdatedBy;
                pckdtl.IsActive = IsActive;


                obj.PackageDetails.Add(pckdtl);
                obj.SaveChanges();
            }
        }
        public void deletePackageDetail()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                PackageDetail packagedetailId = obj.PackageDetails.SingleOrDefault(c => c.Id == Id);
                packagedetailId.IsActive = IsActive;
                obj.SaveChanges();
            }
        }
        public void updatePackageDetail()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                PackageDetail pckdtl = obj.PackageDetails.Where(c => c.Id == Id).FirstOrDefault();
                pckdtl.PackageId = PackageId;
                pckdtl.TypeId = TypeId;
                pckdtl.RTCId = RTCId;
                pckdtl.Sidescene = Sidescene;
                pckdtl.FareId = FareId;
                pckdtl.CreatedBy = CreatedBy;
                pckdtl.CreatedDate = CreatedDate;
                pckdtl.UpdatedDate = UpdatedDate;
                pckdtl.UpdatedBy = UpdatedBy;
                pckdtl.IsActive = IsActive;
                obj.SaveChanges();
            }

        }
        public static List<PackageDetail> getAll()
        {
            List<PackageDetail> lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.PackageDetails.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public PackageDetail getByPackageDetailid()
        {

            PackageDetail lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.PackageDetails.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
