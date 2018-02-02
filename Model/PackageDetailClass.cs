using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
   public class PackageDetailClass
    {

        public int Id { get; set; }
        public int PackageId { get; set; }
        public int TypeId { get; set; }
        public int RTId { get; set; }
        public bool Sidescene { get; set; }
        public int FareId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }


        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        #region CRUD
        public void AddPackageDetail()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                PackageDetail pckdtl = new PackageDetail();
                pckdtl.PackageId = PackageId;
                pckdtl.TypeId = TypeId;
                pckdtl.RTId = RTId;
                pckdtl.Sidescene = Sidescene;
                pckdtl.FareId = FareId;
                pckdtl.CreatedBy = CreatedBy;
                pckdtl.CreatedDate = CreatedDate;
                pckdtl.UpdatedDate = UpdatedDate;
                pckdtl.UpdatedBy = UpdatedBy;
                pckdtl.IsActive = IsActive;


                otbe.PackageDetails.Add(pckdtl);
                saveChanges();
            }
        }
        public void deletePackageDetail()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                PackageDetail packagedetailId = otbe.PackageDetails.SingleOrDefault(c => c.Id == Id);
                otbe.PackageDetails.Remove(packagedetailId);
                saveChanges();
            }
        }
        public void updatePackageDetail()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                PackageDetail packagedetailId = otbe.PackageDetails.SingleOrDefault(c => c.Id == Id);
                PackageDetail pckdtl = new PackageDetail();
                pckdtl.PackageId = PackageId;
                pckdtl.TypeId = TypeId;
                pckdtl.RTId = RTId;
                pckdtl.Sidescene = Sidescene;
                pckdtl.FareId = FareId;
                pckdtl.CreatedBy = CreatedBy;
                pckdtl.CreatedDate = CreatedDate;
                pckdtl.UpdatedDate = UpdatedDate;
                pckdtl.UpdatedBy = UpdatedBy;
                pckdtl.IsActive = IsActive;

                saveChanges();
            }

        }
        public static List<PackageDetail> getAll()
        {
            List<PackageDetail> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.PackageDetails select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public PackageDetail getByid()
        {

            PackageDetail lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.PackageDetails.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
