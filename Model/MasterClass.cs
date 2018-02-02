using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class MasterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

#region CRUD
        public void AddMaster()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Master master = new Master();
                master.Name = Name;
                master.Description = Description;

                obj.Masters.Add(master);
                obj.SaveChanges();
            }
        }

        public void DeleteMastrer()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Master master = obj.Masters.Where(m => m.Id == Id).FirstOrDefault();
                obj.Masters.Remove(master);
                obj.SaveChanges();
            }
        }

        public void UpdateMaster()
        {
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                Master master = obj.Masters.Where(m => m.Id == Id).FirstOrDefault();
                master.Name = Name;
                master.Description = Description;

                obj.SaveChanges();
            }
        }
        public List<Master> GetAllMaster()
        {
            List<Master> masterlst = new List<Master>();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                masterlst = obj.Masters.ToList();
            }
            return masterlst;
        }

#endregion

#region Filtering
        public Master GetByMasterId()
        {
            Master master = new Master();
            using (OnlineTicketBookingEntities obj = new OnlineTicketBookingEntities())
            {
                master = obj.Masters.Where(m => m.Id == Id).FirstOrDefault();
            }
            return master;
        }
#endregion
    }
}


      