using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
   public class PackageDetailBL:PackageDetail
    {
        OnlineTicketBookingEntities obj;
        public PackageDetailBL()
        {
            obj = new OnlineTicketBookingEntities();
        }      

        #region CRUD
        public void AddPackageDetail(PackageDetail pckdtl)
        {
                obj.PackageDetails.Add(pckdtl);
                obj.SaveChanges();
        }

        public void deletePackageDetail()
        {
                obj.SaveChanges();
        }

        public void updatePackageDetail()
        {
                obj.SaveChanges();
        }

        public List<PackageDetail> getAll()
        {
            List<PackageDetail> lst = new List<PackageDetail>();
            lst = obj.PackageDetails.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public PackageDetail getByPackageDetailid()
        {
            PackageDetail lst = new PackageDetail();
            lst = obj.PackageDetails.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion

    }
}
