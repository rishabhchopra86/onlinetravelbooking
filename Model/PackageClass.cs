using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
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

        private OnlineTicketBookingEntities _context;

        public void saveChanges()
        {
            _context.SaveChanges();
        }


        #region CRUD
        public void AddPackage()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
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

                otbe.Packages.Add(pck);
                saveChanges();
            }
        }
        public void deleteCountry()
        {
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Package packageId = otbe.Packages.SingleOrDefault(c => c.Id == Id);
                otbe.Packages.Remove(packageId);
                saveChanges();
            }
        }
        public void updateCountry()
        {

            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                Package countryId = otbe.Packages.SingleOrDefault(c => c.Id == Id);
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
                saveChanges();
            }

        }
        public static List<Package> getAll()
        {
            List<Package> lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = (from i in otbe.Packages select i).ToList();
            }

            return lst;
        }
        #endregion

        #region Filtering Data
        public Package getByid()
        {

            Package lst = null;
            using (OnlineTicketBookingEntities otbe = new OnlineTicketBookingEntities())
            {
                lst = otbe.Packages.Where(c => c.Id == Id).FirstOrDefault();
            }

            return lst;
        }
        #endregion

    }
}
