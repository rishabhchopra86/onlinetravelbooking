using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace Model
{
   public class PackageBL:Package
    {
        OnlineTicketBookingEntities obj;
        public PackageBL()
        {
            obj = new OnlineTicketBookingEntities();
        }

        #region CRUD
        public void AddPackage(Package pck)
        {
                obj.Packages.Add(pck);
                obj.SaveChanges();
        }
        public void DeletePackage()
        {
                obj.SaveChanges();
        }

        public void UpdatePackage()
        {
                obj.SaveChanges();
        }

        public List<Package> getAll()
        {
            List<Package> lst = new List<Package>();
            lst = obj.Packages.ToList();
            return lst;
        }
        #endregion

        #region Filtering Data
        public Package getByPackageid()
        {
            Package lst = new Package();
            lst = obj.Packages.Where(c => c.Id == Id).FirstOrDefault();
            return lst;
        }
        #endregion

    }
}
