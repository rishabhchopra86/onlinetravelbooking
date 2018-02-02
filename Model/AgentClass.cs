using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace Model
{
    public class AgentClass
    {
        public int Id { get; set; }
        public string TravellerName { get; set; }
        public string TravellerLogo { get; set; }
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<int> MobileNo { get; set; }
        public Nullable<int> AlternateMobileNo { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> Ratings { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }

#region CRUD

        public void AddAgent()
        {
            using (OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = new Agent();
                agent.TravellerName = TravellerName;
                agent.TravellerLogo = TravellerLogo;
                agent.Address = Address;
                agent.FirstName = FirstName;
                agent.LastName = LastName;
                agent.MiddleName = MiddleName;
                agent.MobileNo = MobileNo;
                agent.AlternateMobileNo = AlternateMobileNo;
                agent.CityId = CityId;
                agent.Ratings = Ratings;
                agent.CreatedBy = CreatedBy;
                agent.CreatedDate = CreatedDate;
                agent.UpdatedBy = UpdatedBy;
                agent.UpdatedDate = UpdatedDate;
                agent.IsActive = IsActive;

                obj.Agents.Add(agent);
                obj.SaveChanges();

            }
        }

        public void DeleteAgent()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = obj.Agents.Where(a => a.Id == Id).FirstOrDefault();
                agent.IsActive = IsActive;
                obj.SaveChanges();
            }
        }

        public void UpdateAgent()
        {
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                Agent agent = obj.Agents.Where(a=> a.Id == Id).FirstOrDefault();
                agent.TravellerName = TravellerName;
                agent.TravellerLogo = TravellerLogo;
                agent.Address = Address;
                agent.FirstName = FirstName;
                agent.LastName = LastName;
                agent.MiddleName = MiddleName;
                agent.MobileNo = MobileNo;
                agent.AlternateMobileNo = AlternateMobileNo;
                agent.CityId = CityId;
                agent.Ratings = Ratings;
                agent.CreatedBy = CreatedBy;
                agent.CreatedDate = CreatedDate;
                agent.UpdatedBy = UpdatedBy;
                agent.UpdatedDate = UpdatedDate;
                agent.IsActive = IsActive;
                
                obj.SaveChanges();
            }
        }

        public List<Agent>GetAllAgent()
        {
            List<Agent> agentList=new List<Agent>();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                agentList=obj.Agents.ToList();
            }
            return agentList;
        }

#endregion

#region Filtering
        public Agent GetByAgentId()
        {
            Agent agent=new Agent();
            using(OnlineTicketBookingEntities obj=new OnlineTicketBookingEntities())
            {
                 agent = obj.Agents.Where(a => a.Id == Id).FirstOrDefault();
            }
            return agent;
        }
#endregion
    }
}

