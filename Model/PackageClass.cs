using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
   public class PackageClass
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public double ActualRate { get; set; }
        public double PerPersonRate { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfNight { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }



        #region CRUD
        public void AddPackage()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Package pck = new Package();
                pck.PackageName = PackageName;
                pck.Description = Description;
                pck.ActualRate = ActualRate;
                pck.PerPersonRate = PerPersonRate;
                pck.NoOfDays = NoOfDays;
                pck.NoOfNight = NoOfNight;
                pck.CreatedBy = CreatedBy;
                pck.CreatedDate = CreatedDate;
                pck.UpdatedBy = UpdatedBy;
                pck.UpdatedDate = UpdatedDate;
                pck.IsActive = IsActive;

                obj.Packages.Add(pck);
                obj.SaveChanges();
            }
        }
        public void DeletePackage()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Package packageId = obj.Packages.Where(c => c.Id == Id).FirstOrDefault();
                packageId.IsActive = IsActive;
                obj.SaveChanges();
            }
        }
        public void UpdatePackage()
        {

            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Package pck = obj.Packages.Where(c => c.Id == Id).FirstOrDefault();
               
                pck.PackageName = PackageName;
                pck.Description = Description;
                pck.ActualRate = ActualRate;
                pck.PerPersonRate = PerPersonRate;
                pck.NoOfDays = NoOfDays;
                pck.NoOfNight = NoOfNight;
                pck.CreatedBy = CreatedBy;
                pck.CreatedDate = CreatedDate;
                pck.UpdatedBy = UpdatedBy;
                pck.UpdatedDate = UpdatedDate;
                pck.IsActive = IsActive;
                obj.SaveChanges();

            }

        }
        public static List<Package> getAll()
        {
            List<Package> lst = null;
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Packages.ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Package getByPackageid()
        {

            Package lst = new Package();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                lst = obj.Packages.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
